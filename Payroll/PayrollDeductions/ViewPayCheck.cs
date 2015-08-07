using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollDeductions
{
    
    public partial class ViewPayCheck : PayrollDeductions.PayrollDeductions_Template
    {
        int empNo=0;
        public ViewPayCheck()
        {
            InitializeComponent();
        }

        public ViewPayCheck(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empNo = Convert.ToInt32(base.ident.UserID);

            string s = "select * from Emp_Pay_NetPay where IntAgent=" + empNo + "";

            DataTable dt1 = Utilities.DataBaseUtility.GetTable(s);
            dataGridView1.DataSource = dt1;
        }

    }
}
