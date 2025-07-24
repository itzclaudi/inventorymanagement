using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using C968.model;

namespace C968
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void outsourcedRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourcedRbtn.Checked)
            {
                addpartmachineid.Text = "Company Name";
            }
        }

        private void inhouseRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (inhouseRbtn.Checked)
            {
                addpartmachineid.Text = "Machine ID";
            }
        }

        private void cancelbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            int min;
            int max;
            int inStock;
            decimal price;

            try
            {
                min = int.Parse(minTbox.Text);
                max = int.Parse(maxTbox.Text);
                inStock = int.Parse(inventoryTbox.Text);
                price = decimal.Parse(priceTbox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            string name = nameTbox.Text;
            price = decimal.Parse(priceTbox.Text);
            min = int.Parse(minTbox.Text);
            max = int.Parse(maxTbox.Text);
            inStock = int.Parse(inventoryTbox.Text);

            if (min > max)
            {
                MessageBox.Show("Error: Max must be greater than min");
                return;
            }

            if (inStock > max || inStock < min)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }


            if (inhouseRbtn.Checked)
            {
                try
                {
                    Inhouse inPart = new Inhouse((Inventory.AllParts.Count + 1), name, price, inStock, max, min, int.Parse(machineTbox.Text));
                    Inventory.AddPart(inPart);
                    Close();
                }
                catch (FormatException ex)
                {
                    // Handle the specific exception
                    MessageBox.Show($"Error: {ex.Message}");

                }
            }
            else
            {
                Outsourced outPart = new Outsourced((Inventory.AllParts.Count + 1), name, price, inStock, max, min, machineTbox.Text);
                Inventory.AddPart(outPart);
                Close();
            }
        }

        private void idTbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
