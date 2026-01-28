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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        float bill;

        int P_ID;
        string UserName;
        string UserEmail;
        string UserAddress;
        string UserPhone;


        public Payment(int P_id,string userName,string userEmail,string userAddress,string userPhone,float price)
        {
            InitializeComponent();
            bill = price;

            P_ID = P_id;
            UserName = userName;
            UserEmail = userEmail;
            UserAddress = userAddress;
            UserPhone = userPhone;
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            txtPID.Text = P_ID.ToString();
            txtCname.Text = UserName;
            txtCemail.Text = UserEmail;
            txtCaddress.Text = UserAddress;
            txtCphone.Text = UserPhone;

            txtBill.Text = bill.ToString();
        }

        private void BtnBikash_Click(object sender, EventArgs e)
        {

            var query = $"insert into OrderHistoryInfo (P_ID,UserName, UserEmail, UserAddress, P_Statas,Phone) values ('{P_ID}','{UserName}','{UserEmail}','{UserAddress}','Pending','{UserPhone}')";
            if (DataAccess.ExecuteQuery(query) == false)
                return;
            MessageBox.Show(" Payment Confirmed! \n Product will be delivered within 24 hours");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            UserDashBoard db = new UserDashBoard(UserEmail);
            db.Show();
            this.Hide();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
