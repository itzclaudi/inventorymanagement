using Claudice_Inguanzo_C968.model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968
{
    public partial class AddProduct : Form
    {
        BindingList<Part> CurrentAssociatedParts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            ProductFormLoad();
        }
        public void ProductFormLoad()
        {
            var bs1 = new BindingSource();
            bs1.DataSource = Inventory.AllParts;
            dgvallcandidateparts.DataSource = bs1;
            dgvallcandidateparts.Columns["PartID"].HeaderText = "Part ID";
            dgvallcandidateparts.Columns["Name"].HeaderText = "Part Name";
            dgvallcandidateparts.Columns["InStock"].HeaderText = "Inventory";
            dgvallcandidateparts.Columns["Price"].HeaderText = "Price";
            dgvallcandidateparts.Columns["Max"].Visible = true;
            dgvallcandidateparts.Columns["Min"].Visible = true;

            var bs2 = new BindingSource();
            bs2.DataSource = CurrentAssociatedParts;
            partsassocaitedgrid.DataSource = bs2;
            partsassocaitedgrid.Columns["PartID"].HeaderText = "Part ID";
            partsassocaitedgrid.Columns["Name"].HeaderText = "Part Name";
            partsassocaitedgrid.Columns["InStock"].HeaderText = "Inventory";
            partsassocaitedgrid.Columns["Price"].HeaderText = "Price";
            partsassocaitedgrid.Columns["Max"].Visible = true;
            partsassocaitedgrid.Columns["Min"].Visible = true;
        }
        private void PartsSearchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddpartsSearchbar.Text, out int id))
            {
                var part = Inventory.LookupPart(id);
                if (part != null)
                {
                    dgvallcandidateparts.ClearSelection();
                    int index = Inventory.AllParts.IndexOf(part);
                    dgvallcandidateparts.Rows[index].Selected = true;
                    dgvallcandidateparts.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    MessageBox.Show("No Search Results Found.");
                    dgvallcandidateparts.ClearSelection();
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
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

            if (max < min)
            {
                MessageBox.Show("Error: Max must be greater than min");
                return;
            }
            if (inStock < min || inStock > max)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }
            Product addProduct = new Product((Inventory.Products.Count + 1), name, price, inStock, max, min);
            Inventory.AddProduct(addProduct);
            foreach (Part part in CurrentAssociatedParts)
            {
                addProduct.AddAssociatedPart(part);
                break;
            }
            this.Close();

        }
        private void ProductAddBtn_Click(object sender, EventArgs e)
        {
            Part addPart = (Part)dgvallcandidateparts.CurrentRow.DataBoundItem;
            CurrentAssociatedParts.Add(addPart);
        }
        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            if (partsassocaitedgrid.CurrentRow == null || !partsassocaitedgrid.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            CurrentAssociatedParts.Remove(partsassocaitedgrid.CurrentRow.DataBoundItem as Part);
        }

        private void dgvallcandidateparts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

