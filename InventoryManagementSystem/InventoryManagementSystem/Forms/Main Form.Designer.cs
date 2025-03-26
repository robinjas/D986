namespace Inventory_Management_System.Forms
{
    partial class Main_Form
    {
        private System.ComponentModel.IContainer components = null;
        private ToolTip ToolTip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                ToolTip?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            ToolTip = new ToolTip(components);
            BtnExit = new Button();
            LblTitle = new Label();
            BtnSearchPart = new Button();
            BtnSearchProduct = new Button();
            BtnAddPart = new Button();
            LblProducts = new Label();
            LblParts = new Label();
            BtnAddProduct = new Button();
            BtnModifyPart = new Button();
            BtnModifyProduct = new Button();
            BtnDeletePart = new Button();
            BtnDeleteProduct = new Button();
            GroupBoxParts = new GroupBox();
            DgvParts = new DataGridView();
            TxtSearchParts = new TextBox();
            GroupBoxProducts = new GroupBox();
            DgvProducts = new DataGridView();
            TxtSearchProducts = new TextBox();
            GroupBoxParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvParts).BeginInit();
            GroupBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProducts).BeginInit();
            SuspendLayout();
            // 
            // BtnExit
            // 
            BtnExit.Font = new Font("Segoe UI", 9F);
            BtnExit.Location = new Point(928, 360);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 1;
            BtnExit.Text = "Exit";
            ToolTip.SetToolTip(BtnExit, "Exit the application");
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LblTitle.Location = new Point(12, 9);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(291, 25);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Inventory Management System";
            // 
            // BtnSearchPart
            // 
            BtnSearchPart.Font = new Font("Segoe UI", 9F);
            BtnSearchPart.Location = new Point(203, 22);
            BtnSearchPart.Name = "BtnSearchPart";
            BtnSearchPart.Size = new Size(75, 23);
            BtnSearchPart.TabIndex = 5;
            BtnSearchPart.Text = "Search";
            BtnSearchPart.UseVisualStyleBackColor = true;
            BtnSearchPart.Click += BtnSearchPart_Click;
            // 
            // BtnSearchProduct
            // 
            BtnSearchProduct.Font = new Font("Segoe UI", 9F);
            BtnSearchProduct.Location = new Point(224, 20);
            BtnSearchProduct.Name = "BtnSearchProduct";
            BtnSearchProduct.Size = new Size(75, 23);
            BtnSearchProduct.TabIndex = 5;
            BtnSearchProduct.Text = "Search";
            BtnSearchProduct.UseVisualStyleBackColor = true;
            BtnSearchProduct.Click += BtnSearchProduct_Click;
            // 
            // BtnAddPart
            // 
            BtnAddPart.Font = new Font("Segoe UI", 9F);
            BtnAddPart.Location = new Point(216, 255);
            BtnAddPart.Name = "BtnAddPart";
            BtnAddPart.Size = new Size(75, 23);
            BtnAddPart.TabIndex = 4;
            BtnAddPart.Text = "Add";
            BtnAddPart.UseVisualStyleBackColor = true;
            BtnAddPart.Click += BtnAddPart_Click;
            // 
            // LblProducts
            // 
            LblProducts.AutoSize = true;
            LblProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblProducts.Location = new Point(8, 22);
            LblProducts.Name = "LblProducts";
            LblProducts.Size = new Size(77, 21);
            LblProducts.TabIndex = 0;
            LblProducts.Text = "Products";
            // 
            // LblParts
            // 
            LblParts.AutoSize = true;
            LblParts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblParts.Location = new Point(0, 24);
            LblParts.Name = "LblParts";
            LblParts.Size = new Size(48, 21);
            LblParts.TabIndex = 0;
            LblParts.Text = "Parts";
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Font = new Font("Segoe UI", 9F);
            BtnAddProduct.Location = new Point(238, 255);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(75, 23);
            BtnAddProduct.TabIndex = 4;
            BtnAddProduct.Text = "Add";
            BtnAddProduct.UseVisualStyleBackColor = true;
            BtnAddProduct.Click += BtnAddProduct_Click;
            // 
            // BtnModifyPart
            // 
            BtnModifyPart.Font = new Font("Segoe UI", 9F);
            BtnModifyPart.Location = new Point(302, 255);
            BtnModifyPart.Name = "BtnModifyPart";
            BtnModifyPart.Size = new Size(75, 23);
            BtnModifyPart.TabIndex = 3;
            BtnModifyPart.Text = "Modify";
            BtnModifyPart.UseVisualStyleBackColor = true;
            BtnModifyPart.Click += BtnModifyPart_Click;
            // 
            // BtnModifyProduct
            // 
            BtnModifyProduct.Font = new Font("Segoe UI", 9F);
            BtnModifyProduct.Location = new Point(319, 255);
            BtnModifyProduct.Name = "BtnModifyProduct";
            BtnModifyProduct.Size = new Size(75, 23);
            BtnModifyProduct.TabIndex = 3;
            BtnModifyProduct.Text = "Modify";
            BtnModifyProduct.UseVisualStyleBackColor = true;
            BtnModifyProduct.Click += BtnModifyProduct_Click;
            // 
            // BtnDeletePart
            // 
            BtnDeletePart.Font = new Font("Segoe UI", 9F);
            BtnDeletePart.Location = new Point(392, 255);
            BtnDeletePart.Name = "BtnDeletePart";
            BtnDeletePart.Size = new Size(75, 23);
            BtnDeletePart.TabIndex = 1;
            BtnDeletePart.Text = "Delete";
            BtnDeletePart.UseVisualStyleBackColor = true;
            BtnDeletePart.Click += BtnDeletePart_Click;
            // 
            // BtnDeleteProduct
            // 
            BtnDeleteProduct.Font = new Font("Segoe UI", 9F);
            BtnDeleteProduct.Location = new Point(400, 255);
            BtnDeleteProduct.Name = "BtnDeleteProduct";
            BtnDeleteProduct.Size = new Size(75, 23);
            BtnDeleteProduct.TabIndex = 1;
            BtnDeleteProduct.Text = "Delete";
            BtnDeleteProduct.UseVisualStyleBackColor = true;
            BtnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // GroupBoxParts
            // 
            GroupBoxParts.AutoSize = true;
            GroupBoxParts.Controls.Add(LblParts);
            GroupBoxParts.Controls.Add(BtnDeletePart);
            GroupBoxParts.Controls.Add(DgvParts);
            GroupBoxParts.Controls.Add(BtnModifyPart);
            GroupBoxParts.Controls.Add(BtnAddPart);
            GroupBoxParts.Controls.Add(BtnSearchPart);
            GroupBoxParts.Controls.Add(TxtSearchParts);
            GroupBoxParts.Location = new Point(12, 45);
            GroupBoxParts.Name = "GroupBoxParts";
            GroupBoxParts.Size = new Size(473, 300);
            GroupBoxParts.TabIndex = 0;
            GroupBoxParts.TabStop = false;
            // 
            // DgvParts
            // 
            // DgvParts
            DgvParts.AllowUserToAddRows = false;
            DgvParts.AllowUserToDeleteRows = false;
            DgvParts.AllowUserToResizeColumns = false;
            DgvParts.AllowUserToResizeRows = false;
            DgvParts.BorderStyle = BorderStyle.None;
            DgvParts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvParts.RowTemplate.Height = 22;
            DgvParts.RowTemplate.Resizable = DataGridViewTriState.False;
            DgvParts.RowTemplate.DefaultCellStyle.Padding = new Padding(0);
            DgvParts.ColumnHeadersHeight = 28;
            DgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            DgvParts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvParts.DefaultCellStyle = dataGridViewCellStyle3;

            DgvParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            DgvParts.Location = new Point(0, 58);
            DgvParts.MultiSelect = false;
            DgvParts.Name = "DgvParts";
            DgvParts.RowHeadersVisible = false;
            DgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvParts.Size = new Size(467, 171);
            DgvParts.TabIndex = 2;

            // 
            // TxtSearchParts
            // 
            TxtSearchParts.Location = new Point(311, 22);
            TxtSearchParts.Name = "TxtSearchParts";
            TxtSearchParts.Size = new Size(156, 23);
            TxtSearchParts.TabIndex = 6;
            // 
            // GroupBoxProducts
            // 
            GroupBoxProducts.AutoSize = true;
            GroupBoxProducts.Controls.Add(LblProducts);
            GroupBoxProducts.Controls.Add(BtnDeleteProduct);
            GroupBoxProducts.Controls.Add(DgvProducts);
            GroupBoxProducts.Controls.Add(BtnModifyProduct);
            GroupBoxProducts.Controls.Add(BtnAddProduct);
            GroupBoxProducts.Controls.Add(BtnSearchProduct);
            GroupBoxProducts.Controls.Add(TxtSearchProducts);
            GroupBoxProducts.Location = new Point(516, 45);
            GroupBoxProducts.Name = "GroupBoxProducts";
            GroupBoxProducts.Size = new Size(487, 300);
            GroupBoxProducts.TabIndex = 1;
            GroupBoxProducts.TabStop = false;
            // 
            // DgvProducts
            // 
            // DgvProducts
            // DgvProducts
            // DgvProducts
            DgvProducts.AllowUserToAddRows = false;
            DgvProducts.AllowUserToDeleteRows = false;
            DgvProducts.AllowUserToResizeColumns = false;
            DgvProducts.AllowUserToResizeRows = false;
            DgvProducts.BorderStyle = BorderStyle.None;
            DgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProducts.RowTemplate.Height = 22;
            DgvProducts.RowTemplate.Resizable = DataGridViewTriState.False;
            DgvProducts.RowTemplate.DefaultCellStyle.Padding = new Padding(0);
            DgvProducts.ColumnHeadersHeight = 28;
            DgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            DgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;

            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;

            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvProducts.DefaultCellStyle = dataGridViewCellStyle6;

            DgvProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            DgvProducts.Location = new Point(8, 58);
            DgvProducts.MultiSelect = false;
            DgvProducts.Name = "DgvProducts";
            DgvProducts.RowHeadersVisible = false;
            DgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProducts.Size = new Size(467, 171);
            DgvProducts.TabIndex = 2;
            ;


            // 
            // TxtSearchProducts
            // 
            TxtSearchProducts.Location = new Point(319, 22);
            TxtSearchProducts.Name = "TxtSearchProducts";
            TxtSearchProducts.Size = new Size(156, 23);
            TxtSearchProducts.TabIndex = 6;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 400);
            Controls.Add(LblTitle);
            Controls.Add(BtnExit);
            Controls.Add(GroupBoxParts);
            Controls.Add(GroupBoxProducts);
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = SystemColors.ControlLightLight;
            Load += Main_Form_Load;
            GroupBoxParts.ResumeLayout(false);
            GroupBoxParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvParts).EndInit();
            GroupBoxProducts.ResumeLayout(false);
            GroupBoxProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitle;
        private Button BtnSearchPart;
        private Button BtnSearchProduct;
        private Button BtnAddPart;
        private Label LblProducts;
        private Label LblParts;
        private Button BtnAddProduct;
        private Button BtnModifyPart;
        private Button BtnModifyProduct;
        private Button BtnDeletePart;
        private Button BtnDeleteProduct;
        private GroupBox GroupBoxParts;
        private GroupBox GroupBoxProducts;
        private TextBox TxtSearchParts;
        private TextBox TxtSearchProducts;
        private DataGridView DgvParts;
        private DataGridView DgvProducts;
        private Button BtnExit;
    }
}
