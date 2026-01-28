using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GroceryShop
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            //string query = $"select * from Billing_Info where Email='{email}' and Password='{password}'";
            try
            {
                string query = "select * from Billing_Info";
                DataTable dt = DataAccess.GetData(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Billing!");
                    return;
                }
                else
                {

                    string C_name = dt.Rows[0]["C_Name"].ToString();
                    string P_ID = dt.Rows[0]["ID"].ToString();
                    string P_name = dt.Rows[0]["It_Name"].ToString();
                    int price = int.Parse(dt.Rows[0]["Price"].ToString());
                    float quantity = float.Parse(dt.Rows[0]["Quantity"].ToString());
                    float total = price * quantity;

                    txtCname.Text = C_name;
                    txtPID.Text = P_ID;
                    txtPname.Text = P_name;
                    txtPrice.Text = price.ToString();
                    txtquantity.Text = quantity.ToString();
                    txttotal.Text = total.ToString();

                    var query2 = "delete from Billing_Info";
                    if (DataAccess.ExecuteQuery(query2) == false)
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No bill were created!");
                this.Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Close();
        }
    }
}
