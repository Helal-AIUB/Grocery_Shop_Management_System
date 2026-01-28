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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroceryShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string query = $"select * from UserRegInfo where Email='{email}' and Password='{password}'";
            DataTable dt = DataAccess.GetData(query);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Email or Password!");
                return;
            }

            string statas = dt.Rows[0]["Statas"].ToString();

            if (statas == "User")
            {
                MessageBox.Show("Login successful!");
                UserDashBoard UDB = new UserDashBoard(email);
                UDB.Show();
                this.Hide();
            }
            else if (statas == "Employee")
            {
                string query3 = $"select * from EmpInfo where Email='{email}' and Password='{password}'";
                DataTable empDt = DataAccess.GetData(query3);

                if (empDt.Rows.Count == 0)
                {
                    MessageBox.Show("Wait For Admin Approval.");
                    return;
                }

                MessageBox.Show("Login successful. Congratulations!");

                EmployeeChoice empChoice = new EmployeeChoice();
                empChoice.Show();
                this.Hide();
            }

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            Password pass = new Password();
            pass.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '*';
        }
    }
}
