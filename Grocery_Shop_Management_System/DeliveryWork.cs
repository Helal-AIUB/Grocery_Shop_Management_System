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

namespace GroceryShop
{
    public partial class DeliveryWork : Form
    {
        public DeliveryWork()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            string query = "select * from OrderHistoryInfo";
            DataTable dt = DataAccess.GetData(query);
            dgvOrder.DataSource = dt;
        }

        private void DeliveryWork_Load(object sender, EventArgs e)
        {
            var query = "select * from OrderHistoryinfo";
            DataTable dt = DataAccess.GetData(query);
            dgvOrder.DataSource = dt;

            dgvOrder.ClearSelection();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrder.Rows[e.RowIndex];

                txtPID.Text = dgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUname.Text = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUemail.Text = dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtUaddress.Text = dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                CBstatas.Text = dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtUphn.Text = dgvOrder.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void BtnPclear_Click(object sender, EventArgs e)
        {

            txtPID.Text = "";
            txtUname.Text = "";
            txtUemail.Text = "";
            txtUaddress.Text = "";
            CBstatas.Text = "";
            txtUphn.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string statas = CBstatas.Text;
            int id = int.Parse(txtPID.Text);
            var query = $"update OrderHistoryInfo set P_Statas = '{statas}' where P_ID = '{id}'";

            if (DataAccess.ExecuteQuery(query) == false)
                return;
            MessageBox.Show("Ordered Delivered");



            txtPID.Text = "";
            txtUname.Text = "";
            txtUemail.Text = "";
            txtUaddress.Text = "";
            CBstatas.Text = "";
            txtUphn.Text = "";
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            EmployeeChoice emp = new EmployeeChoice();
            emp.Show();
            this.Hide();
        }
    }
}
