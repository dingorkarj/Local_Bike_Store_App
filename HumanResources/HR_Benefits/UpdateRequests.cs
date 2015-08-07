using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRBenefits
{
    public partial class UpdateRequests : HRBenefits.HRBenefits_Template
    {
        public UpdateRequests()
        {
            InitializeComponent();
        }

        public UpdateRequests(string reqID)
        {
            InitializeComponent();
            textBox1.Text = reqID;

            List<String> ls = Utilities.DataBaseUtility.GetList("Select * from HR_Benefits_Requests WHERE ID = " + textBox1.Text);

            string[] s = ls[1].Split(',');
            textBox2.Text = s[1];
            textBox3.Text = s[2];
            textBox6.Text = s[3];
            comboBox1.Text = s[4];
            textBox5.Text = s[5];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlupdate = "UPDATE HR_Benefits_Requests SET ReqStatus = '" + comboBox1.Text + "', AdminMsg = '" + textBox5.Text + "' WHERE ID = " + textBox1.Text;
            Utilities.DataBaseUtility.Execute(sqlupdate, ident);
            label8.Text = sqlupdate;
            MessageBox.Show("Update Successful");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
