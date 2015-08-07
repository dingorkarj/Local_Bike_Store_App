using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
    public partial class Sales_sm_template : HAWK_Template_2
    {
        public Sales_sm_template()
        {
            InitializeComponent();
            label_SubName.Text = "Sales_sm";
        }

        protected virtual void button_ListObjects_Click_1(object sender, EventArgs e)
        {
           Sales_sm.ListObjects mylist = new Sales_sm.ListObjects(base.ident); 
            mylist.Show();
        }

        private void button_DisplaySelectedObject_Click_1(object sender, EventArgs e)
        {
            Sales_sm.DisplaySelectedObject app = new Sales_sm.DisplaySelectedObject(base.ident);
            app.Show();
           

        }

    }
}
