using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRBenefits
{
    public partial class ListObjects : HAWK_Template_3
    {
        public ListObjects()
        {
            InitializeComponent();
            comboBox_TableName.Items.Clear();
            comboBox_TableName.Items.Add("HR_Benefits");
            comboBox_TableName.Items.Add("HR_Benefits_Details");
        }
        public ListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            
          //  comboBox1.Text ="HR_Benefit_Main"
            comboBox_TableName.Items.Clear();
            comboBox_TableName.Items.Add("HR_Benefits");
            comboBox_TableName.Items.Add("HR_Benefits_Details");
           // comboBox1.Items.Add("HR_Benefits");
           // comboBox1.Items.Add("HR_Benefits");


        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dTable;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("It's Here");
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            DisplaySelectedObject pds = new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr);
            pds.Show();
        }
    }
}