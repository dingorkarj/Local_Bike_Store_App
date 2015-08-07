using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class ViewCourses : Training_Scheduling.Training_Scheduling_template
    {
        public ViewCourses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox1.Text);
            dataGridView1.DataSource = dTable;
        }
    }
}
