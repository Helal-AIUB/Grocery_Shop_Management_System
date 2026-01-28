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

namespace GroceryShop
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm(string Name)
        {
            InitializeComponent();
            string name = Name;
            txtAdmin.Text = name;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Password pass = new Password();
            pass.Show();
            this.Hide();
        }

        private void Refresh()
        {
            string query = "select * from EmpHiringReq";
            DataTable dt = DataAccess.GetData(query);
            dgvEmp.DataSource = dt;
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if(dgvEmp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Row First!");
                return;
            }
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string email =txtEmail.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;

            var queri = $"insert into EmpInfo (Name, Email, Password, Phone) VALUES ('{name}', '{phone}', '{email}', '{password}')";
            if (DataAccess.ExecuteQuery(queri) == false)
                return;

            var query = $"delete from EmpHiringReq where ID={id}";

            if (DataAccess.ExecuteQuery(query) == false)
                return;

            //MessageBox.Show("Deleted.");
            MessageBox.Show("Employee Hiring Comfirmed");
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

            dgvEmp.ClearSelection();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            //txtAdmin.Text = "Helal";
            Refresh();
            dgvEmp.ClearSelection();
        }

        int selectedItemId = -1;
        private void BtnEdit_Click(object sender, EventArgs e)
        {

            if (txtAdmin.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Select a Row First!");
                return;
            }

            string name = txtAdmin.Text;
            string phone = txtPhone.Text;
            string address = txtEmail.Text;
            string password = txtPassword.Text;

            var query = $"update EmpInfo set Name = '{name}', Phone = '{phone}', Address = '{address}', Password = '{password}' where Phone = '{phone}'";


            if (DataAccess.ExecuteQuery(query) == false)
                return;

            MessageBox.Show("Updated Successfully.");

        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmp.Rows[e.RowIndex];

                txtID.Text = dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone.Text = dgvEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dgvEmp.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPassword.Text = dgvEmp.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(dgvEmp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Row First!");
                return;
            }
            //string phone = txtPhone.Text;
            //if(txtID.Text == "" || txtName.Text =="" || txtEmail.Text == "" || txtPassword.Text == "" || txtPhone.Text == " ")
            //{
            //    MessageBox.Show("Please Select a Row First!");
            //    return;
            //}
            var result = MessageBox.Show("Are you sure you want to delete?","Confirmation?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            int id = int.Parse(txtID.Text);
            var query = $"delete from EmpHiringReq where ID ='{id}'";

            if (DataAccess.ExecuteQuery(query) == false)
                return;

            MessageBox.Show("Employee Hiring Request were Deleted");
            dgvEmp.ClearSelection();
        }
    }
}
