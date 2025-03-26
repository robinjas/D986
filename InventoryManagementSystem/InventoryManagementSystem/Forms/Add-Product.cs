using Inventory_Management_System.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class Add_Product : Form
    {
        private BindingList<Part> associatedParts = new();

        public Add_Product()
        {
            InitializeComponent();
            DvgAllParts.DataSource = Inventory.AllParts;
            DvgAssociatedParts.DataSource = associatedParts;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (DvgAllParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                if (!associatedParts.Contains(selectedPart))
                {
                    associatedParts.Add(selectedPart);
                }
            }
        }

        private void BtnDeletePart_Click(object sender, EventArgs e)
        {
            if (DvgAssociatedParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                var confirm = MessageBox.Show("Remove associated part?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    associatedParts.Remove(selectedPart);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = TxtSearch.Text.Trim();

            if (int.TryParse(query, out int partID))
            {
                var part = Inventory.lookupPart(partID);
                if (part != null)
                    DvgAllParts.DataSource = new BindingList<Part> { part };
                else
                    MessageBox.Show("Part not found.");
            }
            else
            {
                var results = Inventory.AllParts
                    .Where(p => p.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                if (results.Any())
                    DvgAllParts.DataSource = new BindingList<Part>(results);
                else
                    MessageBox.Show("No matching parts found.");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TxtName.Text;
                bool validInventory = int.TryParse(TxtInventory.Text, out int inventory);
                bool validPrice = decimal.TryParse(TxtPrice.Text, out decimal price);
                bool validMax = int.TryParse(TxtMax.Text, out int max);
                bool validMin = int.TryParse(TxtMin.Text, out int min);

                if (!validInventory || !validPrice || !validMax || !validMin)
                    throw new Exception("Inventory, Price, Min, and Max must be valid numbers.");

                if (min > max)
                    throw new Exception("Min cannot be greater than Max.");

                if (inventory < min || inventory > max)
                    throw new Exception("Inventory must be between Min and Max.");

                Product newProduct = new Product
                {
                    ProductID = GenerateNewProductID(),
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    AssociatedParts = new BindingList<Part>(associatedParts)
                };

                Inventory.addProduct(newProduct);

                MessageBox.Show("Product added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GenerateNewProductID()
        {
            return Inventory.Products.Any() ? Inventory.Products.Max(p => p.ProductID) + 1 : 1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
