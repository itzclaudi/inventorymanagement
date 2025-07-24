namespace C968
{
    partial class AddPart
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
            AppTitle = new Label();
            inhouseRbtn = new RadioButton();
            outsourcedRbtn = new RadioButton();
            addpartid = new Label();
            addpartname = new Label();
            addpartinventory = new Label();
            addpartprice = new Label();
            addpartmax = new Label();
            addpartmin = new Label();
            addpartmachineid = new Label();
            idTbox = new TextBox();
            nameTbox = new TextBox();
            inventoryTbox = new TextBox();
            priceTbox = new TextBox();
            maxTbox = new TextBox();
            minTbox = new TextBox();
            machineTbox = new TextBox();
            savebtn = new Button();
            cancelbtn = new Button();
            SuspendLayout();
            // 
            // AppTitle
            // 
            AppTitle.AutoSize = true;
            AppTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AppTitle.Location = new Point(12, 9);
            AppTitle.Name = "AppTitle";
            AppTitle.Size = new Size(92, 25);
            AppTitle.TabIndex = 2;
            AppTitle.Text = "Add Part";
            // 
            // inhouseRbtn
            // 
            inhouseRbtn.AutoSize = true;
            inhouseRbtn.Location = new Point(134, 15);
            inhouseRbtn.Name = "inhouseRbtn";
            inhouseRbtn.Size = new Size(74, 19);
            inhouseRbtn.TabIndex = 3;
            inhouseRbtn.TabStop = true;
            inhouseRbtn.Text = "In-House";
            inhouseRbtn.UseVisualStyleBackColor = true;
            inhouseRbtn.CheckedChanged += inhouseRbtn_CheckedChanged;
            // 
            // outsourcedRbtn
            // 
            outsourcedRbtn.AutoSize = true;
            outsourcedRbtn.Location = new Point(249, 15);
            outsourcedRbtn.Name = "outsourcedRbtn";
            outsourcedRbtn.Size = new Size(87, 19);
            outsourcedRbtn.TabIndex = 4;
            outsourcedRbtn.TabStop = true;
            outsourcedRbtn.Text = "Outsourced";
            outsourcedRbtn.UseVisualStyleBackColor = true;
            outsourcedRbtn.CheckedChanged += outsourcedRbtn_CheckedChanged;
            // 
            // addpartid
            // 
            addpartid.AutoSize = true;
            addpartid.Location = new Point(134, 65);
            addpartid.Name = "addpartid";
            addpartid.Size = new Size(18, 15);
            addpartid.TabIndex = 5;
            addpartid.Text = "ID";
            // 
            // addpartname
            // 
            addpartname.AutoSize = true;
            addpartname.Location = new Point(113, 107);
            addpartname.Name = "addpartname";
            addpartname.Size = new Size(39, 15);
            addpartname.TabIndex = 6;
            addpartname.Text = "Name";
            // 
            // addpartinventory
            // 
            addpartinventory.AutoSize = true;
            addpartinventory.Location = new Point(95, 158);
            addpartinventory.Name = "addpartinventory";
            addpartinventory.Size = new Size(57, 15);
            addpartinventory.TabIndex = 7;
            addpartinventory.Text = "Inventory";
            // 
            // addpartprice
            // 
            addpartprice.AutoSize = true;
            addpartprice.Location = new Point(84, 206);
            addpartprice.Name = "addpartprice";
            addpartprice.Size = new Size(68, 15);
            addpartprice.TabIndex = 8;
            addpartprice.Text = "Price / Cost";
            // 
            // addpartmax
            // 
            addpartmax.AutoSize = true;
            addpartmax.Location = new Point(123, 255);
            addpartmax.Name = "addpartmax";
            addpartmax.Size = new Size(29, 15);
            addpartmax.TabIndex = 9;
            addpartmax.Text = "Max";
            // 
            // addpartmin
            // 
            addpartmin.AutoSize = true;
            addpartmin.Location = new Point(298, 258);
            addpartmin.Name = "addpartmin";
            addpartmin.Size = new Size(28, 15);
            addpartmin.TabIndex = 10;
            addpartmin.Text = "Min";
            // 
            // addpartmachineid
            // 
            addpartmachineid.AutoSize = true;
            addpartmachineid.Location = new Point(85, 303);
            addpartmachineid.Name = "addpartmachineid";
            addpartmachineid.Size = new Size(67, 15);
            addpartmachineid.TabIndex = 11;
            addpartmachineid.Text = "Machine ID";
            // 
            // idTbox
            // 
            idTbox.Enabled = false;
            idTbox.Location = new Point(217, 65);
            idTbox.Name = "idTbox";
            idTbox.Size = new Size(134, 23);
            idTbox.TabIndex = 12;
            idTbox.TextChanged += idTbox_TextChanged;
            // 
            // nameTbox
            // 
            nameTbox.Location = new Point(217, 107);
            nameTbox.Name = "nameTbox";
            nameTbox.Size = new Size(134, 23);
            nameTbox.TabIndex = 13;
            // 
            // inventoryTbox
            // 
            inventoryTbox.Location = new Point(217, 158);
            inventoryTbox.Name = "inventoryTbox";
            inventoryTbox.Size = new Size(134, 23);
            inventoryTbox.TabIndex = 14;
            // 
            // priceTbox
            // 
            priceTbox.Location = new Point(217, 206);
            priceTbox.Name = "priceTbox";
            priceTbox.Size = new Size(134, 23);
            priceTbox.TabIndex = 15;
            // 
            // maxTbox
            // 
            maxTbox.Location = new Point(169, 258);
            maxTbox.Name = "maxTbox";
            maxTbox.Size = new Size(100, 23);
            maxTbox.TabIndex = 16;
            // 
            // minTbox
            // 
            minTbox.Location = new Point(332, 258);
            minTbox.Name = "minTbox";
            minTbox.Size = new Size(100, 23);
            minTbox.TabIndex = 17;
            // 
            // machineTbox
            // 
            machineTbox.Location = new Point(217, 303);
            machineTbox.Name = "machineTbox";
            machineTbox.Size = new Size(134, 23);
            machineTbox.TabIndex = 18;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(276, 383);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 23);
            savebtn.TabIndex = 19;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click_1;
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(357, 383);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(75, 23);
            cancelbtn.TabIndex = 20;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click_1;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(cancelbtn);
            Controls.Add(savebtn);
            Controls.Add(machineTbox);
            Controls.Add(minTbox);
            Controls.Add(maxTbox);
            Controls.Add(priceTbox);
            Controls.Add(inventoryTbox);
            Controls.Add(nameTbox);
            Controls.Add(idTbox);
            Controls.Add(addpartmachineid);
            Controls.Add(addpartmin);
            Controls.Add(addpartmax);
            Controls.Add(addpartprice);
            Controls.Add(addpartinventory);
            Controls.Add(addpartname);
            Controls.Add(addpartid);
            Controls.Add(outsourcedRbtn);
            Controls.Add(inhouseRbtn);
            Controls.Add(AppTitle);
            Name = "AddPart";
            Text = "AddPart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AppTitle;
        private RadioButton inhouseRbtn;
        private RadioButton outsourcedRbtn;
        private Label addpartid;
        private Label addpartname;
        private Label addpartinventory;
        private Label addpartprice;
        private Label addpartmax;
        private Label addpartmin;
        private Label addpartmachineid;
        private TextBox idTbox;
        private TextBox nameTbox;
        private TextBox inventoryTbox;
        private TextBox priceTbox;
        private TextBox maxTbox;
        private TextBox minTbox;
        private TextBox machineTbox;
        private Button savebtn;
        private Button cancelbtn;
    }
}