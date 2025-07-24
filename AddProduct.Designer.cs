namespace C968
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancelbtn = new Button();
            savebtn = new Button();
            minTbox = new TextBox();
            maxTbox = new TextBox();
            priceTbox = new TextBox();
            inventoryTbox = new TextBox();
            nameTbox = new TextBox();
            idTbox = new TextBox();
            addproductmin = new Label();
            addproductmax = new Label();
            addproductprice = new Label();
            addproductinventory = new Label();
            addproductname = new Label();
            addproductid = new Label();
            AddProductAppTitle = new Label();
            allcandidatepartslabel = new Label();
            partsassociatedlabel = new Label();
            ProductAddBtn = new Button();
            ProductDeleteBtn = new Button();
            dgvallcandidateparts = new DataGridView();
            partsassocaitedgrid = new DataGridView();
            AddpartsSearchbar = new TextBox();
            AddpartsSearchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvallcandidateparts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partsassocaitedgrid).BeginInit();
            SuspendLayout();
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(1044, 594);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(75, 23);
            cancelbtn.TabIndex = 39;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(963, 594);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 23);
            savebtn.TabIndex = 38;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // minTbox
            // 
            minTbox.Location = new Point(288, 342);
            minTbox.Name = "minTbox";
            minTbox.Size = new Size(100, 23);
            minTbox.TabIndex = 36;
            // 
            // maxTbox
            // 
            maxTbox.Location = new Point(125, 342);
            maxTbox.Name = "maxTbox";
            maxTbox.Size = new Size(100, 23);
            maxTbox.TabIndex = 35;
            // 
            // priceTbox
            // 
            priceTbox.Location = new Point(173, 290);
            priceTbox.Name = "priceTbox";
            priceTbox.Size = new Size(134, 23);
            priceTbox.TabIndex = 34;
            // 
            // inventoryTbox
            // 
            inventoryTbox.Location = new Point(173, 242);
            inventoryTbox.Name = "inventoryTbox";
            inventoryTbox.Size = new Size(134, 23);
            inventoryTbox.TabIndex = 33;
            // 
            // nameTbox
            // 
            nameTbox.Location = new Point(173, 191);
            nameTbox.Name = "nameTbox";
            nameTbox.Size = new Size(134, 23);
            nameTbox.TabIndex = 32;
            // 
            // idTbox
            // 
            idTbox.Location = new Point(173, 149);
            idTbox.Name = "idTbox";
            idTbox.ReadOnly = true;
            idTbox.Size = new Size(134, 23);
            idTbox.TabIndex = 31;
            // 
            // addproductmin
            // 
            addproductmin.AutoSize = true;
            addproductmin.Location = new Point(254, 342);
            addproductmin.Name = "addproductmin";
            addproductmin.Size = new Size(28, 15);
            addproductmin.TabIndex = 29;
            addproductmin.Text = "Min";
            // 
            // addproductmax
            // 
            addproductmax.AutoSize = true;
            addproductmax.Location = new Point(79, 339);
            addproductmax.Name = "addproductmax";
            addproductmax.Size = new Size(29, 15);
            addproductmax.TabIndex = 28;
            addproductmax.Text = "Max";
            // 
            // addproductprice
            // 
            addproductprice.AutoSize = true;
            addproductprice.Location = new Point(75, 290);
            addproductprice.Name = "addproductprice";
            addproductprice.Size = new Size(33, 15);
            addproductprice.TabIndex = 27;
            addproductprice.Text = "Price";
            // 
            // addproductinventory
            // 
            addproductinventory.AutoSize = true;
            addproductinventory.Location = new Point(51, 242);
            addproductinventory.Name = "addproductinventory";
            addproductinventory.Size = new Size(57, 15);
            addproductinventory.TabIndex = 26;
            addproductinventory.Text = "Inventory";
            // 
            // addproductname
            // 
            addproductname.AutoSize = true;
            addproductname.Location = new Point(69, 191);
            addproductname.Name = "addproductname";
            addproductname.Size = new Size(39, 15);
            addproductname.TabIndex = 25;
            addproductname.Text = "Name";
            // 
            // addproductid
            // 
            addproductid.AutoSize = true;
            addproductid.Location = new Point(90, 149);
            addproductid.Name = "addproductid";
            addproductid.Size = new Size(18, 15);
            addproductid.TabIndex = 24;
            addproductid.Text = "ID";
            // 
            // AddProductAppTitle
            // 
            AddProductAppTitle.AutoSize = true;
            AddProductAppTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AddProductAppTitle.Location = new Point(12, 9);
            AddProductAppTitle.Name = "AddProductAppTitle";
            AddProductAppTitle.Size = new Size(126, 25);
            AddProductAppTitle.TabIndex = 21;
            AddProductAppTitle.Text = "Add Product";
            // 
            // allcandidatepartslabel
            // 
            allcandidatepartslabel.AutoSize = true;
            allcandidatepartslabel.Location = new Point(454, 22);
            allcandidatepartslabel.Name = "allcandidatepartslabel";
            allcandidatepartslabel.Size = new Size(105, 15);
            allcandidatepartslabel.TabIndex = 40;
            allcandidatepartslabel.Text = "All candidate Parts";
            // 
            // partsassociatedlabel
            // 
            partsassociatedlabel.AutoSize = true;
            partsassociatedlabel.Location = new Point(454, 312);
            partsassociatedlabel.Name = "partsassociatedlabel";
            partsassociatedlabel.Size = new Size(186, 15);
            partsassociatedlabel.TabIndex = 41;
            partsassociatedlabel.Text = "Parts Associated with this Product";
            // 
            // ProductAddBtn
            // 
            ProductAddBtn.Location = new Point(1044, 268);
            ProductAddBtn.Name = "ProductAddBtn";
            ProductAddBtn.Size = new Size(75, 23);
            ProductAddBtn.TabIndex = 42;
            ProductAddBtn.Text = "Add";
            ProductAddBtn.UseVisualStyleBackColor = true;
            ProductAddBtn.Click += ProductAddBtn_Click;
            // 
            // ProductDeleteBtn
            // 
            ProductDeleteBtn.Location = new Point(1044, 554);
            ProductDeleteBtn.Name = "ProductDeleteBtn";
            ProductDeleteBtn.Size = new Size(75, 23);
            ProductDeleteBtn.TabIndex = 43;
            ProductDeleteBtn.Text = "Delete";
            ProductDeleteBtn.UseVisualStyleBackColor = true;
            ProductDeleteBtn.Click += ProductDeleteBtn_Click;
            // 
            // dgvallcandidateparts
            // 
            dgvallcandidateparts.AllowUserToAddRows = false;
            dgvallcandidateparts.AllowUserToDeleteRows = false;
            dgvallcandidateparts.Location = new Point(454, 40);
            dgvallcandidateparts.MultiSelect = false;
            dgvallcandidateparts.Name = "dgvallcandidateparts";
            dgvallcandidateparts.ReadOnly = true;
            dgvallcandidateparts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvallcandidateparts.Size = new Size(665, 225);
            dgvallcandidateparts.TabIndex = 44;
            dgvallcandidateparts.CellContentClick += dgvallcandidateparts_CellContentClick;
            // 
            // partsassocaitedgrid
            // 
            partsassocaitedgrid.AllowUserToAddRows = false;
            partsassocaitedgrid.AllowUserToDeleteRows = false;
            partsassocaitedgrid.Location = new Point(454, 330);
            partsassocaitedgrid.MultiSelect = false;
            partsassocaitedgrid.Name = "partsassocaitedgrid";
            partsassocaitedgrid.ReadOnly = true;
            partsassocaitedgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsassocaitedgrid.Size = new Size(665, 218);
            partsassocaitedgrid.TabIndex = 45;
            // 
            // AddpartsSearchbar
            // 
            AddpartsSearchbar.Location = new Point(892, 9);
            AddpartsSearchbar.Name = "AddpartsSearchbar";
            AddpartsSearchbar.Size = new Size(227, 23);
            AddpartsSearchbar.TabIndex = 47;
            // 
            // AddpartsSearchBtn
            // 
            AddpartsSearchBtn.Location = new Point(834, 9);
            AddpartsSearchBtn.Name = "AddpartsSearchBtn";
            AddpartsSearchBtn.Size = new Size(52, 23);
            AddpartsSearchBtn.TabIndex = 46;
            AddpartsSearchBtn.Text = "Search";
            AddpartsSearchBtn.UseVisualStyleBackColor = true;
            AddpartsSearchBtn.Click += PartsSearchBtn_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 622);
            Controls.Add(AddpartsSearchbar);
            Controls.Add(AddpartsSearchBtn);
            Controls.Add(partsassocaitedgrid);
            Controls.Add(dgvallcandidateparts);
            Controls.Add(ProductDeleteBtn);
            Controls.Add(ProductAddBtn);
            Controls.Add(partsassociatedlabel);
            Controls.Add(allcandidatepartslabel);
            Controls.Add(cancelbtn);
            Controls.Add(savebtn);
            Controls.Add(minTbox);
            Controls.Add(maxTbox);
            Controls.Add(priceTbox);
            Controls.Add(inventoryTbox);
            Controls.Add(nameTbox);
            Controls.Add(idTbox);
            Controls.Add(addproductmin);
            Controls.Add(addproductmax);
            Controls.Add(addproductprice);
            Controls.Add(addproductinventory);
            Controls.Add(addproductname);
            Controls.Add(addproductid);
            Controls.Add(AddProductAppTitle);
            Name = "AddProduct";
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)dgvallcandidateparts).EndInit();
            ((System.ComponentModel.ISupportInitialize)partsassocaitedgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelbtn;
        private Button savebtn;
        private TextBox minTbox;
        private TextBox maxTbox;
        private TextBox priceTbox;
        private TextBox inventoryTbox;
        private TextBox nameTbox;
        private TextBox idTbox;
        private Label addproductmin;
        private Label addproductmax;
        private Label addproductprice;
        private Label addproductinventory;
        private Label addproductname;
        private Label addproductid;
        private Label AddProductAppTitle;
        private Label allcandidatepartslabel;
        private Label partsassociatedlabel;
        private Button ProductAddBtn;
        private Button ProductDeleteBtn;
        private DataGridView dgvallcandidateparts;
        private DataGridView partsassocaitedgrid;
        private TextBox AddpartsSearchbar;
        private Button AddpartsSearchBtn;
    }
}