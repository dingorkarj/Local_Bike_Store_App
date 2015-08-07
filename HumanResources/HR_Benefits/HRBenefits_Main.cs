using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRBenefits
{
    public partial class HRBenefits_Main : HRBenefits.HRBenefits_Template
    {
        public HRBenefits_Main()
        {
            InitializeComponent();
        }
        public HRBenefits_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            if (ident.Dept != 7)
                button1.Hide();
            //label1.Text = DateTime.Now.ToString("d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HRBenefits.HRBenefits_HRView hrapp = new HRBenefits.HRBenefits_HRView(ident); hrapp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HRBenefits.EmployeeView hrapp = new HRBenefits.EmployeeView(ident); hrapp.Show();

        }
    }
}
