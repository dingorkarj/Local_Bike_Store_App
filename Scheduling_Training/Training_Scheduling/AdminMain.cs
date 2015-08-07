using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class AdminMain : Training_Scheduling.Training_Scheduling_template
    {
        public AdminMain()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Training_Scheduling.CustomerDetails app = new Training_Scheduling.CustomerDetails();
            app.Show();
        }
      
        private void Button2_Click_1(object sender, EventArgs e)
        {
            Training_Scheduling.CourseDetails app = new Training_Scheduling.CourseDetails();
            app.Show();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            Training_Scheduling.ScheduleClasses app = new Training_Scheduling.ScheduleClasses();
            app.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Training_Scheduling.Booking app = new Training_Scheduling.Booking();
            app.Show();
        }

    }
}
