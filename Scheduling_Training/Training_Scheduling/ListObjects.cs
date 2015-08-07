using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class ListObjects : Training_Scheduling.Training_Scheduling_template
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

        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
            dataGridView1.DataSource = dTable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           // string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

           // DisplaySelectedObject pds = new DisplaySelectedObject(base.ident, textBox_Command.Text, docTypeStr, docNumStr);
           // pds.Show();
        

        }
    }
}
