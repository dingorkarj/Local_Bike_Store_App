using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollDeductions
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

            DataTable dt1 = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dt1;
        }

        private void textBox_CMD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
