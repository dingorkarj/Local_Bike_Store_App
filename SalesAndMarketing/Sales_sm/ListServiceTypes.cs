using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
    public partial class ListServiceTypes : HAWK_Template_2
    {
        public ListServiceTypes()
        {
            InitializeComponent();
        }
        public ListServiceTypes(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            label_SubName.Text="Sales_sm";
           
        }

        private void button_Return_Click_1(object sender, EventArgs e)
        {
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox1.Text);
            //DataTable dtable = Utilities.DataBaseUtility.
            dataGridView1.DataSource = dtable;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            DataGridViewButtonColumn dgvbtnedit = new DataGridViewButtonColumn();
            //DataGridCheckBoxColumn dgvCmb = new DataGridCheckBoxColumn();
            //dgvCmb.ValueType = typeof(bool);
            dgvbtnedit.Name = "Update";
            dgvbtnedit.HeaderText = "Update";
            dgvbtnedit.Text = "Update";
            //dgvbtnedit. = "SAVE";
            dgvbtnedit.UseColumnTextForButtonValue = true;   
            dataGridView1.Columns.Add(dgvbtnedit);
            DataGridViewButtonColumn dgvbtndel = new DataGridViewButtonColumn();
            //DataGridCheckBoxColumn dgvCmb = new DataGridCheckBoxColumn();
            //dgvCmb.ValueType = typeof(bool);
            dgvbtndel.Name = "Delete";
            dgvbtndel.HeaderText = "Delete";
            dgvbtndel.Text = "Delete";
            //dgvbtnedit. = "SAVE";
            dgvbtndel.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(dgvbtndel); 


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //DisplayServiceTypes pds = new DisplayServiceTypes(ident, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //pds.Show();

            if (e.ColumnIndex == 4)
            {
                DisplayServiceTypes pds = new DisplayServiceTypes(ident, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                pds.Show();

            }
            if (e.ColumnIndex == 5)
            {
                string Delete_order = "Delete from Service_Type where Docnum =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
               // string Delete_orderDtl = "Delete from Service_Order_Details where Docnum =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                 
                string returncode = Utilities.DataBaseUtility.Execute(Delete_order, base.ident);
               //  returncode = Utilities.DataBaseUtility.Execute(Delete_orderDtl, base.ident);
                button1.PerformClick();
            
               // select  DocNum, DocType, ServiceProductType,ServiceProductDescription from Service_Type

            }

  

        }
        

    

        private void button2_Click(object sender, EventArgs e)
        {
            AddServiceTypes pas = new AddServiceTypes(ident);
            pas.Show();

          
        }
    }
}
