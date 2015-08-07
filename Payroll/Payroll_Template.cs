using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Payroll_Template : HAWK_Template_2
    {
        public Payroll_Template()
        {
            InitializeComponent();

        }

        protected override void button_ChangeObject_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("must provide overriding procedure");
            //this.Close();
            //Create_Timecard cr_time = new Create_Timecard(ident);
            //cr_time.Show();

        }

        protected void button_ChangeObject_Click_1(object sender, EventArgs e)
        {
           // this.Close();
          // Create_Timecard cr_time = new Create_Timecard(ident);
           //cr_time.Show();
        }





    }
}


