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
    public partial class PurchaseOrder_List : PurchaseOrder_Template
    {
     //  IdentityObject _ident;
         public PurchaseOrder_List(IdentityObject identObject)
        {
            InitializeComponent();
            label_SubName.Text = "Purchase Orders";
        //    _ident =  identObject;
            base.SaveIdent( identObject);
            DataTable dtSupplier = new DataTable();
            dtSupplier = Utilities.DataBaseUtility.GetTable("select * from Suppliers");
            for (int i = 0; i < dtSupplier.Rows.Count; i++)
                comboBox1.Items.Add((i + 1).ToString() + "  :  " + dtSupplier.Rows[i]["Name"].ToString());
           // textBox_Status.Text =   _ident.UserID + "  =>  " + _ident.Role;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetCommand();
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            
            
            //dtable.Columns[8].Caption = "Quantity";
            //dtable.Columns[9].Caption = "Price";
            dataGridView1.DataSource = dtable ;
            if (dtable != null)
            {
                dataGridView1.Columns[2].HeaderText = "Supplier";
                dataGridView1.Columns[3].HeaderText = "Employee";
                dataGridView1.Columns[4].HeaderText = "Status";
                dataGridView1.Columns[6].HeaderText = "Purchse Order Date";
                dataGridView1.Columns[5].HeaderText = "Delivery Date";
                dataGridView1.Columns[7].HeaderText = "Total Cost";
            }
            dataGridView1.Visible = true;
        }
        private void ResetCommand()
        {
            string part1 = "select DocNum,DocType,ExtRef,IntRef,status,TextValue1,TextValue2,NumValue1,comment from PURCHASE_ORDERS ";
            //if (radioBtn_Invoices.Checked) part1 = "select DocNum,DocType,ExtRef,IntRef,status,TextValue1,TextValue2,comments from Deliveries ";
            string part2 = "";
            string part3 = "";
            if (comboBox1.SelectedIndex > 0)
                part2 = " where ExtRef = " + textBox_Supplier.Text;
            if (comboBox2.SelectedIndex > 0)
            {
                if (comboBox1.SelectedIndex > -1)
                    part3 = " and status = " + textBox_Status.Text;
                else part3 = " where status =  " + textBox_Status.Text;
            }
            textBox_CMD.Text = part1 + part2 + part3;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Supplier.Text = (comboBox1.SelectedIndex ).ToString();
            ResetCommand();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Status.Text = (comboBox2.SelectedIndex -1).ToString();
            ResetCommand();
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PurchaseOrderDisplay app2 = new PurchaseOrderDisplay();
            app2.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //if ((_ident.Role != "sales") && (_ident.Role != "manager"))
            //{
            //    MessageBox.Show("Only authorized managers and sales employees can create sales orders", "improper credentials");
            //    return;
            //}
            //  Create Purchase Order
            //  CreatePurchaseOrder form1 = new CreatePurchaseOrder(_ident);      form1.Show();
        }
       
        private void button6_Click_1(object sender, EventArgs e)
        {
            //UpdateSalesOrder form1 = new UpdateSalesOrder();
            //form1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Purchases.PurchaseOrderDisplay podf = new Purchases.PurchaseOrderDisplay(base.ident,dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            podf.Show();
            this.Close();
         
        }

        private void button_PendingActions_Click(object sender, EventArgs e)
        {

        }
        public PurchaseOrder_List()
        {
            InitializeComponent();
           // _ident = new IdentityObject();
            DataTable dtSupplier = new DataTable();
            dtSupplier = Utilities.DataBaseUtility.GetTable("select * from Suppliers");
            for (int i = 0; i < dtSupplier.Rows.Count; i++)
                comboBox1.Items.Add((i + 1).ToString() + "  :  " + dtSupplier.Rows[i]["Name"].ToString());
        }

    }
}
