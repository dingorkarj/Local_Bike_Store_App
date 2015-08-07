using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class view_training_progress_and_report : Training_Evaluation.Training_Evaluation_Template
    {
        List<string> _custname;
        public view_training_progress_and_report()
        {
            InitializeComponent();
        }

        public view_training_progress_and_report(IdentityObject ident)
        {
            InitializeComponent();
            
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 0;
            int z = 0;
           y= Convert.ToInt32(textBox1.Text);
           z = Convert.ToInt32(textBox2.Text);

          //  String s = "Select c.Course_Name,r.Training_Status from Training_Record r, Training_Course c where" + "+c.Course_id+ = +r.Course_id+";
         //   String s = "Select * from Training_Course  where Course_id =" + y;

          // String s = "Select * from Training_Record";
           //String s = "Select Course_Name,Training_Status from Training_Record r, Training_Course c where c.Course_id = r.Course_id";
           String s = "Select Course_Name,Training_Status from Training_Record r, Training_Course c where c.Course_id = r.Course_id and c.Course_id ="+ y +"and r.Trainee_id ="+z;
           DataTable dtable = Utilities.DataBaseUtility.GetTable(s);

         //  MessageBox.Show("fgdfgd" + dtable);

           if (dtable.Rows.Count == 0)
           { MessageBox.Show("You have not taken this course"); }
           else{

               dataGridView1.DataSource = dtable;
               dataGridView1.Visible = true;
            string t  = "Select Training_Status from Training_Record r, Training_Course c where c.Course_id = r.Course_id and c.Course_id =" + y;
            List<String> temp_trai_status = Utilities.DataBaseUtility.GetList(t);
            int r = Convert.ToInt32(temp_trai_status[1]);
            if (r == 100)
            {
                MessageBox.Show("pass");
            }
            else { MessageBox.Show("Under Progress"); }
           //_custname = Utilities.DataBaseUtility.GetList(s);
          
           }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
