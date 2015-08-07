using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class Training_Scheduling_Main : Training_Scheduling.Training_Scheduling_template
    {
        public Training_Scheduling_Main()
        {
            InitializeComponent();
           
            
        }
        public Training_Scheduling_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Training_Scheduling.EmployeeMain app = new Training_Scheduling.EmployeeMain();
            app.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Training_Scheduling.AdminMain app = new Training_Scheduling.AdminMain();
            app.Show();
        }


      
      
    }
}
