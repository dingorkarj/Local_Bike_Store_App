using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class EmployeeMain : Training_Scheduling.Training_Scheduling_template
    {
        public EmployeeMain()
        {
            InitializeComponent();
        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            Training_Scheduling.Calendar app = new Training_Scheduling.Calendar();
            app.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Training_Scheduling.ViewCustomerDetails app = new Training_Scheduling.ViewCustomerDetails();
            app.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           Training_Scheduling.ViewCourses app = new Training_Scheduling.ViewCourses();
           app.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Training_Scheduling.ViewScheduledClasses app = new Training_Scheduling.ViewScheduledClasses();
            app.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Training_Scheduling.ViewCustomerBookings app = new Training_Scheduling.ViewCustomerBookings();
            app.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Training_Scheduling.ClassRoster app = new Training_Scheduling.ClassRoster();
            app.Show();
        }

    }
}
