using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C968.model;

namespace C968
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainFormLoad();
        }
        public void MainFormLoad()
        {
            Inventory.PopulateLists();
            dgvMainParts.DataSource = Inventory.AllParts;
            dgvMainProducts.DataSource = Inventory.Products;

            PartsSearchBtn.Enabled = false;
            ProductsSearchBtn.Enabled = false;
        }
        private void dgvMainParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMainParts.ClearSelection();
        }
        private void dgvMainProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMainProducts.ClearSelection();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PartAddBtn_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.ShowDialog();
        }
        private void PartModifyBtn_Click(object sender, EventArgs e)
        {
            if (dgvMainParts.CurrentRow != null)
            {
                Part selectedPart = (Part)dgvMainParts.CurrentRow.DataBoundItem;
                var modifyPartForm = new ModifyPart(selectedPart);
                modifyPartForm.ShowDialog();
                dgvMainParts.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a part to modify");
            }
        }

        private void PartDeleteBtn_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)dgvMainParts.CurrentRow.DataBoundItem;
            foreach (var product in Inventory.Products)
            {
                if (product.AssociatedParts.Contains(selectedPart))
                {
                    MessageBox.Show("Cannot delete a part that is associated with a product.");
                    return;
                }
            }
            if (Inventory.AllParts.Any())
            {
                DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);

                if (deletePartDialogResult == DialogResult.Yes)
                {
                    int partSelected = Convert.ToInt32(dgvMainParts.Rows[dgvMainParts.CurrentCell.RowIndex].Cells[0].Value);
                    Inventory.DeletePart(Inventory.LookupPart(partSelected));
                }
                else if (deletePartDialogResult == DialogResult.No)
                {

                }
                else
                {
                    MessageBox.Show("There are no parts to delete.", "Error");
                }
            }
        }
        private void PartsSearchbar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartsSearchbar.Text) || !int.TryParse(PartsSearchbar.Text, out int i))
            {
                PartsSearchBtn.Enabled = false;
                PartsSearchbar.BackColor = Color.Gray;

            }
            else
            {
                PartsSearchBtn.Enabled = true;
                PartsSearchbar.BackColor = Color.White;

            }
        }
        private void PartsSearchBtn_Click(object sender, EventArgs e)
        {

            if (int.TryParse(PartsSearchbar.Text, out int id))
            {
                var part = Inventory.LookupPart(id);
                if (part != null)
                {
                    dgvMainParts.ClearSelection();
                    int index = Inventory.AllParts.IndexOf(part);
                    dgvMainParts.Rows[index].Selected = true;
                    dgvMainParts.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    MessageBox.Show("No Search Results Found.");
                    dgvMainParts.ClearSelection();
                }
            }
        }
        private void ProductAddBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void ProductModifyBtn_Click(object sender, EventArgs e)
        {
            if (Inventory.Products.Any())
            {
                Product currentProduct = dgvMainProducts.CurrentRow.DataBoundItem as Product;
                new ModifyProduct(currentProduct).ShowDialog();
                dgvMainProducts.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a product to modify");
            }

        }

        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            
            if (Inventory.Products.Any())
            {
                DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);

                if (deletePartDialogResult == DialogResult.Yes)
                {
                    int productSelected = Convert.ToInt32(dgvMainProducts.Rows[dgvMainProducts.CurrentCell.RowIndex].Cells[0].Value);
                    Inventory.RemoveProduct(productSelected);
                }
                else if (deletePartDialogResult == DialogResult.No)
                {

                }
                else
                {
                    MessageBox.Show("There are no parts to delete.", "Error");
                }
            }
        }
        private void ProductsSearchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ProductsSearchbar.Text, out int id))
            {
                var product = Inventory.LookupProduct(id);
                if (product != null)
                {
                    dgvMainProducts.ClearSelection();
                    int index = Inventory.Products.IndexOf(product);
                    dgvMainProducts.Rows[index].Selected = true;
                    dgvMainProducts.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    MessageBox.Show("No Search Results Found.");
                    dgvMainProducts.ClearSelection();
                }
            }
        }

        private void ProductsSearchbar_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductsSearchbar.Text) || !int.TryParse(ProductsSearchbar.Text, out int i))
            {
                ProductsSearchBtn.Enabled = false;
                ProductsSearchbar.BackColor = Color.Gray;

            }
            else
            {
                ProductsSearchBtn.Enabled = true;
                ProductsSearchbar.BackColor = Color.White;

            }
        }

    }
}
