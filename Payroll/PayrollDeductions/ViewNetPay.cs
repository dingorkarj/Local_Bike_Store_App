using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollDeductions
{
    public partial class ViewNetPay : PayrollDeductions.PayrollDeductions_Template
    {

        int empNo = 0;
        public ViewNetPay()
        {
            InitializeComponent();
        }

        public ViewNetPay(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            empNo = Convert.ToInt32(base.ident.UserID);

            string s = "select * from Emp_Pay_TaxDeductions where IntAgent=" + empNo + "";

            DataTable dt1 = Utilities.DataBaseUtility.GetTable(s);
            dataGridView1.DataSource = dt1;
          

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            empNo = Convert.ToInt32(base.ident.UserID);

            string s = "select * from Emp_Pay_Benefits where IntAgent=" + empNo + "";

            DataTable dt1 = Utilities.DataBaseUtility.GetTable(s);
            dataGridView1.DataSource = dt1;
          
        }
    }
}
