namespace Inventory_Management_System.Forms
{
    partial class Modify_Part
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            RdoInHouse = new RadioButton();
            RdoOutsourced = new RadioButton();
            LblID = new Label();
            LblName = new Label();
            LblInventory = new Label();
            LblPrice = new Label();
            LblMin = new Label();
            LblMax = new Label();
            LblCompanyOrMachine = new Label();
            TxtID = new TextBox();
            TxtName = new TextBox();
            TxtInventory = new TextBox();
            TxtPrice = new TextBox();
            TxtMax = new TextBox();
            TxtMin = new TextBox();
            TxtCompanyOrMachine = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            LblFormTitle = new Label();
            SuspendLayout();

            // Form title
            LblFormTitle.AutoSize = true;
            LblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblFormTitle.Location = new Point(20, 20);
            LblFormTitle.Name = "LblFormTitle";
            LblFormTitle.Size = new Size(90, 21);
            LblFormTitle.TabIndex = 0;
            LblFormTitle.Text = "Modify Part";

            // Radio buttons
            RdoInHouse.AutoSize = true;
            RdoInHouse.Checked = true;
            RdoInHouse.Location = new Point(30, 60);
            RdoInHouse.Name = "RdoInHouse";
            RdoInHouse.Size = new Size(74, 19);
            RdoInHouse.TabIndex = 0;
            RdoInHouse.TabStop = true;
            RdoInHouse.Text = "In-House";
            RdoInHouse.UseVisualStyleBackColor = true;
            RdoInHouse.CheckedChanged += RdoInHouse_CheckedChanged;

            RdoOutsourced.AutoSize = true;
            RdoOutsourced.Location = new Point(120, 60);
            RdoOutsourced.Name = "RdoOutsourced";
            RdoOutsourced.Size = new Size(87, 19);
            RdoOutsourced.TabIndex = 1;
            RdoOutsourced.Text = "Outsourced";
            RdoOutsourced.UseVisualStyleBackColor = true;
            RdoOutsourced.CheckedChanged += RdoOutsourced_CheckedChanged;

            // Labels
            LblID.AutoSize = true;
            LblID.Location = new Point(30, 100);
            LblID.Name = "LblID";
            LblID.Size = new Size(21, 15);
            LblID.TabIndex = 2;
            LblID.Text = "ID";

            LblName.AutoSize = true;
            LblName.Location = new Point(30, 140);
            LblName.Name = "LblName";
            LblName.Size = new Size(42, 15);
            LblName.TabIndex = 3;
            LblName.Text = "Name";

            LblInventory.AutoSize = true;
            LblInventory.Location = new Point(30, 180);
            LblInventory.Name = "LblInventory";
            LblInventory.Size = new Size(60, 15);
            LblInventory.TabIndex = 4;
            LblInventory.Text = "Inventory";

            LblPrice.AutoSize = true;
            LblPrice.Location = new Point(30, 220);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(68, 15);
            LblPrice.TabIndex = 5;
            LblPrice.Text = "Price";

            LblMax.AutoSize = true;
            LblMax.Location = new Point(30, 260);
            LblMax.Name = "LblMax";
            LblMax.Size = new Size(33, 15);
            LblMax.TabIndex = 7;
            LblMax.Text = "Max";

            LblMin.AutoSize = true;
            LblMin.Location = new Point(160, 260);
            LblMin.Name = "LblMin";
            LblMin.Size = new Size(31, 15);
            LblMin.TabIndex = 6;
            LblMin.Text = "Min";

            LblCompanyOrMachine.AutoSize = true;
            LblCompanyOrMachine.Location = new Point(30, 300);
            LblCompanyOrMachine.Name = "LblCompanyOrMachine";
            LblCompanyOrMachine.Size = new Size(71, 15);
            LblCompanyOrMachine.TabIndex = 8;
            LblCompanyOrMachine.Text = "Machine ID";

            // TextBoxes
            TxtID.Location = new Point(146, 100);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(150, 23);
            TxtID.TabIndex = 9;
            TxtID.Enabled = false;

            TxtName.Location = new Point(146, 140);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 23);
            TxtName.TabIndex = 10;

            TxtInventory.Location = new Point(146, 180);
            TxtInventory.Name = "TxtInventory";
            TxtInventory.Size = new Size(150, 23);
            TxtInventory.TabIndex = 11;

            TxtPrice.Location = new Point(146, 220);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(150, 23);
            TxtPrice.TabIndex = 12;

            TxtMax.Location = new Point(70, 260);
            TxtMax.Name = "TxtMax";
            TxtMax.Size = new Size(70, 23);
            TxtMax.TabIndex = 13;

            TxtMin.Location = new Point(200, 260);
            TxtMin.Name = "TxtMin";
            TxtMin.Size = new Size(70, 23);
            TxtMin.TabIndex = 14;

            TxtCompanyOrMachine.Location = new Point(146, 300);
            TxtCompanyOrMachine.Name = "TxtCompanyOrMachine";
            TxtCompanyOrMachine.Size = new Size(150, 23);
            TxtCompanyOrMachine.TabIndex = 15;

            // Buttons
            BtnSave.Location = new Point(70, 350);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 30);
            BtnSave.TabIndex = 16;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;

            BtnCancel.Location = new Point(180, 350);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 30);
            BtnCancel.TabIndex = 17;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;

            // Form settings
            ClientSize = new Size(350, 400);
            Controls.Add(LblFormTitle);
            Controls.Add(RdoInHouse);
            Controls.Add(RdoOutsourced);
            Controls.Add(LblID);
            Controls.Add(LblName);
            Controls.Add(LblInventory);
            Controls.Add(LblPrice);
            Controls.Add(LblMin);
            Controls.Add(LblMax);
            Controls.Add(LblCompanyOrMachine);
            Controls.Add(TxtID);
            Controls.Add(TxtName);
            Controls.Add(TxtInventory);
            Controls.Add(TxtPrice);
            Controls.Add(TxtMax);
            Controls.Add(TxtMin);
            Controls.Add(TxtCompanyOrMachine);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Modify_Part";
            Text = "Modify Part";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RdoInHouse;
        private RadioButton RdoOutsourced;
        private Label LblID;
        private Label LblName;
        private Label LblInventory;
        private Label LblPrice;
        private Label LblMin;
        private Label LblMax;
        private Label LblCompanyOrMachine;
        private TextBox TxtID;
        private TextBox TxtName;
        private TextBox TxtInventory;
        private TextBox TxtPrice;
        private TextBox TxtMax;
        private TextBox TxtMin;
        private TextBox TxtCompanyOrMachine;
        private Button BtnSave;
        private Button BtnCancel;
        private Label LblFormTitle;
    }
}