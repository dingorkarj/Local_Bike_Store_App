using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
    public partial class ListObjects : HAWK_Template_3
    {
        public ListObjects()
        {
            InitializeComponent();
        }

        public ListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            label_SubName.Text="Sales_sm";
           
        }

        private void button_Return_Click_1(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("its here");
            string doctypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_TableName.Text = "Service_Order";
            DisplaySelectedObject pds = new DisplaySelectedObject(base.ident, textBox_TableName.Text, doctypeStr, docNumStr);
            pds.Show();

        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            DataTable dt1 = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dt1;
        }
    }

}
