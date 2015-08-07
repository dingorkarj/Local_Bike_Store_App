using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HR
{
    public partial class HR_Main : HR.HR_Template 
    {
        public HR_Main()
        {
            InitializeComponent();
            IdentityObject ident = new IdentityObject();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public HR_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        //private void button_ListObjects_Click(object sender, EventArgs e)
        //{
            
        //    ListObjects newapp = new ListObjects();
        //    newapp.Show();
        //}

        //private void button_DisplaySelectedObject_Click_1(object sender, EventArgs e)
        //{
        //    DisplaySelectedObject newapp = new DisplaySelectedObject();
        //    newapp.Show();

        //}

        private void button_Hiring_Click(object sender, EventArgs e)
        {
            new HrRecruiting.HrRecruiting_Main(base.ident).Show();
           // new NewApplication.NewApplication_Main(base.ident).Show();
        }

        private void button_Benefits_Click(object sender, EventArgs e)
        {
            new HRBenefits.HRBenefits_Main(base.ident).Show();
          //  new NewApplication.NewApplication_Main(base.ident).Show();
        }
    }
}
