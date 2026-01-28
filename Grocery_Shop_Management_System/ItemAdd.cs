using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GroceryShop
{
    public partial class ItemAdd : Form
    {
        public ItemAdd()
        {
            InitializeComponent();
        }

        private void LoadItems()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-A305DT04;Initial Catalog=Grocery_Shop_Management;Integrated Security=True;Encrypt=False");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ID, It_Name, Quantity, Unit_Price, Category FROM ProductInfo", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvItem.DataSource = dt;

        }

        private void ClearFields()
        {
            txtPName.Clear();
            txtPquantity.Clear();
            txtPprice.Clear();
            CBcategory.SelectedIndex = -1;
            selectedItemId = -1; // Reset ID
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            EmployeeChoice empChoice = new EmployeeChoice();
            empChoice.Show();
            this.Hide();
        }

        private void Refresh()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-A305DT04;Initial Catalog=Grocery_Shop_Management;Integrated Security=True;Encrypt=False";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from ProductInfo";

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                con.Close();

                dgvItem.AutoGenerateColumns = true;
                dgvItem.DataSource = dt;
                dgvItem.Refresh();
                dgvItem.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BtnPadd_Click(object sender, EventArgs e)
        {
            string name = txtPName.Text;
            if (name == "")
            {
                MessageBox.Show("Invalid Item Name!");
                txtPName.Focus();
                return;
            }

            float quantity = float.Parse(txtPquantity.Text);
            if (quantity == '\0')
            {
                 MessageBox.Show("Invalid Quantity!");
                 txtPquantity.Focus();
                 return;
            }
            float price = float.Parse(txtPprice.Text);
            if (price == '\0')
            {
                MessageBox.Show("Invalid Price!");
                txtPprice.Focus();
                return;
            }
            string category;
            if (CBcategory.SelectedItem != null)
            {
                category = CBcategory.SelectedItem.ToString();
    
            }
            else
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-A305DT04;Initial Catalog=Grocery_Shop_Management;Integrated Security=True;Encrypt=False";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"insert into ProductInfo values('{name}','{quantity}','{price}','{category}')";
                //MessageBox.Show(cmd.CommandText);
                MessageBox.Show("Item Successfully Added!");
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPclear_Click(object sender, EventArgs e)
        {
            txtPName.Text = "";
            txtPquantity.Text = "";
            txtPprice.Text = "";
            CBcategory.Text = "";

            dgvItem.ClearSelection();
        }

        private void ItemAdd_Load(object sender, EventArgs e)
        {
            Refresh();
            //dgvItem.AutoGenerateColumns = false;
            //dgvItem.Refresh();
            //dgvItem.ClearSelection();
        }
        int selectedItemId = -1;
        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvItem.Rows[e.RowIndex];

                txtPName.Text = dgvItem.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPquantity.Text = dgvItem.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPprice.Text = dgvItem.Rows[e.RowIndex].Cells[3].Value.ToString();
                CBcategory.SelectedItem = dgvItem.Rows[e.RowIndex].Cells[4].Value.ToString();
                selectedItemId = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           if (selectedItemId == -1)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }

            string name = txtPName.Text;
            int quantity;
            decimal unitPrice;

            if (!int.TryParse(txtPquantity.Text, out quantity) || !decimal.TryParse(txtPprice.Text, out unitPrice))
            {
                MessageBox.Show("Please enter valid quantity and price.");
                return;
            }

            string category = CBcategory.Text;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-A305DT04;Initial Catalog=Grocery_Shop_Management;Integrated Security=True;Encrypt=False");
                con.Open();

                string query = "UPDATE ProductInfo SET It_Name = @name, Quantity = @quantity, Unit_Price = @price, Category = @category WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", unitPrice);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@id", selectedItemId);

                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item updated successfully!");
                    LoadItems();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnPdelete_Click(object sender, EventArgs e)
        {
            if (selectedItemId == -1)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-A305DT04;Initial Catalog=Grocery_Shop_Management;Integrated Security=True;Encrypt=False");
                con.Open();

                string query = "DELETE FROM ProductInfo WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", selectedItemId);

                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item deleted successfully!");
                    LoadItems();      // Refresh grid
                    ClearFields();    // Clear input fields
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
