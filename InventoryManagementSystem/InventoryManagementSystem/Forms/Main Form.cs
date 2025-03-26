using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Forms
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            this.Load += Main_Form_Load;
        }

        private void Main_Form_Load(object? sender, EventArgs e)
        {
            // === Configure DgvParts ===
            DgvParts.AutoGenerateColumns = false;
            DgvParts.Columns.Clear();
            DgvParts.DataSource = Inventory.AllParts;

            DgvParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Part ID",
                DataPropertyName = "PartID"
            });
            DgvParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Part Name",
                DataPropertyName = "Name"
            });
            DgvParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Inventory",
                DataPropertyName = "InStock"
            });
            DgvParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                DataPropertyName = "Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            // === Configure DgvProducts ===
            DgvProducts.AutoGenerateColumns = false;
            DgvProducts.Columns.Clear();
            DgvProducts.DataSource = Inventory.Products;

            DgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Product ID",
                DataPropertyName = "ProductID"
            });
            DgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Product Name",
                DataPropertyName = "Name"
            });
            DgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Inventory",
                DataPropertyName = "InStock"
            });
            DgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                DataPropertyName = "Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }

        private void BtnAddPart_Click(object sender, EventArgs e)
        {
            Add_Part addPartForm = new();
            addPartForm.ShowDialog();
            DgvParts.DataSource = null;
            DgvParts.DataSource = Inventory.AllParts;
        }

        private void BtnModifyPart_Click(object sender, EventArgs e)
        {
            if (DgvParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                Modify_Part modifyPartForm = new(selectedPart);
                modifyPartForm.ShowDialog();
                DgvParts.DataSource = null;
                DgvParts.DataSource = Inventory.AllParts;
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

        private void BtnDeletePart_Click(object sender, EventArgs e)
        {
            if (DgvParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                bool isAssociated = Inventory.Products.Any(product => product.AssociatedParts.Contains(selectedPart));
                if (isAssociated)
                {
                    MessageBox.Show("Cannot delete a part that is associated with a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("Delete selected part?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Inventory.deletePart(selectedPart);
                    DgvParts.DataSource = null;
                    DgvParts.DataSource = Inventory.AllParts;
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            Add_Product addProductForm = new();
            addProductForm.ShowDialog();
            DgvProducts.DataSource = null;
            DgvProducts.DataSource = Inventory.Products;
        }

        private void BtnModifyProduct_Click(object sender, EventArgs e)
        {
            if (DgvProducts.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                Modify_Product modifyProductForm = new(selectedProduct);
                modifyProductForm.ShowDialog();
                DgvProducts.DataSource = null;
                DgvProducts.DataSource = Inventory.Products;
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (DgvProducts.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                var confirm = MessageBox.Show("Delete selected product?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Inventory.removeProduct(selectedProduct.ProductID);
                    DgvProducts.DataSource = null;
                    DgvProducts.DataSource = Inventory.Products;
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void BtnSearchPart_Click(object sender, EventArgs e)
        {
            string query = TxtSearchParts.Text.Trim();

            if (int.TryParse(query, out int id))
            {
                var part = Inventory.lookupPart(id);
                if (part != null)
                    DgvParts.DataSource = new BindingList<Part> { part };
                else
                    MessageBox.Show("Part not found.");
            }
            else
            {
                var results = Inventory.AllParts
                    .Where(p => p.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                if (results.Any())
                    DgvParts.DataSource = new BindingList<Part>(results);
                else
                    MessageBox.Show("No parts match the search.");
            }
        }

        private void BtnSearchProduct_Click(object sender, EventArgs e)
        {
            string query = TxtSearchProducts.Text.Trim();

            if (int.TryParse(query, out int id))
            {
                var product = Inventory.lookupProduct(id);
                if (product != null)
                    DgvProducts.DataSource = new BindingList<Product> { product };
                else
                    MessageBox.Show("Product not found.");
            }
            else
            {
                var results = Inventory.Products
                    .Where(p => p.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                if (results.Any())
                    DgvProducts.DataSource = new BindingList<Product>(results);
                else
                    MessageBox.Show("No products match the search.");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
