using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Purchases
{
    public partial class LowMaterials_List : PurchaseOrder_Template 
    {
       IdentityObject _ident;
        List<string> _supplierNames;
       
        public LowMaterials_List(IdentityObject identObject)
        {
            InitializeComponent();
            label_SubName.Text = "Low Inventory";
            
            _ident =  identObject;
            base.ident = _ident;
            label_Ident.Text = _ident.UserID + " :  " + _ident.UserName;
            _supplierNames = Utilities.DataBaseUtility.GetList("select Name from suppliers");
            for (int i = 1; i < 8; i++)
                comboBox1.Items.Add(i.ToString() + " :  " + _supplierNames[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable ;
            dataGridView1.Visible = true;
        }
        private void ResetCommand()
        {
            string part1 = "select * from " + PODConstants.INVENTORY_LIST +" where onHand < Min and onHand > 0";
            string part2 = "";
            string part3 = "";
            if (comboBox1.SelectedIndex > 0)
                part2 = " and ExtRef = " + comboBox1.SelectedIndex.ToString();
            if (comboBox2.SelectedIndex > 0)
            {
                    part3 = " and Category = '" + comboBox2.SelectedItem.ToString() + "'";
            }
            textBox_CMD.Text = part1 + part2 + part3;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Supplier.Text = comboBox1.SelectedItem.ToString();
            ResetCommand();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Status.Text = comboBox2.SelectedItem.ToString();
            ResetCommand();
   
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            if ((_ident.Role != "sales") && (_ident.Role != "manager"))
            {
                MessageBox.Show("Only authorized managers and sales employees can create sales orders", "improper credentials");
                return;
            }
          
        }
       
       
        private void buttonSpecificProduct_Click(object sender, EventArgs e)
        {
            Utilities.DisplayProduct app2 = new Utilities.DisplayProduct(_ident);
            app2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells["DocType"].Value.ToString();
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells["DocNum"].Value.ToString();

           // DisplayInventoryItem pds = new DisplayInventoryItem(base.ident,  docNumStr);
            DisplaySelectedObject pds = new DisplaySelectedObject(base.ident, PODConstants.INVENTORY_LIST, docTypeStr, docNumStr);
            pds.Show();
        }

       
    }
}
