using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
  

    public partial class ViewCustomerDetails : Training_Scheduling.Training_Scheduling_template
    {
        public ViewCustomerDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // string TrainCust = "Select * from Training_Customer";
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox1.Text);
            dataGridView1.DataSource = dTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
