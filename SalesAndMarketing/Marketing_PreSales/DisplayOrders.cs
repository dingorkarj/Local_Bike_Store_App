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
    public partial class DisplayOrders : HAWK_Template_2

    {
        Int16 docN = 0;
        public DisplayOrders()
        {
            InitializeComponent();
        }
        public DisplayOrders(IdentityObject ident)
        {
            
            InitializeComponent(); 
            label_SubName.Text = "Display All Orders";
        dataGridView1.DataSource=    Utilities.DataBaseUtility.GetTable("select * from Orders");

        }

        private void DisplayOrders_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_RowHeaderMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
     Int16 price=  Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[8].Value);
     docN = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
     textBox1.Text = price.ToString();
     String promoOrProd = "";
     //textBox2.Text = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[8].Value).ToString();
    // MessageBox.Show(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
     if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString().Equals(""))
     {
         textBox2.Text = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[4].Value).ToString();
     }
     else if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Equals(""))
     {
         textBox2.Text = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[5].Value).ToString();
}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int16 newPrice = Convert.ToInt16(textBox1.Text);
           Utilities.DataBaseUtility.Execute("update Orders set Price="+newPrice+" where DocNum="+docN,ident);


           MessageBox.Show("Price Updated Successfully!!");
          // new DisplayOrders(ident);
           dataGridView1.DataSource = Utilities.DataBaseUtility.GetTable("select * from Orders");
           textBox1.Text = "";
        }
    }
}
