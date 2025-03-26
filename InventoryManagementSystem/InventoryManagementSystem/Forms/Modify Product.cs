using Inventory_Management_System.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class Modify_Product : Form
    {
        private Product selectedProduct;

        public Modify_Product(Product product)
        {
            InitializeComponent();
            selectedProduct = product;
            LoadProductData();
        }

        private void LoadProductData()
        {
            TxtID.Text = selectedProduct.ProductID.ToString();
            TxtName.Text = selectedProduct.Name;
            TxtInventory.Text = selectedProduct.InStock.ToString();
            TxtPrice.Text = selectedProduct.Price.ToString();
            TxtMin.Text = selectedProduct.Min.ToString();
            TxtMax.Text = selectedProduct.Max.ToString();

            // Display parts associated with this product
            DvgAssociatedParts.DataSource = new BindingList<Part>(selectedProduct.AssociatedParts.ToList());

            // Display all parts in top grid for adding associations
            DvgAllParts.DataSource = Inventory.AllParts;
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

                Product updatedProduct = new Product
                {
                    ProductID = selectedProduct.ProductID,
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Max = max,
                    Min = min,
                    AssociatedParts = new BindingList<Part>()
                };

                foreach (DataGridViewRow row in DvgAssociatedParts.Rows)
                {
                    if (row.DataBoundItem is Part part)
                        updatedProduct.addAssociatedPart(part);
                }

                int index = Inventory.Products.IndexOf(selectedProduct);
                Inventory.updateProduct(index, updatedProduct);

                MessageBox.Show("Product updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = TxtSearch.Text.Trim();

            if (int.TryParse(query, out int partID))
            {
                var part = Inventory.lookupPart(partID);
                if (part != null)
                {
                    DvgAllParts.DataSource = new BindingList<Part> { part };
                }
                else
                {
                    MessageBox.Show("Part not found.");
                }
            }
            else
            {
                var results = Inventory.AllParts
                    .Where(p => p.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                if (results.Any())
                {
                    DvgAllParts.DataSource = new BindingList<Part>(results);
                }
                else
                {
                    MessageBox.Show("No parts match your search.");
                }
            }
        }

    }
}
