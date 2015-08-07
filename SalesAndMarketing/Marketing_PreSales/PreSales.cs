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

    public partial class PreSales : HAWK_Template_2
    {

        DataTable dt;
        List<String> listPrice = new List<String>();
        public PreSales()
        {
            InitializeComponent();
        }
        public PreSales(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            label_SubName.Text = "Pre Sales";
            dt = Utilities.DataBaseUtility.GetTable("select * from Bundle");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
          
            List<String> listProductId = new List<String>();
        //    MessageBox.Show("dataGridView1_RowheaderDoubleClick");
            Decimal discount = 0;
            Discountlabel.Text = "Discount you get: ";
            originalPricelabel.Text = "Original Price: ";
            totalPriceLabel.Text = "Total Price: ";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int promoid = Convert.ToInt16( dataGridView1.SelectedRows[0].Cells[4].Value);

            //    MessageBox.Show("PromoID" + promoid);
                dt = Utilities.DataBaseUtility.GetTable("select * from Bundle_Details where PromoCode=" + promoid);
                dataGridView2.DataSource = dt;
                listPrice=Utilities.DataBaseUtility.GetList("select Price from Bundle where PromoCode=" + promoid);
              //  MessageBox.Show("Price " + listPrice[1]);
                 totalPriceLabel.Text += listPrice[1];
                listProductId = Utilities.DataBaseUtility.GetList("select ProductID from Bundle_Details where PromoCode=" + promoid);
                Decimal totalPrice = 0;
                for (int i = 1; i <= listProductId.Count-1; i++)
                {
                    List<String> price = new List<String>();
                //    MessageBox.Show(listProductId[i]);
               price=     Utilities.DataBaseUtility.GetList("select Price from Products where ProductID=" + listProductId[i]);
               //MessageBox.Show(price[1]);
                    totalPrice = totalPrice + Convert.ToDecimal(price[1]);
                 //   MessageBox.Show("TotalPrice "+totalPrice);
                }
                    originalPricelabel.Text += totalPrice.ToString();

                    discount = totalPrice - Convert.ToDecimal(listPrice[1]);
                    Discountlabel.Text += discount.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("Proceed_btnClick");
           //  MessageBox.Show("dataGridView1_RowheaderDoubleClick");
             if (dataGridView1.SelectedRows.Count > 0)
             {
                 int promoid = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[4].Value);
                 ConfirmOrder confirmOrder = new ConfirmOrder(ident,promoid,"bundle",listPrice[1]);
                 confirmOrder.Show();
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectProduct selectProduct = new SelectProduct(ident);
            selectProduct.Show();
        }

        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            SalesAndMarketing.DisplayOrders displayOrders = new SalesAndMarketing.DisplayOrders(ident);
            displayOrders.ShowDialog();
        }

        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {

        }
    }
}