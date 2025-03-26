namespace Inventory_Management_System.Forms
{
    partial class Modify_Product
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
            LblID = new Label();
            LblName = new Label();
            LblInventory = new Label();
            LblPrice = new Label();
            LblMin = new Label();
            LblMax = new Label();
            TxtID = new TextBox();
            TxtName = new TextBox();
            TxtInventory = new TextBox();
            TxtPrice = new TextBox();
            TxtMax = new TextBox();
            TxtMin = new TextBox();
            TxtSearch = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            LblFormTitle = new Label();
            DvgAllParts = new DataGridView();
            DvgAssociatedParts = new DataGridView();
            BtnAdd = new Button();
            BtnDeletePart = new Button();
            LblAllParts = new Label();
            LblAssociatedParts = new Label();
            BtnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)DvgAllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DvgAssociatedParts).BeginInit();
            SuspendLayout();
            // 
            // LblID
            // 
            LblID.AutoSize = true;
            LblID.Location = new Point(30, 70);
            LblID.Name = "LblID";
            LblID.Size = new Size(21, 15);
            LblID.TabIndex = 1;
            LblID.Text = "ID";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(30, 110);
            LblName.Name = "LblName";
            LblName.Size = new Size(42, 15);
            LblName.TabIndex = 3;
            LblName.Text = "Name";
            // 
            // LblInventory
            // 
            LblInventory.AutoSize = true;
            LblInventory.Location = new Point(30, 150);
            LblInventory.Name = "LblInventory";
            LblInventory.Size = new Size(60, 15);
            LblInventory.TabIndex = 5;
            LblInventory.Text = "Inventory";
            // 
            // LblPrice
            // 
            LblPrice.AutoSize = true;
            LblPrice.Location = new Point(30, 190);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(71, 15);
            LblPrice.TabIndex = 7;
            LblPrice.Text = "Price / Cost";
            // 
            // LblMin
            // 
            LblMin.AutoSize = true;
            LblMin.Location = new Point(160, 230);
            LblMin.Name = "LblMin";
            LblMin.Size = new Size(31, 15);
            LblMin.TabIndex = 11;
            LblMin.Text = "Min";
            // 
            // LblMax
            // 
            LblMax.AutoSize = true;
            LblMax.Location = new Point(30, 230);
            LblMax.Name = "LblMax";
            LblMax.Size = new Size(33, 15);
            LblMax.TabIndex = 9;
            LblMax.Text = "Max";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(130, 70);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(150, 23);
            TxtID.TabIndex = 2;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(130, 110);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 23);
            TxtName.TabIndex = 4;
            // 
            // TxtInventory
            // 
            TxtInventory.Location = new Point(130, 150);
            TxtInventory.Name = "TxtInventory";
            TxtInventory.Size = new Size(150, 23);
            TxtInventory.TabIndex = 6;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(130, 190);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(150, 23);
            TxtPrice.TabIndex = 8;
            // 
            // TxtMax
            // 
            TxtMax.Location = new Point(70, 230);
            TxtMax.Name = "TxtMax";
            TxtMax.Size = new Size(70, 23);
            TxtMax.TabIndex = 10;
            // 
            // TxtMin
            // 
            TxtMin.Location = new Point(200, 230);
            TxtMin.Name = "TxtMin";
            TxtMin.Size = new Size(70, 23);
            TxtMin.TabIndex = 12;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(800, 20);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(200, 23);
            TxtSearch.TabIndex = 16;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(831, 505);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 30);
            BtnSave.TabIndex = 13;
            BtnSave.Text = "Save";
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(925, 505);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 30);
            BtnCancel.TabIndex = 14;
            BtnCancel.Text = "Cancel";
            BtnCancel.Click += BtnCancel_Click;
            // 
            // LblFormTitle
            // 
            LblFormTitle.AutoSize = true;
            LblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblFormTitle.Location = new Point(20, 20);
            LblFormTitle.Name = "LblFormTitle";
            LblFormTitle.Size = new Size(129, 21);
            LblFormTitle.TabIndex = 0;
            LblFormTitle.Text = "Modify Product";
            // 
            // DvgAllParts
            // 
            DvgAllParts.Location = new Point(460, 80);
            DvgAllParts.Name = "DvgAllParts";
            DvgAllParts.Size = new Size(540, 150);
            DvgAllParts.TabIndex = 18;
            // 
            // DvgAssociatedParts
            // 
            DvgAssociatedParts.Location = new Point(460, 290);
            DvgAssociatedParts.Name = "DvgAssociatedParts";
            DvgAssociatedParts.Size = new Size(540, 150);
            DvgAssociatedParts.TabIndex = 21;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(925, 240);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 19;
            BtnAdd.Text = "Add";
            // 
            // BtnDeletePart
            // 
            BtnDeletePart.Location = new Point(925, 450);
            BtnDeletePart.Name = "BtnDeletePart";
            BtnDeletePart.Size = new Size(75, 23);
            BtnDeletePart.TabIndex = 22;
            BtnDeletePart.Text = "Delete";
            // 
            // LblAllParts
            // 
            LblAllParts.AutoSize = true;
            LblAllParts.Location = new Point(460, 60);
            LblAllParts.Name = "LblAllParts";
            LblAllParts.Size = new Size(50, 15);
            LblAllParts.TabIndex = 17;
            LblAllParts.Text = "All Parts";
            // 
            // LblAssociatedParts
            // 
            LblAssociatedParts.AutoSize = true;
            LblAssociatedParts.Location = new Point(460, 270);
            LblAssociatedParts.Name = "LblAssociatedParts";
            LblAssociatedParts.Size = new Size(186, 15);
            LblAssociatedParts.TabIndex = 20;
            LblAssociatedParts.Text = "Parts Associated with this Product";
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(710, 20);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 15;
            BtnSearch.Text = "Search";
            BtnSearch.Click += BtnSearch_Click;
            // 
            // Modify_Product
            // 
            ClientSize = new Size(1028, 562);
            Controls.Add(LblFormTitle);
            Controls.Add(LblID);
            Controls.Add(TxtID);
            Controls.Add(LblName);
            Controls.Add(TxtName);
            Controls.Add(LblInventory);
            Controls.Add(TxtInventory);
            Controls.Add(LblPrice);
            Controls.Add(TxtPrice);
            Controls.Add(LblMax);
            Controls.Add(TxtMax);
            Controls.Add(LblMin);
            Controls.Add(TxtMin);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSearch);
            Controls.Add(TxtSearch);
            Controls.Add(LblAllParts);
            Controls.Add(DvgAllParts);
            Controls.Add(BtnAdd);
            Controls.Add(LblAssociatedParts);
            Controls.Add(DvgAssociatedParts);
            Controls.Add(BtnDeletePart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Modify_Product";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)DvgAllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)DvgAssociatedParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblID;
        private Label LblName;
        private Label LblInventory;
        private Label LblPrice;
        private Label LblMin;
        private Label LblMax;
        private TextBox TxtID;
        private TextBox TxtName;
        private TextBox TxtInventory;
        private TextBox TxtPrice;
        private TextBox TxtMax;
        private TextBox TxtMin;
        private TextBox TxtSearch;
        private Button BtnSave;
        private Button BtnCancel;
        private Label LblFormTitle;
        private DataGridView DvgAllParts;
        private DataGridView DvgAssociatedParts;
        private Button BtnAdd;
        private Button BtnDeletePart;
        private Label LblAllParts;
        private Label LblAssociatedParts;
        private Button BtnSearch;
    }
}
