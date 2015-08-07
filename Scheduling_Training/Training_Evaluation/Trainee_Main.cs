using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class Trainee_Main : Training_Evaluation.Training_Evaluation_Template
    {
        public Trainee_Main()
        {
            InitializeComponent();
        }

        public Trainee_Main( IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Training_Evaluation.view_customer_details app = new Training_Evaluation.view_customer_details(ident);
            app.Show()
;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Training_Evaluation.view_course_details app = new Training_Evaluation.view_course_details(ident);
            app.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Training_Evaluation.view_instructor_details app = new Training_Evaluation.view_instructor_details(ident);
            app.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Training_Evaluation.view_training_progress_and_report app = new Training_Evaluation.view_training_progress_and_report(ident);
            app.Show();
        }
    }
}
