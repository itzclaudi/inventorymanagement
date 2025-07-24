
namespace C968
{
    partial class MainForm
    {   
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PartsSearchBtn = new Button();
            AppTitle = new Label();
            PartsLabel = new Label();
            ProductsLabel = new Label();
            ProductsSearchBtn = new Button();
            PartsSearchbar = new TextBox();
            ProductsSearchbar = new TextBox();
            dgvMainParts = new DataGridView();
            dgvMainProducts = new DataGridView();
            PartAddBtn = new Button();
            PartModifyBtn = new Button();
            PartDeleteBtn = new Button();
            ProductDeleteBtn = new Button();
            ProductModifyBtn = new Button();
            ProductAddBtn = new Button();
            ExitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMainParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMainProducts).BeginInit();
            SuspendLayout();
            // 
            // PartsSearchBtn
            // 
            PartsSearchBtn.Location = new Point(479, 89);
            PartsSearchBtn.Name = "PartsSearchBtn";
            PartsSearchBtn.Size = new Size(52, 23);
            PartsSearchBtn.TabIndex = 0;
            PartsSearchBtn.Text = "Search";
            PartsSearchBtn.UseVisualStyleBackColor = true;
            PartsSearchBtn.Click += PartsSearchBtn_Click;
            // 
            // AppTitle
            // 
            AppTitle.AutoSize = true;
            AppTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AppTitle.Location = new Point(12, 9);
            AppTitle.Name = "AppTitle";
            AppTitle.Size = new Size(291, 25);
            AppTitle.TabIndex = 1;
            AppTitle.Text = "Inventory Management System";
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Font = new Font("Segoe UI", 12F);
            PartsLabel.Location = new Point(15, 89);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(44, 21);
            PartsLabel.TabIndex = 2;
            PartsLabel.Text = "Parts";
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Font = new Font("Segoe UI", 12F);
            ProductsLabel.Location = new Point(707, 89);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(71, 21);
            ProductsLabel.TabIndex = 3;
            ProductsLabel.Text = "Products";
            // 
            // ProductsSearchBtn
            // 
            ProductsSearchBtn.Location = new Point(1149, 87);
            ProductsSearchBtn.Name = "ProductsSearchBtn";
            ProductsSearchBtn.Size = new Size(52, 23);
            ProductsSearchBtn.TabIndex = 4;
            ProductsSearchBtn.Text = "Search";
            ProductsSearchBtn.UseVisualStyleBackColor = true;
            ProductsSearchBtn.Click += ProductsSearchBtn_Click;
            // 
            // PartsSearchbar
            // 
            PartsSearchbar.Location = new Point(537, 87);
            PartsSearchbar.Name = "PartsSearchbar";
            PartsSearchbar.Size = new Size(140, 23);
            PartsSearchbar.TabIndex = 5;
            PartsSearchbar.TextChanged += PartsSearchbar_TextChanged;
            // 
            // ProductsSearchbar
            // 
            ProductsSearchbar.Location = new Point(1207, 87);
            ProductsSearchbar.Name = "ProductsSearchbar";
            ProductsSearchbar.Size = new Size(143, 23);
            ProductsSearchbar.TabIndex = 6;
            ProductsSearchbar.TextChanged += ProductsSearchbar_TextChanged_1;
            // 
            // dgvMainParts
            // 
            dgvMainParts.AllowUserToAddRows = false;
            dgvMainParts.AllowUserToDeleteRows = false;
            dgvMainParts.Location = new Point(15, 136);
            dgvMainParts.MultiSelect = false;
            dgvMainParts.Name = "dgvMainParts";
            dgvMainParts.ReadOnly = true;
            dgvMainParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMainParts.Size = new Size(662, 199);
            dgvMainParts.TabIndex = 8;
            dgvMainParts.CellContentClick += dgvMainParts_CellContentClick;
            // 
            // dgvMainProducts
            // 
            dgvMainProducts.AllowUserToAddRows = false;
            dgvMainProducts.AllowUserToDeleteRows = false;
            dgvMainProducts.Location = new Point(707, 136);
            dgvMainProducts.MultiSelect = false;
            dgvMainProducts.Name = "dgvMainProducts";
            dgvMainProducts.ReadOnly = true;
            dgvMainProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMainProducts.Size = new Size(643, 199);
            dgvMainProducts.TabIndex = 9;
            dgvMainProducts.CellContentClick += dgvMainProducts_CellContentClick;
            // 
            // PartAddBtn
            // 
            PartAddBtn.Location = new Point(440, 341);
            PartAddBtn.Name = "PartAddBtn";
            PartAddBtn.Size = new Size(75, 23);
            PartAddBtn.TabIndex = 10;
            PartAddBtn.Text = "Add";
            PartAddBtn.UseVisualStyleBackColor = true;
            PartAddBtn.Click += PartAddBtn_Click;
            // 
            // PartModifyBtn
            // 
            PartModifyBtn.Location = new Point(521, 341);
            PartModifyBtn.Name = "PartModifyBtn";
            PartModifyBtn.Size = new Size(75, 23);
            PartModifyBtn.TabIndex = 11;
            PartModifyBtn.Text = "Modify";
            PartModifyBtn.UseVisualStyleBackColor = true;
            PartModifyBtn.Click += PartModifyBtn_Click;
            // 
            // PartDeleteBtn
            // 
            PartDeleteBtn.Location = new Point(602, 341);
            PartDeleteBtn.Name = "PartDeleteBtn";
            PartDeleteBtn.Size = new Size(75, 23);
            PartDeleteBtn.TabIndex = 12;
            PartDeleteBtn.Text = "Delete";
            PartDeleteBtn.UseVisualStyleBackColor = true;
            PartDeleteBtn.Click += PartDeleteBtn_Click;
            // 
            // ProductDeleteBtn
            // 
            ProductDeleteBtn.Location = new Point(1276, 341);
            ProductDeleteBtn.Name = "ProductDeleteBtn";
            ProductDeleteBtn.Size = new Size(75, 23);
            ProductDeleteBtn.TabIndex = 15;
            ProductDeleteBtn.Text = "Delete";
            ProductDeleteBtn.UseVisualStyleBackColor = true;
            ProductDeleteBtn.Click += ProductDeleteBtn_Click;
            // 
            // ProductModifyBtn
            // 
            ProductModifyBtn.Location = new Point(1195, 341);
            ProductModifyBtn.Name = "ProductModifyBtn";
            ProductModifyBtn.Size = new Size(75, 23);
            ProductModifyBtn.TabIndex = 14;
            ProductModifyBtn.Text = "Modify";
            ProductModifyBtn.UseVisualStyleBackColor = true;
            ProductModifyBtn.Click += ProductModifyBtn_Click;
            // 
            // ProductAddBtn
            // 
            ProductAddBtn.Location = new Point(1114, 341);
            ProductAddBtn.Name = "ProductAddBtn";
            ProductAddBtn.Size = new Size(75, 23);
            ProductAddBtn.TabIndex = 13;
            ProductAddBtn.Text = "Add";
            ProductAddBtn.UseVisualStyleBackColor = true;
            ProductAddBtn.Click += ProductAddBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(1276, 390);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 41);
            ExitBtn.TabIndex = 16;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 437);
            Controls.Add(ExitBtn);
            Controls.Add(ProductDeleteBtn);
            Controls.Add(ProductModifyBtn);
            Controls.Add(ProductAddBtn);
            Controls.Add(PartDeleteBtn);
            Controls.Add(PartModifyBtn);
            Controls.Add(PartAddBtn);
            Controls.Add(dgvMainProducts);
            Controls.Add(dgvMainParts);
            Controls.Add(ProductsSearchbar);
            Controls.Add(PartsSearchbar);
            Controls.Add(ProductsSearchBtn);
            Controls.Add(ProductsLabel);
            Controls.Add(PartsLabel);
            Controls.Add(AppTitle);
            Controls.Add(PartsSearchBtn);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMainParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMainProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PartsSearchBtn;
        private Label AppTitle;
        private Label PartsLabel;
        private Label ProductsLabel;
        private Button ProductsSearchBtn;
        private TextBox PartsSearchbar;
        private TextBox ProductsSearchbar;
        private DataGridView dgvMainParts;
        private DataGridView dgvMainProducts;
        private Button PartAddBtn;
        private Button PartModifyBtn;
        private Button PartDeleteBtn;
        private Button ProductDeleteBtn;
        private Button ProductModifyBtn;
        private Button ProductAddBtn;
        private Button ExitBtn;
    }
}
