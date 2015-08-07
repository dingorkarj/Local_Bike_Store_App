using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountsReceivable
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

        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            DisplaySelectedObject pds = new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr);
            pds.Show();
        }

    }
}
