using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollDeductions
{
    public partial class GetGrossPay : PayrollDeductions.PayrollDeductions_Template
    {
        public GetGrossPay()
        {
            InitializeComponent();
        }

        public GetGrossPay(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string s = "";
            s = "select * from emp_gross_pay";
          

            DataTable dt1 = Utilities.DataBaseUtility.GetTable(s);
            dataGridView1.DataSource = dt1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string s1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string s2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string s3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string s4 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string s5 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string s6 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string s7 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

          
            double tax = 0.0;
            double benefit = 0.0;
            double gp = 0.0;
            int intRef = 0;
            intRef = Convert.ToInt32(s3);
            try
            {
                gp = Convert.ToInt32(s7);
                tax = 0.06 * gp;

                benefit = 0.04 * gp;


          
              //  Emp_Pay_TaxDeductions;

                double federalTax = 0.0;
                double medicare = 0.0;
                double ssn = 0.0;
                double totalTax=0.0;
                federalTax = 0.06 * gp;
                medicare = 0.04 * gp;
                ssn = 0.04 * gp;
                totalTax = federalTax+medicare+ssn;

          
                string updateEmp_Pay_TaxDeductions = "update Emp_Pay_TaxDeductions set FederalStateTax = "+federalTax+",Medicare="+medicare+",SocialSecurityTax="+ssn+",TotalTaxDeductions="+totalTax+" where IntAgent="+Convert.ToInt32(s3)+"";
                string sresult = "";
                sresult = Utilities.DataBaseUtility.Execute(updateEmp_Pay_TaxDeductions, ident);

                double retireFunds = 0.0;
                retireFunds = gp * 0.1;

                double healthInsurance = 0.0;
                healthInsurance = 0.05 * gp;

                double totalBenefits = 0.0;
                totalBenefits = retireFunds+healthInsurance;

                string updateEmp_Pay_Benefits = "update Emp_Pay_Benefits set Gross_Amount = " + gp + ",RetirementFunds=" + retireFunds + ",HealthInsurance=" + healthInsurance + ",TotalBenefits=" + totalBenefits + " where IntAgent=" + Convert.ToInt32(s3) + "";
                string sresult1 = "";
                sresult1 = Utilities.DataBaseUtility.Execute(updateEmp_Pay_Benefits, ident);


                NetGrossPay netPay = new NetGrossPay(ident);
                
                netPay.populateFields(ident, intRef,gp,totalTax,totalBenefits);
                netPay.Show();
            }
            catch(Exception ex)
            {

            }
            
        }


    }
}
