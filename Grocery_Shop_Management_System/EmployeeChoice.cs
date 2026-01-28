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
    public partial class EmployeeChoice : Form
    {
        public EmployeeChoice()
        {
            InitializeComponent();
        }

        private void BtnProductClick_Click(object sender, EventArgs e)
        {
            ItemAdd itemAdd = new ItemAdd();
            itemAdd.Show();
            this.Hide();
        }

        private void BtnBillingClick_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            bill.Show();
            this.Hide();
        }

        private void BtnEmpBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void lblProductClick_Click(object sender, EventArgs e)
        {
            ItemAdd itemAdd = new ItemAdd();
            itemAdd.Show();
            this.Hide();
        }

        private void lblBillingClick_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            bill.Show();
            this.Hide();
        }

        private void EmployeeChoice_Load(object sender, EventArgs e)
        {

        }

        private void lblDwork_Click(object sender, EventArgs e)
        {
            DeliveryWork dw = new DeliveryWork();
            dw.Show();
            this.Hide();
        }
    }
}
