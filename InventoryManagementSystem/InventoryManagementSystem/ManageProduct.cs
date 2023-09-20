using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        private void prodId_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void prodCatSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {

        }

        private void productsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
