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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GroceryShop
{
    public partial class UserDashBoard : Form
    {
        public UserDashBoard()
        {
            InitializeComponent();
        }

        string userName;
        string userEmail;
        string userAddress;
        //string P_Statas;
        string userPhone;

        public UserDashBoard(string email)
        {
            InitializeComponent();

            userEmail = email;
            txtUser.Text = userEmail;


        }


        private void UserDashBoard_Load(object sender, EventArgs e)
        {
            string query = "select * from ProductInfo";
            DataTable dt = DataAccess.GetData(query);
            dgvItem.DataSource = dt;

            dgvItem.ClearSelection();



            //---------------------------------------------------------------------

            try
            {
                string queri = $"select * from UserRegInfo where Email= '{userEmail}'";
                DataTable dtt = DataAccess.GetData(queri);

                if (dtt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid!");
                    return;
                }
                else
                {

                    userName = dtt.Rows[0]["UserName"].ToString();
                    userAddress = dtt.Rows[0]["Address"].ToString();
                    userPhone = dtt.Rows[0]["Phone"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgvItem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Row First!");
                return;
            }


            int ID = int.Parse(txtItemID.Text);
            //string name = txtPName.Text;
            //string quantity = txtPquantity.Text;
            float price = float.Parse(txtPprice.Text);
            //string category = CBcategory.Text;

            Payment payment = new Payment(ID,userName,userEmail,userAddress,userPhone,price);
            payment.Show();
            this.Close();
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvItem.Rows[e.RowIndex];

                txtItemID.Text = dgvItem.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPName.Text = dgvItem.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPquantity.Text = dgvItem.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPprice.Text = dgvItem.Rows[e.RowIndex].Cells[3].Value.ToString();
                CBcategory.Text = dgvItem.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void BtnPclear_Click(object sender, EventArgs e)
        {
            dgvItem.ClearSelection();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
