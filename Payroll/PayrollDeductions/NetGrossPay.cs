using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollDeductions
{
    public partial class NetGrossPay : PayrollDeductions.PayrollDeductions_Template
    {
        double np = 0.0;
        double gp = 0.0;
        double totalTaxes = 0.0;
        double benefits = 0.0;
        int intRef = 0;
        public NetGrossPay()
        {
            InitializeComponent();
        }
        public NetGrossPay(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public void populateFields(IdentityObject i, int intRef,double g, double t1,double b)
        {

            //netPay.populateFields(ident, intRef,gp,totalTax,totalBenefits);
            textBox1.Text = g.ToString();
            textBox2.Text = t1.ToString();
            textBox3.Text = b.ToString();
            np = g - b - t1;
            textBox4.Text = np.ToString();
            totalTaxes = t1;
            benefits = b;
            gp = g;
           
            this.intRef = intRef;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            try
            {
               string sInput = "update Emp_Pay_NetPay set Gross_Amount=" + gp + ",TotalTaxDeductions=" + totalTaxes + ",TotalBenefits=" + benefits + ", NetPay = " + np + " where IntAgent = " + intRef + " ";
                string sresult1 = "";
                sresult1 = Utilities.DataBaseUtility.Execute(sInput, ident);

              if(!(sresult1 == "")){
                  MessageBox.Show("Employee Tax and Benefits have been successfully updated to the database.");
                  MessageBox.Show("Employee NetPay have been successfully updated to the database.");
              }
              else{

                  MessageBox.Show("Table not found. Check Database Connections.");
              }

            }
            catch(Exception ex)
            {

            }


        }


    }
}
