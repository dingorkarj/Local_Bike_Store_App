using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace HRBenefits
{
    public partial class SubmitRequest : HRBenefits.HRBenefits_Template
    {
        public SubmitRequest()
        {
            InitializeComponent();
        }
        public SubmitRequest(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitRequest_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Today.ToString("MM/dd/yyyy");
            /*
            DataTable dt = Utilities.DataBaseUtility.GetTable("SELECT ReqID FROM HR_Benefits_Requests");
            string[] arr = new string[dt.Rows.Count];
            string reqCount = arr.Last();
            textBox4.Text = reqCount + 1;
             */
            if (ident.Dept != 7)
            {
                //comboBox1.Items.Clear();
                textBox2.Text = ident.UserID;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String reqStatus = "Open";
            String sqlstring = "INSERT into HR_Benefits_Requests (ReqDate, EmpID, Message, ReqStatus) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + reqStatus + "')";
            
            Utilities.DataBaseUtility.Execute(sqlstring, ident);
            
            
            /*
            DataTable dt = Utilities.DataBaseUtility.GetTable("SELECT ReqID FROM HR_Benefits_Requests");
            string[] arr = new string[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                arr[i] = dt.Rows[i]["ReqID"].ToString();
            }
            string reqCount = arr.Last();
            reqCount += 1;
            */
            label6.Text = sqlstring;
            MessageBox.Show("Your request has been submitted.");
            textBox2.Text = textBox3.Text = String.Empty;
            //textBox1.Text = DateTime.Today.ToString("MM/dd/yyyy");
        }
    }
}
