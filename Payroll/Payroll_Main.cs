using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Payroll_Main : Payroll.Payroll_Template
    {
        public Payroll_Main(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent( identObject);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();

            //button3.Visible = false;
            button3.Visible = true;
            String Role ="Manager";
            //textBox1.Text = base.ident.Role;
            //textBox1.Visible = false;
            if (base.ident.Role.Trim() != Role)
            {
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Timecard app = new Create_Timecard(base.ident); app.Show();
            //new NewApplication.NewApplication_Main(base.ident).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String EntID = base.ident.UserID.ToString();
            TimeList app = new TimeList(base.ident, EntID); app.Show();
            //new NewApplication.NewApplication_Main(base.ident).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeList app = new TimeList(base.ident); app.Show();
            //new NewApplication.NewApplication_Main(base.ident).Show();
        }

        protected override void button_ChangeObject_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("must provide overriding procedure");
            //this.Close();
            //Create_Timecard cr_time = new Create_Timecard(ident);   cr_time.Show();

        }

        private void button_GrossPay_Click(object sender, EventArgs e)
        {
            //new PayrollDeductions.GetGrossPay(base.ident).Show();
            //new NewApplication.NewApplication_Main(base.ident).Show();
            String EntID = base.ident.UserID.ToString();
            GrossList app = new GrossList(base.ident, EntID); app.Show();
        }

        private void button_Deductions_Click(object sender, EventArgs e)
        {
            new PayrollDeductions.ListObjects(base.ident).Show();
          //  new NewApplication.NewApplication_Main(base.ident).Show();
        }

        private void button_NetPay_Click(object sender, EventArgs e)
        {
            new PayrollDeductions.NetGrossPay(base.ident).Show();
           // new NewApplication.NewApplication_Main(base.ident).Show();
        }

    }
}
