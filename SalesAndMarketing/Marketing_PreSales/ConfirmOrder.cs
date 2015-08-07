using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndMarketing
{
    public partial class ConfirmOrder : HAWK_Template_2
    {
        String productOrBundle = "";
        int promoProdId = 0;
        static int orderNum = 100251;
        int empID = 0;
        int custID = 0;
        double price=0;
        public ConfirmOrder()
        {
            InitializeComponent();
        }
        public ConfirmOrder(IdentityObject ident,int promoProdId,String id,String price)
        {
            productOrBundle = id;
            InitializeComponent();
           this. price=Convert.ToDouble(price);
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            this.promoProdId = promoProdId;
            label_SubName.Text = "Pre Sales";
         //   MessageBox.Show("price-----------------------"+price);
            label7.Text += price;
        dataGridView2.DataSource=   Utilities.DataBaseUtility.GetTable("select EmplID,FirstName,LastName from Employees");
        dataGridView3.DataSource = Utilities.DataBaseUtility.GetTable("select CustomerID,FirstName,LastName from Customers");
       
            if (id.Equals("bundle"))
            {
                dataGridView1.DataSource = Utilities.DataBaseUtility.GetTable("select * from Bundle_Details where PromoCode=" + promoProdId);
                label6.Text = "Confirm Promo Bundle Details";
            }
            else
            {
           //     MessageBox.Show("Confirm order"+promoProdId);
                dataGridView1.DataSource = Utilities.DataBaseUtility.GetTable("select * from Products where ProductID=" + promoProdId);
                label6.Text = "Confirm Product Details";
            }
            //MessageBox.Show("Confirm order");
            
           
        


        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<String> listProductId = new List<string>();
            if (dataGridView2.SelectedRows.Count > 0)
            {
                empID = Convert.ToInt16(dataGridView2.SelectedRows[0].Cells[0].Value);
            }
            if (dataGridView3.SelectedRows.Count > 0)
            {
                custID = Convert.ToInt16(dataGridView3.SelectedRows[0].Cells[0].Value);

            }
            List<String> s = Utilities.DataBaseUtility.GetList("select max(docNum) from Orders");
           // MessageBox.Show("max value------------"+s[1]);
            if(s[1]==null || s[1]==""){
                MessageBox.Show("1stvalue");
                s[1] = "300";
            }
            int orderMaxDocnum=Convert.ToInt16(s[1])+1;
            List<String> s1 = Utilities.DataBaseUtility.GetList("select max(docNum) from Orders_Details");
            if (s1[1] == null || s1[1] == "")
            {
                MessageBox.Show("1stvalue");
                s1[1] = "300";
            }
            //MessageBox.Show("max value------------" + s1[1]);
            int orderDetMaxDocnum = Convert.ToInt16(s1[1]) + 1;
            if (productOrBundle.Equals("bundle"))
            {
             //   MessageBox.Show("Helloooooooooo budle");
                String str = Utilities.DataBaseUtility.Execute("insert into Orders(docNum,docType,CustomerID,EmplID,PromoCode,startDate,endDate,Price,Quantity,Comments) values(" + orderMaxDocnum + ",21," + custID + "," + empID + "," + promoProdId + ",'11/9/2014','11/25/2014'," + this.price + ",1,'" + textBox4.Text + "')", ident);
              MessageBox.Show(str);
                listProductId = Utilities.DataBaseUtility.GetList("select ProductID from Bundle_Details where PromoCode=" + promoProdId);
              
                for (int i = 1; i <= listProductId.Count - 1; i++)
                {
                 //   MessageBox.Show(listProductId[i]);
                    Utilities.DataBaseUtility.Execute("insert into Orders_Details values(" + orderDetMaxDocnum + ",21," + custID + "," + empID + "," + listProductId[i] + "," + promoProdId + ",'11/9/2014','11/25/2014'," + this.price + ",1,'" + textBox4.Text + "')", ident);
                }
            }
            else
            {
                //MessageBox.Show("Helloooooooooo");
                Utilities.DataBaseUtility.Execute("insert into Orders(docNum,docType,CustomerID,EmplID,ProductID,startDate,endDate,Price,Quantity,Comments) values(" + orderMaxDocnum + ",21," + custID + "," + empID + "," + promoProdId + ",'11/9/2014','11/25/2014'," + this.price + ",1,'" + textBox4.Text + "')", ident);
                Utilities.DataBaseUtility.Execute("insert into Orders_Details(docNum,docType,CustomerID,EmplID,ProductID,startDate,endDate,Price,Quantity,Comments) values(" + orderDetMaxDocnum + ",21," + custID + "," + empID + "," + promoProdId + ",'11/9/2014','11/25/2014'," + this.price + ",1,'" + textBox4.Text + "')", ident);
            }
           MessageBox.Show( "Order Placed Successfully");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
