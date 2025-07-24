namespace C968
{
    partial class ModifyPart
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
            machineTbox = new TextBox();
            minTbox = new TextBox();
            maxTbox = new TextBox();
            priceTbox = new TextBox();
            inventoryTbox = new TextBox();
            nameTbox = new TextBox();
            idTbox = new TextBox();
            modpartmachineid = new Label();
            modpartmin = new Label();
            modpartmax = new Label();
            modpartprice = new Label();
            modpartinventory = new Label();
            modpartname = new Label();
            modpartid = new Label();
            outsourcedRbtn = new RadioButton();
            inhouseRbtn = new RadioButton();
            ModPartAppTitle = new Label();
            SuspendLayout();
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(418, 383);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(75, 23);
            cancelbtn.TabIndex = 39;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(337, 383);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 23);
            savebtn.TabIndex = 38;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // machineTbox
            // 
            machineTbox.Location = new Point(278, 303);
            machineTbox.Name = "machineTbox";
            machineTbox.Size = new Size(134, 23);
            machineTbox.TabIndex = 37;
            // 
            // minTbox
            // 
            minTbox.Location = new Point(393, 258);
            minTbox.Name = "minTbox";
            minTbox.Size = new Size(100, 23);
            minTbox.TabIndex = 36;
            // 
            // maxTbox
            // 
            maxTbox.Location = new Point(230, 258);
            maxTbox.Name = "maxTbox";
            maxTbox.Size = new Size(100, 23);
            maxTbox.TabIndex = 35;
            // 
            // priceTbox
            // 
            priceTbox.Location = new Point(278, 206);
            priceTbox.Name = "priceTbox";
            priceTbox.Size = new Size(134, 23);
            priceTbox.TabIndex = 34;
            // 
            // inventoryTbox
            // 
            inventoryTbox.Location = new Point(278, 158);
            inventoryTbox.Name = "inventoryTbox";
            inventoryTbox.Size = new Size(134, 23);
            inventoryTbox.TabIndex = 33;
            // 
            // nameTbox
            // 
            nameTbox.Location = new Point(278, 107);
            nameTbox.Name = "nameTbox";
            nameTbox.Size = new Size(134, 23);
            nameTbox.TabIndex = 32;
            // 
            // idTbox
            // 
            idTbox.Location = new Point(278, 65);
            idTbox.Name = "idTbox";
            idTbox.ReadOnly = true;
            idTbox.Size = new Size(134, 23);
            idTbox.TabIndex = 31;
            // 
            // modpartmachineid
            // 
            modpartmachineid.AutoSize = true;
            modpartmachineid.Location = new Point(146, 303);
            modpartmachineid.Name = "modpartmachineid";
            modpartmachineid.Size = new Size(67, 15);
            modpartmachineid.TabIndex = 30;
            modpartmachineid.Text = "Machine ID";
            // 
            // modpartmin
            // 
            modpartmin.AutoSize = true;
            modpartmin.Location = new Point(359, 258);
            modpartmin.Name = "modpartmin";
            modpartmin.Size = new Size(28, 15);
            modpartmin.TabIndex = 29;
            modpartmin.Text = "Min";
            // 
            // modpartmax
            // 
            modpartmax.AutoSize = true;
            modpartmax.Location = new Point(184, 255);
            modpartmax.Name = "modpartmax";
            modpartmax.Size = new Size(29, 15);
            modpartmax.TabIndex = 28;
            modpartmax.Text = "Max";
            // 
            // modpartprice
            // 
            modpartprice.AutoSize = true;
            modpartprice.Location = new Point(145, 206);
            modpartprice.Name = "modpartprice";
            modpartprice.Size = new Size(68, 15);
            modpartprice.TabIndex = 27;
            modpartprice.Text = "Price / Cost";
            // 
            // modpartinventory
            // 
            modpartinventory.AutoSize = true;
            modpartinventory.Location = new Point(156, 158);
            modpartinventory.Name = "modpartinventory";
            modpartinventory.Size = new Size(57, 15);
            modpartinventory.TabIndex = 26;
            modpartinventory.Text = "Inventory";
            // 
            // modpartname
            // 
            modpartname.AutoSize = true;
            modpartname.Location = new Point(174, 107);
            modpartname.Name = "modpartname";
            modpartname.Size = new Size(39, 15);
            modpartname.TabIndex = 25;
            modpartname.Text = "Name";
            // 
            // modpartid
            // 
            modpartid.AutoSize = true;
            modpartid.Location = new Point(195, 65);
            modpartid.Name = "modpartid";
            modpartid.Size = new Size(18, 15);
            modpartid.TabIndex = 24;
            modpartid.Text = "ID";
            // 
            // outsourcedRbtn
            // 
            outsourcedRbtn.AutoSize = true;
            outsourcedRbtn.Location = new Point(310, 15);
            outsourcedRbtn.Name = "outsourcedRbtn";
            outsourcedRbtn.Size = new Size(87, 19);
            outsourcedRbtn.TabIndex = 23;
            outsourcedRbtn.TabStop = true;
            outsourcedRbtn.Text = "Outsourced";
            outsourcedRbtn.UseVisualStyleBackColor = true;
            outsourcedRbtn.CheckedChanged += outsourcedRbtn_CheckedChanged;
            // 
            // inhouseRbtn
            // 
            inhouseRbtn.AutoSize = true;
            inhouseRbtn.Location = new Point(195, 15);
            inhouseRbtn.Name = "inhouseRbtn";
            inhouseRbtn.Size = new Size(74, 19);
            inhouseRbtn.TabIndex = 22;
            inhouseRbtn.TabStop = true;
            inhouseRbtn.Text = "In-House";
            inhouseRbtn.UseVisualStyleBackColor = true;
            inhouseRbtn.CheckedChanged += inhouseRbtn_CheckedChanged;
            // 
            // ModPartAppTitle
            // 
            ModPartAppTitle.AutoSize = true;
            ModPartAppTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ModPartAppTitle.Location = new Point(12, 9);
            ModPartAppTitle.Name = "ModPartAppTitle";
            ModPartAppTitle.Size = new Size(119, 25);
            ModPartAppTitle.TabIndex = 21;
            ModPartAppTitle.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(cancelbtn);
            Controls.Add(savebtn);
            Controls.Add(machineTbox);
            Controls.Add(minTbox);
            Controls.Add(maxTbox);
            Controls.Add(priceTbox);
            Controls.Add(inventoryTbox);
            Controls.Add(nameTbox);
            Controls.Add(idTbox);
            Controls.Add(modpartmachineid);
            Controls.Add(modpartmin);
            Controls.Add(modpartmax);
            Controls.Add(modpartprice);
            Controls.Add(modpartinventory);
            Controls.Add(modpartname);
            Controls.Add(modpartid);
            Controls.Add(outsourcedRbtn);
            Controls.Add(inhouseRbtn);
            Controls.Add(ModPartAppTitle);
            Name = "ModifyPart";
            Text = "ModifyPart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelbtn;
        private Button savebtn;
        private TextBox machineTbox;
        private TextBox minTbox;
        private TextBox maxTbox;
        private TextBox priceTbox;
        private TextBox inventoryTbox;
        private TextBox nameTbox;
        private TextBox idTbox;
        private Label modpartmachineid;
        private Label modpartmin;
        private Label modpartmax;
        private Label modpartprice;
        private Label modpartinventory;
        private Label modpartname;
        private Label modpartid;
        private RadioButton outsourcedRbtn;
        private RadioButton inhouseRbtn;
        private Label ModPartAppTitle;
    }
}