using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class CourseDetails : Training_Scheduling.Training_Scheduling_template
    {
        DataTable dtable1 = new DataTable();
        string courseid = string.Empty;
        string message = string.Empty;

        public CourseDetails()
        {
            InitializeComponent();
        }
        public CourseDetails(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
        }
        public void loaddata()
        {
            cmbcourseid.Items.Clear();
            cmbcourseid.SelectedIndex = -1;
            string sqlselect = "select * from Training_Course";
            dtable1 = Utilities.DataBaseUtility.GetTable(sqlselect);

            for (int i = 0; i < dtable1.Rows.Count; i++)
            {
                cmbcourseid.Items.Add(dtable1.Rows[i][0]);
            }
            cmbcourseid.Sorted = true ;
        }
       
        private void btnedit_Click(object sender, EventArgs e)
        {
            unlocktext();
        }

        public void locktext()
        {
            txtCourseName.ReadOnly = true;
            txtCourseDesc.ReadOnly = true;
            txtCourseDay.ReadOnly = true;
            txtFees.ReadOnly = true;
            
        }
        public void unlocktext()
        {
            txtCourseName.ReadOnly = false;
            txtCourseDesc.ReadOnly = false;
            txtCourseDay.ReadOnly = false;
            txtFees.ReadOnly = false;
            
        }
        public void cleartext()
        {
            txtCourseId.Visible = false;
            cmbcourseid.Visible = true;
            cmbcourseid.Text = string.Empty;
            txtCourseName.Text = string.Empty;
            txtCourseDesc.Text = string.Empty;
            txtCourseDay.Text = string.Empty;
            txtFees.Text = string.Empty;            
        }
       

        private void btnadd_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            cmbcourseid.Visible = false;
            Label4.Visible = true;
            txtCourseId.Visible = true;
            txtCourseId.Text = string.Empty;
            txtCourseName.Text = string.Empty;
            txtCourseDesc.Text = string.Empty;
            txtCourseDay.Text = string.Empty;
            txtFees.Text = string.Empty; 
            unlocktext();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbcourseid.Text != string.Empty)
            {
                string sqlstmt = "delete from Training_Course where Course_id=" + courseid;
                string message = Utilities.DataBaseUtility.Execute(sqlstmt, ident);
                string sqlinsert = "insert into Training_Course (Course_id, Course_Name, Course_Day, Course_fees, Course_desc) values ('" + txtCourseId.Text + "','" + txtCourseName.Text + "','" + txtCourseDay.Text + "','" + txtFees.Text + "','" + txtCourseDesc.Text + "')";
                message = Utilities.DataBaseUtility.Execute(sqlinsert, ident);
                if (sqlinsert != String.Empty)
                {
                    MessageBox.Show("Updated Successfully");
                    cleartext();

                }
                locktext();
            }
            else
            {
                MessageBox.Show("Select the course id to update");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (cmbcourseid.Text != string.Empty)
            {
                string sqlstmt = "delete from Training_Course where Course_id=" + courseid;
                message = Utilities.DataBaseUtility.Execute(sqlstmt, ident);
                if (sqlstmt != String.Empty)
                {
                    MessageBox.Show("Course has been Deleted Successfully");
                    cleartext();
                }
                loaddata();
            }
            else
            {
                MessageBox.Show("Select the course id to delete");
            }
        }

        private void CourseDetails_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void cmbcourseid_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseid = cmbcourseid.GetItemText(cmbcourseid.SelectedItem).ToString();
            dtable1 = Utilities.DataBaseUtility.GetTable("select * from Training_Course where Course_id=" + courseid);
            txtCourseName.Text = dtable1.Rows[0][6].ToString();
            txtCourseDesc.Text = dtable1.Rows[0][10].ToString();
            txtCourseDay.Text = dtable1.Rows[0][7].ToString();
            txtFees.Text = dtable1.Rows[0][8].ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into Training_Course (Course_id, Course_Name, Course_Day, Course_fees, Course_desc) values ('" + txtCourseId.Text + "','" + txtCourseName.Text + "','" + txtCourseDay.Text + "','" + txtFees.Text + "','" + txtCourseDesc.Text + "')";
            message = Utilities.DataBaseUtility.Execute(sqlinsert, ident);
            label2.Text = message;
            if (label2.Text  == "no errors")
            {
                MessageBox.Show("Course has been created successfully");
                cleartext();
                label3.Visible = true;
                cmbcourseid.Visible = true;
                cmbcourseid.Text = string.Empty;
                Label4.Visible = false;
                txtCourseId.Visible = false;
                loaddata();
                locktext();
            }            
            else
            {
                MessageBox.Show("Error: Could be one of the following reasons.\n1.Course Id you entered already exist (or)\n2.You didn't enter values in all the fields (or)\n3.Make sure you enter the course day from Monday - Friday");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartext();
        }

       

        
        
    }
}
