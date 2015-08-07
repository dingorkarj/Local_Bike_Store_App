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
    public partial class SelectProduct : HAWK_Template_2
    {
        DataTable dt;
        public SelectProduct()
        {
            InitializeComponent();
        }
        public SelectProduct(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            label_SubName.Text = "Pre Sales";
            dt = Utilities.DataBaseUtility.GetTable("select * from Products");
            dataGridView1.DataSource = dt;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
                int price = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[7].Value);
               //MessageBox.Show("productId" + productId);
               ConfirmOrder confirmOrder = new ConfirmOrder(ident, productId, "product",price.ToString());
               confirmOrder.Show();
            }

        }
    }
}
