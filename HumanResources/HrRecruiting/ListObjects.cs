using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HrRecruiting
{
    public partial class ListObjects : HrRecruiting_Template
    {
        public ListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public ListObjects()
        {
            InitializeComponent();
            
        }
        private void btn_Display_Click(object sender, EventArgs e)
        {
        //    DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
        //    dataGridView2.DataSource = dTable;
        //    HR_Hiring
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
            dataGridView2.DataSource = dTable;

        }

        private void textBox_Command_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
