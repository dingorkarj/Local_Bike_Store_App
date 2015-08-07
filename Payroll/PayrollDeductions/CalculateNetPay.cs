using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollDeductions
{
    public partial class CalculateNetPay : PayrollDeductions.PayrollDeductions_Template
    {
        public CalculateNetPay()
        {
            InitializeComponent();
        }

        public CalculateNetPay(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gp = 0;
            double tax=0.0;
            double  benefits = 0.0;
            double np = 0.0;
            gp = Convert.ToDouble(textBox1.Text);
            tax = .14 * gp;
            benefits = .15 * gp;
            np = gp - tax - benefits;
            textBox2.Text = tax.ToString();
            textBox3.Text = benefits.ToString();
            textBox4.Text = np.ToString();

        }
    }
}
