using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GroceryShop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void LoadProductData()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-A305DT04;Initial Catalog=Grocery_Shop_Management;Integrated Security=True;Encrypt=False";
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from ProductInfo", con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                con.Close();

                DataTable dt = ds.Tables[0];

                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = dt;
                dataGridView2.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadProductData();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            LoadProductData();

        }

        int selectedItemId = -1;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                txtITName.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtITPrice.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtITName.Text = "";
            txtITquantity.Text = "";
            txtITPrice.Text = "";
            txtITCname.Text = "";

            dataGridView2.ClearSelection();
        }

        private void BtnAddBill_Click(object sender, EventArgs e)
        {
            string It_name = txtITName.Text;
            if (It_name == "")
            {
                MessageBox.Show("Invalid Item Name!");
                txtITName.Focus();
                return;
            }

            float quantity = float.Parse(txtITquantity.Text);
            if (quantity == '\0')
            {
                MessageBox.Show("Invalid Quantity!");
                txtITquantity.Focus();
                return;
            }
            float price = float.Parse(txtITPrice.Text);
            if (price == '\0')
            {
                MessageBox.Show("Invalid Price!");
                txtITPrice.Focus();
                return;
            }
            string C_name = txtITCname.Text;
            if(C_name == "")
            {
                MessageBox.Show("Invalid Client Name!");
                txtITCname.Focus();
                return;

            }
            var query = $"insert into Billing_Info values('{It_name}','{price}','{quantity}','{price*quantity}','{C_name}')";

            if (DataAccess.ExecuteQuery(query) == false)
                return;
            //ekhane asa mane - Stored in Billing_Info

            var query2 = "select * from Billing_Info";  //show kortechi gridview1 e - bill
            DataTable dt = DataAccess.GetData(query2);
            dataGridView1.DataSource = dt;


            txtITName.Text = "";
            txtITquantity.Text = "";
            txtITPrice.Text = "";
            txtITCname.Text = "";

            dataGridView2.ClearSelection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeChoice empChoice = new EmployeeChoice();
            empChoice.Show();
            this.Hide();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.Show();
            this.Hide();
        }
    }
}
