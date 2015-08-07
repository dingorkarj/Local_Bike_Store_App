using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
    public partial class Sales_sm_Main : Sales_sm.Sales_sm_template
    {
        public Sales_sm_Main()
        {
            InitializeComponent();
        }
        public Sales_sm_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }
        protected virtual void button_ListObjects_Click_1(object sender, EventArgs e)
        {
            Sales_sm.ListObjects mylist = new Sales_sm.ListObjects(ident);
            mylist.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sales_sm.ListServiceTypes app = new Sales_sm.ListServiceTypes(ident);
            app.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sales_sm.CustomerInfo app = new Sales_sm.CustomerInfo(ident);
            app.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales_sm.LogSrvcReq app = new Sales_sm.LogSrvcReq(ident);
            app.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Sales_sm.AddServiceOrder app = new Sales_sm.AddServiceOrder(ident, "", "");
            app.Show();
        }
    }
}
