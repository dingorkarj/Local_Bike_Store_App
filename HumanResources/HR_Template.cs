using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HR
{
    public partial class HR_Template : HAWK_Template_1
    {
        public HR_Template()
        {
            InitializeComponent();
        }
        public HR_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_Hiring_Click(object sender, EventArgs e)
        {
            new NewApplication.NewApplication_Main(base.ident).Show();
        }
    }
}
