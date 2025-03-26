using Inventory_Management_System.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class Modify_Part : Form
    {
        private Part originalPart;
        private int partIndex;

        public Modify_Part(Part part)
        {
            InitializeComponent();
            RdoInHouse.CheckedChanged += RdoInHouse_CheckedChanged;
            RdoOutsourced.CheckedChanged += RdoOutsourced_CheckedChanged;

            originalPart = part;
            partIndex = Inventory.AllParts.IndexOf(part);

            LoadPartData();
        }

        private void LoadPartData()
        {
            TxtID.Text = originalPart.PartID.ToString();
            TxtName.Text = originalPart.Name;
            TxtInventory.Text = originalPart.InStock.ToString();
            TxtPrice.Text = originalPart.Price.ToString();
            TxtMax.Text = originalPart.Max.ToString();
            TxtMin.Text = originalPart.Min.ToString();

            if (originalPart is Inhouse inhousePart)
            {
                RdoInHouse.Checked = true;
                TxtCompanyOrMachine.Text = inhousePart.MachineID.ToString();
            }
            else if (originalPart is Outsourced outsourcedPart)
            {
                RdoOutsourced.Checked = true;
                TxtCompanyOrMachine.Text = outsourcedPart.CompanyName;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtInventory.Text) ||
                string.IsNullOrWhiteSpace(TxtPrice.Text) ||
                string.IsNullOrWhiteSpace(TxtMax.Text) ||
                string.IsNullOrWhiteSpace(TxtMin.Text) ||
                string.IsNullOrWhiteSpace(TxtCompanyOrMachine.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool validInventory = int.TryParse(TxtInventory.Text, out int inventory);
            bool validPrice = decimal.TryParse(TxtPrice.Text, out decimal price);
            bool validMax = int.TryParse(TxtMax.Text, out int max);
            bool validMin = int.TryParse(TxtMin.Text, out int min);

            if (!validInventory || !validPrice || !validMax || !validMin)
            {
                MessageBox.Show("Inventory, Price, Max, and Min must be valid numbers.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }

            Part updatedPart;

            if (RdoInHouse.Checked)
            {
                if (!int.TryParse(TxtCompanyOrMachine.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a number.");
                    return;
                }

                updatedPart = new Inhouse
                {
                    PartID = originalPart.PartID,
                    Name = TxtName.Text,
                    Price = price,
                    InStock = inventory,
                    Min = min,
                    Max = max,
                    MachineID = machineID
                };
            }
            else
            {
                updatedPart = new Outsourced
                {
                    PartID = originalPart.PartID,
                    Name = TxtName.Text,
                    Price = price,
                    InStock = inventory,
                    Min = min,
                    Max = max,
                    CompanyName = TxtCompanyOrMachine.Text
                };
            }

            Inventory.updatePart(partIndex, updatedPart);

            MessageBox.Show("Part updated successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RdoInHouse_CheckedChanged(object? sender, EventArgs e)
        {
            if (RdoInHouse.Checked)
                LblCompanyOrMachine.Text = "Machine ID";
        }

        private void RdoOutsourced_CheckedChanged(object? sender, EventArgs e)
        {
            if (RdoOutsourced.Checked)
                LblCompanyOrMachine.Text = "Company Name";
        }
    }
}
