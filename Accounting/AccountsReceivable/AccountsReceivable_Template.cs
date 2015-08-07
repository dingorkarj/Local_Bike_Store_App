using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountsReceivable
{
    public partial class AccountsReceivable_Template : HAWK_Template_2
    {
        public AccountsReceivable_Template()
        {
            InitializeComponent();
        }

        private void button_ListObjects_Click_1(object sender, EventArgs e)
        {
            ListObjects mylist = new ListObjects(base.ident);
            mylist.Show();
        }

        private void button_DisplaySelectedObject_Click_1(object sender, EventArgs e)
        {
            DisplaySelectedObject app = new DisplaySelectedObject(base.ident);
            app.Show();
        }


    }
}
