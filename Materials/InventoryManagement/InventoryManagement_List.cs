using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace InventoryManagement
{
    public partial class InventoryManagement_List : Inventory_New_Template
    {
        public InventoryManagement_List()
        {
            InitializeComponent();
        }
        public InventoryManagement_List(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }

        

    

        private void button_DisplayData_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(richTextBox1.Text);
            dataGridView1.DataSource = dtable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex.Equals(0))
            {


                richTextBox1.Text = "select * from Inventory";

            }
            if (comboBox1.SelectedIndex.Equals(1))
            {


                richTextBox1.Text = "select * from Inventory where Onhand<Min";

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox2.SelectedIndex.Equals(0))
            {

                richTextBox1.Text = "select * from Inventory where ExtRef=1";

            }

            if (comboBox2.SelectedIndex.Equals(0))
            {

                richTextBox1.Text = "select * from Inventory where ExtRef=1";

            }
            if (comboBox2.SelectedIndex.Equals(1))
            {

                richTextBox1.Text = "select * from Inventory where ExtRef=2";

            }
            if (comboBox2.SelectedIndex.Equals(2))
            {

                richTextBox1.Text = "select * from Inventory where ExtRef=3";

            }
            if (comboBox2.SelectedIndex.Equals(3))
            {

                richTextBox1.Text = "select * from Inventory where ExtRef=4";

            }
            if (comboBox2.SelectedIndex.Equals(4))
            {

                richTextBox1.Text = "select * from Inventory where ExtRef=5";

            }
            if (comboBox2.SelectedIndex.Equals(5))
            {

                richTextBox1.Text = "select * from Inventory where ExtRef=6";

            }
            if (comboBox2.SelectedIndex.Equals(6))
            {

                richTextBox1.Text = "select * from Inventory where ExtRef=7";

            }
            if (comboBox2.SelectedIndex.Equals(7))
            {

                richTextBox1.Text = "select * from Inventory where ExtRef=8";

            }

            //Supplier ID and LowInventory

            if(comboBox1.SelectedIndex.Equals(1)&& comboBox2.SelectedIndex.Equals(0))
            {

                richTextBox1.Text = "select * from Inventory where OnHand<Min and ExtRef=1";

            }

            if (comboBox1.SelectedIndex.Equals(1) && comboBox2.SelectedIndex.Equals(1))
            {

                richTextBox1.Text = "select * from Inventory where OnHand<Min and ExtRef=2";

            }

            if (comboBox1.SelectedIndex.Equals(1) && comboBox2.SelectedIndex.Equals(2))
            {

                richTextBox1.Text = "select * from Inventory where OnHand<Min and ExtRef=3";

            }

            if (comboBox1.SelectedIndex.Equals(1) && comboBox2.SelectedIndex.Equals(3))
            {

                richTextBox1.Text = "select * from Inventory where OnHand<Min and ExtRef=4";

            }
            if (comboBox1.SelectedIndex.Equals(1) && comboBox2.SelectedIndex.Equals(4))
            {

                richTextBox1.Text = "select * from Inventory where OnHand<Min and ExtRef=5";

            }
            if (comboBox1.SelectedIndex.Equals(1) && comboBox2.SelectedIndex.Equals(5))
            {

                richTextBox1.Text = "select * from Inventory where OnHand<Min and ExtRef=6";

            }
            if (comboBox1.SelectedIndex.Equals(1) && comboBox2.SelectedIndex.Equals(6))
            {

                richTextBox1.Text = "select * from Inventory where OnHand<Min and ExtRef=7";

            }
            if (comboBox1.SelectedIndex.Equals(1) && comboBox2.SelectedIndex.Equals(7))
            {

                richTextBox1.Text = "select * from Inventory where OnHand<Min and ExtRef=8";

            }
            




        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String ProductID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            callDisplaySelectedObject("Inventory", "16", ProductID);

        }

        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
           
            DataGridViewSelectedRowCollection DGV = this.dataGridView1.SelectedRows;
            String productID = DGV[0].Cells[1].Value.ToString();
            callDisplaySelectedObject("Inventory", "16", productID);
          
        }

        protected void callDisplaySelectedObject(string table_Name, string doc_Type, string doc_Num)
        {
            Utilities.Documents.DisplaySelectedObject newform = new Utilities.Documents.DisplaySelectedObject(ident, table_Name, doc_Type, doc_Num);
            newform.Show();
        }
        

    }
}
