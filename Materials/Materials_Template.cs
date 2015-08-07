using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Materials
{
    public partial class Materials_Template : HAWK_Template_2
    {
        public Materials_Template()
        {
            InitializeComponent();
        }
        //protected override void button_ListObjects_Click(object sender, EventArgs e)
        //{
        //    //  this.Close();
        //    //  ListObjects listObjs = new ListObjects(base.ident); listObjs.Show();

        //}
        //protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        //{
        //    // this.Close();
        //    //  DisplaySelectedObject dispObj = new DisplaySelectedObject(base.ident); dispObj.Show();

        //}

        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {

            //LowMaterials_List mylist = new LowMaterials_List(base.ident); mylist.Show();
        }
        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            //DisplaySelectedObject app = new DisplaySelectedObject(base.ident); app.Show();
        }


        
    }
}
