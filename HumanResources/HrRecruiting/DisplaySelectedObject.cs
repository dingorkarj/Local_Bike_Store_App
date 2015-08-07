using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HrRecruiting
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject()
        {
            InitializeComponent();
        }

        private void pictureBox_LeftLogo_Click(object sender, EventArgs e)
        {
       
        }

        private void button_DisplaySelectedObject_Click_1(object sender, EventArgs e)
        {
            textBox_TableName.Text = "accounts";
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);
        }
    }
}
