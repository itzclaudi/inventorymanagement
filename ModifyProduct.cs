using C968.model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968
{
    public partial class ModifyProduct : Form
    {
        private Product currentProduct;
        public ModifyProduct(Product product)
        {
            InitializeComponent();
            currentProduct = product;
            PopulateProductFields();
            RefreshPartGrids();
        }

        private void PopulateProductFields()
        {
            idTbox.Text = currentProduct.ProductID.ToString();
            nameTbox.Text = currentProduct.Name;
            inventoryTbox.Text = currentProduct.InStock.ToString();
            priceTbox.Text = currentProduct.Price.ToString();
            maxTbox.Text = currentProduct.Max.ToString();
            minTbox.Text = currentProduct.Min.ToString();
        }

        private void RefreshPartGrids()
        {
            allcandidatepartsgrid.DataSource = Inventory.AllParts;
            partsassocaitedgrid.DataSource = currentProduct.AssociatedParts;
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void modifyproductSearchBtn_Click(object sender, EventArgs e)
        {

            if (int.TryParse(modifyproductSearchbar.Text, out int id))
            {
                var part = Inventory.LookupPart(id);
                if (part != null)
                {
                    allcandidatepartsgrid.ClearSelection();
                    int index = Inventory.AllParts.IndexOf(part);
                    allcandidatepartsgrid.Rows[index].Selected = true;
                    allcandidatepartsgrid.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    MessageBox.Show("No Search Results Found.");
                    allcandidatepartsgrid.ClearSelection();
                }
            }
        }
        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
            if (partsassocaitedgrid.SelectedRows.Count > 0)
            {
                Part selectedPart = (Part)partsassocaitedgrid.SelectedRows[0].DataBoundItem;
                if (currentProduct.RemoveAssociatedPart(selectedPart.PartID))
                {
                    RefreshPartGrids();
                }
                else
                {
                    MessageBox.Show("Failed to remove part. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There are no parts to delete.", "Error");
            }
        }
        private void ProductAddBtn_Click(object sender, EventArgs e)
        {
            int partSelected = Convert.ToInt32(allcandidatepartsgrid.Rows[allcandidatepartsgrid.CurrentCell.RowIndex].Cells[0].Value);
            currentProduct.AddAssociatedPart(Inventory.LookupPart(partSelected));
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = int.Parse(idTbox.Text);
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
                currentProduct.ProductID = productID;
                currentProduct.Name = name;
                currentProduct.InStock = inStock;
                currentProduct.Price = price;
                currentProduct.Max = max;
                currentProduct.Min = min;

                Inventory.UpdateProduct(productID, currentProduct);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
