using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Claudice_Inguanzo_C968.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968
{
    public partial class ModifyPart : Form

    {
        public Part partSelected;

        public ModifyPart(Part part)
        {
            InitializeComponent();
            partSelected = part;
            InitializeFields();
        }

        private void InitializeFields()
        {
            if (partSelected is Inhouse)
            {
                inhouseRbtn.Checked = true;
                modpartmachineid.Text = "Machine ID";
                machineTbox.Text = ((Inhouse)partSelected).MachineID.ToString();
            }
            else if (partSelected is Outsourced)
            {
                outsourcedRbtn.Checked = true;
                modpartmachineid.Text = "Company Name";
                machineTbox.Text = ((Outsourced)partSelected).CompanyName.ToString();
            }
            idTbox.Text = partSelected.PartID.ToString();
            nameTbox.Text = partSelected.Name;
            inventoryTbox.Text = partSelected.InStock.ToString();
            priceTbox.Text = partSelected.Price.ToString();
            minTbox.Text = partSelected.Min.ToString();
            maxTbox.Text = partSelected.Max.ToString();
        }

        private void inhouseRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (inhouseRbtn.Checked)
            {
                modpartmachineid.Text = "Machine ID";
            }
        }

        private void outsourcedRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourcedRbtn.Checked)
            {
                modpartmachineid.Text = "Company Name";
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int partID = int.Parse(idTbox.Text);
                string name = nameTbox.Text;
                int inStock = int.Parse(inventoryTbox.Text);
                decimal price = decimal.Parse(priceTbox.Text);
                int max = int.Parse(maxTbox.Text);
                int min = int.Parse(minTbox.Text);

                if (int.Parse(maxTbox.Text) < int.Parse(minTbox.Text))
                {
                    MessageBox.Show("Error: Max must be greater than min");
                    return;
                }
                if (int.Parse(inventoryTbox.Text) < int.Parse(minTbox.Text) || int.Parse(inventoryTbox.Text) > int.Parse(maxTbox.Text))
                {
                    MessageBox.Show("Error: Inventory must be between max and min inventory");
                    return;
                }

                partSelected.Name = nameTbox.Text;
                partSelected.InStock = int.Parse(inventoryTbox.Text);
                partSelected.Price = decimal.Parse(priceTbox.Text);
                partSelected.Min = int.Parse(minTbox.Text);
                partSelected.Max = int.Parse(maxTbox.Text);

                if (inhouseRbtn.Checked)
                {
                    if (partSelected is Inhouse inhouse)
                    {
                        inhouse.MachineID = Convert.ToInt32(machineTbox.Text);
                        Inventory.UpdatePart(inhouse.PartID, inhouse);
                    }
                    else if (partSelected is Outsourced outsourced)
                    {
                        Inventory.DeletePart(outsourced);
                        int machineID = Convert.ToInt32(machineTbox.Text);
                        Inventory.AddPart(new Inhouse(partID, name, price, inStock, max, min, machineID));
                        inhouseRbtn.Checked = true;
                    }
                }
                else if (outsourcedRbtn.Checked)
                {
                    if (partSelected is Outsourced outsourced)
                    {
                        outsourced.CompanyName = machineTbox.Text;
                        Inventory.UpdatePart(outsourced.PartID, outsourced);
                    }
                    else if (partSelected is Inhouse inhouse)
                    {
                        string companyName = machineTbox.Text;
                        if (int.TryParse(companyName, out _))
                        {
                            throw new FormatException("Company name cannot be a number");
                        }
                        Inventory.DeletePart(inhouse);
                        Inventory.AddPart(new Outsourced(partID, name, price, inStock, max, min, companyName));
                        outsourcedRbtn.Checked = true;
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please ensure all fields are filled correctly: " + ex.Message);
                return;
            }
            Close();
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
