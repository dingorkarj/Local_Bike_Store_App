using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRBenefits
{
    
    public partial class EmployeeView : HRBenefits.HRBenefits_Template
    {
        string userid;
        public EmployeeView()
        {
            InitializeComponent();
            
        }
        public EmployeeView(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            if (ident.Dept !=7)
            {
                userid = ident.UserID;
                //comboBox1.Items.Clear();
                //comboBox1.Items.Add(ident.UserID);
            }
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'frontendDataSet.HR_Benefits' table. You can move, or remove it, as needed.
            //this.hR_BenefitsTableAdapter.Fill(this.frontendDataSet.HR_Benefits);
           
               // for (int i = 101; i <= 112; i++)
                 //   comboBox1.Items.Add(i);

            //dataGridView2.Visible = false;
            List<String> ename = Utilities.DataBaseUtility.GetList("Select EmpName FROM HR_Benefits WHERE DocNum = " + userid);
            label4.Text = ename[1];

            DataTable dtable = Utilities.DataBaseUtility.GetTable("SELECT p.PlanID, p.Description, d.SubTotal FROM HR_Benefits_PlanTable p, HR_Benefits_Details d WHERE p.PlanID = d.PlanID AND d.DocNum = " + userid);
            dataGridView1.DataSource = dtable;

            DataTable dtable3 = Utilities.DataBaseUtility.GetTable("Select PlanID, Description FROM HR_Benefits_PlanTable");
            dataGridView3.DataSource = dtable3;

            List<String> ls = Utilities.DataBaseUtility.GetList("Select TotalBenefits FROM HR_Benefits WHERE DocNum = " + userid);
            label3.Text = ls[1];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        /*
            List<String> list=   Utilities.DataBaseUtility.GetList("select Type,Months,Percentage,Amount from HR_Benefits_Details where DocNum="+comboBox1.Text);
         for (int i = 1; i < list.Count; ++i)
         {
             MessageBox.Show(list[i]);
           

         }
         */
            
            //DataTable dtable2 = Utilities.DataBaseUtility.GetTable("Select TotalBenefits FROM HR_Benefits WHERE DocNum = " + comboBox1.Text);
            //dataGridView2.DataSource = dtable2;
            //dataGridView2.Visible = true;
            //label3.Text = Utilities.DataBaseUtility.Execute("Select EmpName FROM HR_Benefits", ident).ToString();
            //label3.Text = Utilities.DataBaseUtility.GetDocumentData("HR_Benefits", 71, 101)[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HRBenefits.SubmitRequest hrapp = new HRBenefits.SubmitRequest(ident); hrapp.Show();
        }

        private void button_ListObjects_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
