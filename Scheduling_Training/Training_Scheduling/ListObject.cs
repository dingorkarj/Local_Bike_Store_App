using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class ListObject : HAWK_Template_3
    {
        public ListObject()
        {
            InitializeComponent();
            label_SubName.Text = "Training and Scheduling";
        }
        public ListObject(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dTable;

        }
    }
}
