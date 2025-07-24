namespace C968
{
    partial class ModifyProduct
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
            modifyproductSearchbar = new TextBox();
            modifyproductSearchBtn = new Button();
            partsassocaitedgrid = new DataGridView();
            allcandidatepartsgrid = new DataGridView();
            ProductDeleteBtn = new Button();
            ProductAddBtn = new Button();
            partsassociatedlabel = new Label();
            allcandidatepartslabel = new Label();
            cancelbtn = new Button();
            savebtn = new Button();
            minTbox = new TextBox();
            maxTbox = new TextBox();
            priceTbox = new TextBox();
            inventoryTbox = new TextBox();
            nameTbox = new TextBox();
            idTbox = new TextBox();
            modifyproductmin = new Label();
            modifyproductmax = new Label();
            modifyproductprice = new Label();
            modifyproductinventory = new Label();
            modifyproductname = new Label();
            modifyproductid = new Label();
            ModifyProductAppTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)partsassocaitedgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allcandidatepartsgrid).BeginInit();
            SuspendLayout();
            // 
            // modifyproductSearchbar
            // 
            modifyproductSearchbar.Location = new Point(884, 11);
            modifyproductSearchbar.Name = "modifyproductSearchbar";
            modifyproductSearchbar.Size = new Size(227, 23);
            modifyproductSearchbar.TabIndex = 70;
            // 
            // modifyproductSearchBtn
            // 
            modifyproductSearchBtn.Location = new Point(826, 11);
            modifyproductSearchBtn.Name = "modifyproductSearchBtn";
            modifyproductSearchBtn.Size = new Size(52, 23);
            modifyproductSearchBtn.TabIndex = 69;
            modifyproductSearchBtn.Text = "Search";
            modifyproductSearchBtn.UseVisualStyleBackColor = true;
            modifyproductSearchBtn.Click += modifyproductSearchBtn_Click;
            // 
            // partsassocaitedgrid
            // 
            partsassocaitedgrid.AllowUserToAddRows = false;
            partsassocaitedgrid.AllowUserToDeleteRows = false;
            partsassocaitedgrid.Location = new Point(468, 332);
            partsassocaitedgrid.MultiSelect = false;
            partsassocaitedgrid.Name = "partsassocaitedgrid";
            partsassocaitedgrid.ReadOnly = true;
            partsassocaitedgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsassocaitedgrid.Size = new Size(643, 199);
            partsassocaitedgrid.TabIndex = 68;
            // 
            // allcandidatepartsgrid
            // 
            allcandidatepartsgrid.AllowUserToAddRows = false;
            allcandidatepartsgrid.AllowUserToDeleteRows = false;
            allcandidatepartsgrid.Location = new Point(468, 42);
            allcandidatepartsgrid.MultiSelect = false;
            allcandidatepartsgrid.Name = "allcandidatepartsgrid";
            allcandidatepartsgrid.ReadOnly = true;
            allcandidatepartsgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allcandidatepartsgrid.Size = new Size(643, 199);
            allcandidatepartsgrid.TabIndex = 67;
            // 
            // ProductDeleteBtn
            // 
            ProductDeleteBtn.Location = new Point(1036, 537);
            ProductDeleteBtn.Name = "ProductDeleteBtn";
            ProductDeleteBtn.Size = new Size(75, 23);
            ProductDeleteBtn.TabIndex = 66;
            ProductDeleteBtn.Text = "Delete";
            ProductDeleteBtn.UseVisualStyleBackColor = true;
            ProductDeleteBtn.Click += ProductDeleteBtn_Click;
            // 
            // ProductAddBtn
            // 
            ProductAddBtn.Location = new Point(1036, 247);
            ProductAddBtn.Name = "ProductAddBtn";
            ProductAddBtn.Size = new Size(75, 23);
            ProductAddBtn.TabIndex = 65;
            ProductAddBtn.Text = "Add";
            ProductAddBtn.UseVisualStyleBackColor = true;
            ProductAddBtn.Click += ProductAddBtn_Click;
            // 
            // partsassociatedlabel
            // 
            partsassociatedlabel.AutoSize = true;
            partsassociatedlabel.Location = new Point(468, 314);
            partsassociatedlabel.Name = "partsassociatedlabel";
            partsassociatedlabel.Size = new Size(186, 15);
            partsassociatedlabel.TabIndex = 64;
            partsassociatedlabel.Text = "Parts Associated with this Product";
            // 
            // allcandidatepartslabel
            // 
            allcandidatepartslabel.AutoSize = true;
            allcandidatepartslabel.Location = new Point(468, 24);
            allcandidatepartslabel.Name = "allcandidatepartslabel";
            allcandidatepartslabel.Size = new Size(105, 15);
            allcandidatepartslabel.TabIndex = 63;
            allcandidatepartslabel.Text = "All candidate Parts";
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(1036, 596);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(75, 23);
            cancelbtn.TabIndex = 62;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(955, 596);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 23);
            savebtn.TabIndex = 61;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // minTbox
            // 
            minTbox.Location = new Point(280, 344);
            minTbox.Name = "minTbox";
            minTbox.Size = new Size(100, 23);
            minTbox.TabIndex = 60;
            // 
            // maxTbox
            // 
            maxTbox.Location = new Point(117, 344);
            maxTbox.Name = "maxTbox";
            maxTbox.Size = new Size(100, 23);
            maxTbox.TabIndex = 59;
            // 
            // priceTbox
            // 
            priceTbox.Location = new Point(165, 292);
            priceTbox.Name = "priceTbox";
            priceTbox.Size = new Size(134, 23);
            priceTbox.TabIndex = 58;
            // 
            // inventoryTbox
            // 
            inventoryTbox.Location = new Point(165, 244);
            inventoryTbox.Name = "inventoryTbox";
            inventoryTbox.Size = new Size(134, 23);
            inventoryTbox.TabIndex = 57;
            // 
            // nameTbox
            // 
            nameTbox.Location = new Point(165, 193);
            nameTbox.Name = "nameTbox";
            nameTbox.Size = new Size(134, 23);
            nameTbox.TabIndex = 56;
            // 
            // idTbox
            // 
            idTbox.Location = new Point(165, 151);
            idTbox.Name = "idTbox";
            idTbox.ReadOnly = true;
            idTbox.Size = new Size(134, 23);
            idTbox.TabIndex = 55;
            // 
            // modifyproductmin
            // 
            modifyproductmin.AutoSize = true;
            modifyproductmin.Location = new Point(246, 344);
            modifyproductmin.Name = "modifyproductmin";
            modifyproductmin.Size = new Size(28, 15);
            modifyproductmin.TabIndex = 54;
            modifyproductmin.Text = "Min";
            // 
            // modifyproductmax
            // 
            modifyproductmax.AutoSize = true;
            modifyproductmax.Location = new Point(71, 341);
            modifyproductmax.Name = "modifyproductmax";
            modifyproductmax.Size = new Size(29, 15);
            modifyproductmax.TabIndex = 53;
            modifyproductmax.Text = "Max";
            // 
            // modifyproductprice
            // 
            modifyproductprice.AutoSize = true;
            modifyproductprice.Location = new Point(67, 292);
            modifyproductprice.Name = "modifyproductprice";
            modifyproductprice.Size = new Size(33, 15);
            modifyproductprice.TabIndex = 52;
            modifyproductprice.Text = "Price";
            // 
            // modifyproductinventory
            // 
            modifyproductinventory.AutoSize = true;
            modifyproductinventory.Location = new Point(43, 244);
            modifyproductinventory.Name = "modifyproductinventory";
            modifyproductinventory.Size = new Size(57, 15);
            modifyproductinventory.TabIndex = 51;
            modifyproductinventory.Text = "Inventory";
            // 
            // modifyproductname
            // 
            modifyproductname.AutoSize = true;
            modifyproductname.Location = new Point(61, 193);
            modifyproductname.Name = "modifyproductname";
            modifyproductname.Size = new Size(39, 15);
            modifyproductname.TabIndex = 50;
            modifyproductname.Text = "Name";
            // 
            // modifyproductid
            // 
            modifyproductid.AutoSize = true;
            modifyproductid.Location = new Point(82, 151);
            modifyproductid.Name = "modifyproductid";
            modifyproductid.Size = new Size(18, 15);
            modifyproductid.TabIndex = 49;
            modifyproductid.Text = "ID";
            // 
            // ModifyProductAppTitle
            // 
            ModifyProductAppTitle.AutoSize = true;
            ModifyProductAppTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ModifyProductAppTitle.Location = new Point(4, 11);
            ModifyProductAppTitle.Name = "ModifyProductAppTitle";
            ModifyProductAppTitle.Size = new Size(153, 25);
            ModifyProductAppTitle.TabIndex = 48;
            ModifyProductAppTitle.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 627);
            Controls.Add(modifyproductSearchbar);
            Controls.Add(modifyproductSearchBtn);
            Controls.Add(partsassocaitedgrid);
            Controls.Add(allcandidatepartsgrid);
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
            Controls.Add(modifyproductmin);
            Controls.Add(modifyproductmax);
            Controls.Add(modifyproductprice);
            Controls.Add(modifyproductinventory);
            Controls.Add(modifyproductname);
            Controls.Add(modifyproductid);
            Controls.Add(ModifyProductAppTitle);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)partsassocaitedgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)allcandidatepartsgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox modifyproductSearchbar;
        private Button modifyproductSearchBtn;
        private DataGridView partsassocaitedgrid;
        private DataGridView allcandidatepartsgrid;
        private Button ProductDeleteBtn;
        private Button ProductAddBtn;
        private Label partsassociatedlabel;
        private Label allcandidatepartslabel;
        private Button cancelbtn;
        private Button savebtn;
        private TextBox minTbox;
        private TextBox maxTbox;
        private TextBox priceTbox;
        private TextBox inventoryTbox;
        private TextBox nameTbox;
        private TextBox idTbox;
        private Label modifyproductmin;
        private Label modifyproductmax;
        private Label modifyproductprice;
        private Label modifyproductinventory;
        private Label modifyproductname;
        private Label modifyproductid;
        private Label ModifyProductAppTitle;
    }
}