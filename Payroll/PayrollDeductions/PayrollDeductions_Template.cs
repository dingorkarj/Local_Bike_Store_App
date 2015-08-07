using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollDeductions
{
    public partial class PayrollDeductions_Template : HAWK_Template_2
    {
        public PayrollDeductions_Template()
        {
            InitializeComponent();
        }

        public PayrollDeductions_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }


    }
}
