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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnEye_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            timer1.Stop();
        }

        private void txtCpass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtCpass.Text == "")
                return;
            if(txtCpass.Text != txtPass.Text)
            {
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
            }
        }

        string statas;
        private void BtnSignUp_Click(object sender, EventArgs e)
        {

            if (cbLoginType.SelectedItem == null)
            {
                MessageBox.Show("Select Login Type first!");
                return;
            }

            if (cbLoginType.SelectedItem.ToString() == "User")
            {
                statas = "User";
            }
            else if (cbLoginType.SelectedItem.ToString() == "Employee")
            {
                statas = "Employee";
            }
            else
            {
                MessageBox.Show("Invalid Login Type!");
                return;
            }
            string name = txtUserName.Text;
            if (name == "")
            {
                MessageBox.Show("Invalid Name!");
                txtUserName.Focus();
                return;
            }

            string email = txtEmail.Text;
            if (email == "" || email.Contains("@")==false || email.Contains(".")==false)
            {
                MessageBox.Show("Invalid Email!");
                txtEmail.Focus();
                return;
            }
            if(lblError.Visible == true)
            {
                MessageBox.Show(lblError.Text);
                txtPass.Focus();
                return;
            }
            string password = txtPass.Text;

            DateTime dob;
            try
            {
                dob = Convert.ToDateTime(dtpDob.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid DOB");
                dtpDob.Focus();
                return;
            }

            string gender = "";
            if (rBtnMale.Checked == true) {
                gender = "Male";
            } else if (rBtnFemale.Checked == true) {
                gender = "Female";
            }

            string address = txtAddress.Text;
            string phone = txtPhone.Text;

            var query = $"insert into UserRegInfo values('{name}','{email}','{password}','{dob}','{gender}','{address}','{statas}','{phone}')";
            var query2 = $"insert into EmpHiringReq values('{name}','{email}','{password}','{phone}')";

            if(statas == "Employee")
            {
                if (DataAccess.ExecuteQuery(query2) == false)
                    return;
            }
            if (DataAccess.ExecuteQuery(query) == false)
                return;

            MessageBox.Show("Registration Successfully Completed.");

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void BtnbackL_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
