using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollDeductions
{
    public partial class PayrollDeductions_Main : PayrollDeductions.PayrollDeductions_Template
    {
        public PayrollDeductions_Main()
        {
            InitializeComponent();
        }
         public PayrollDeductions_Main(IdentityObject ident)
        {
            InitializeComponent();
             base.SaveIdent(ident);
             base.DisplayIdent(ident);
        }

         private void button2_Click(object sender, EventArgs e)
         {
             GetGrossPay getGsPay = new GetGrossPay(ident);
             getGsPay.Show();

         }

         private void button1_Click(object sender, EventArgs e)
         {

         }

        
           

    }
}
