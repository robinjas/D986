using Inventory_Management_System.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class Add_Part : Form
    {
        public Add_Part()
        {
            InitializeComponent();

            RdoInHouse.CheckedChanged += RdoInHouse_CheckedChanged;
            RdoOutsourced.CheckedChanged += RdoOutsourced_CheckedChanged;
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
                    throw new Exception("Inventory, Price, Max, and Min must be valid numbers.");

                if (min > max)
                    throw new Exception("Min cannot be greater than Max.");

                if (inventory < min || inventory > max)
                    throw new Exception("Inventory must be between Min and Max.");

                Part newPart;

                if (RdoInHouse.Checked)
                {
                    if (!int.TryParse(TxtCompanyOrMachine.Text, out int machineID))
                        throw new Exception("Machine ID must be a number.");

                    newPart = new Inhouse
                    {
                        PartID = GenerateNewPartID(),
                        Name = name,
                        Price = price,
                        InStock = inventory,
                        Min = min,
                        Max = max,
                        MachineID = machineID
                    };
                }
                else
                {
                    newPart = new Outsourced
                    {
                        PartID = GenerateNewPartID(),
                        Name = name,
                        Price = price,
                        InStock = inventory,
                        Min = min,
                        Max = max,
                        CompanyName = TxtCompanyOrMachine.Text
                    };
                }

                Inventory.addPart(newPart);

                MessageBox.Show("Part added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GenerateNewPartID()
        {
            return Inventory.AllParts.Any() ? Inventory.AllParts.Max(p => p.PartID) + 1 : 1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
