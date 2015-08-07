using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class Instructor_Main : Training_Evaluation.Training_Evaluation_Template
    {
        public Instructor_Main()
        {
            InitializeComponent();
        }
        public Instructor_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Training_Evaluation.View_Trainee_Details app = new Training_Evaluation.View_Trainee_Details(ident);
            app.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Training_Evaluation.View_Trainee_Report app = new Training_Evaluation.View_Trainee_Report(ident);
            app.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Training_Evaluation.update_trainee_record app = new Training_Evaluation.update_trainee_record(ident);
            app.Show();
        }
    }
}
