using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryShop
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Password_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string name = txtAname.Text;
            string pass = txtPass.Text;
            if (pass == "helal")
            {
                EmployeeForm empForm = new EmployeeForm(name);
                empForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid admin password!!");
            }
        }
    }
}
