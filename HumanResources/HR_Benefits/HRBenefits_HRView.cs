using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRBenefits
{
    public partial class HRBenefits_HRView : HRBenefits.HRBenefits_Template
    {
        public HRBenefits_HRView()
        {
            InitializeComponent();
        }
        public HRBenefits_HRView(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HRBenefits.ViewRequests hrapp = new HRBenefits.ViewRequests(ident); hrapp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "select * from HR_Benefits_PlanTable";

            DataTable dt1 = Utilities.DataBaseUtility.GetTable(s);
            dataGridView1.DataSource = dt1;






        }

        private void button2_Click(object sender, EventArgs e)
        {

            String sqlstring = "INSERT into HR_Benefits (DocNum, DocType, ExtRef, IntRef, Status, DocRef, StartDate, EndDate, Salary, TotalBenefits, EmpName) VALUES (" + textBox2.Text + ", 71, 0,0,0,0,'" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "', '" + DateTime.Now.ToString("d") + "', " + textBox3.Text + ", 0, '" + textBox1.Text + "')";
            //label5.Text = sqlstring;
            Utilities.DataBaseUtility.Execute(sqlstring, ident);
            MessageBox.Show("Employee has been added successfully.");
            

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            string s1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string s2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string s3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string s4 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string s5 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string s6 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

           // MessageBox.Show(s1 + "\n" + s2);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
