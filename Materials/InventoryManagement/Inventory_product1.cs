using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Inventory_product1 : Inventory_New_Template
    {
        public Inventory_product1()
        {
            InitializeComponent();
        }
        
         public Inventory_product1(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }

         private void button1_Click(object sender, EventArgs e)
         {

             InventoryManagement.Inventory_product2 t7 = new InventoryManagement.Inventory_product2(ident);

             try { 
           if(productID.SelectedIndex.Equals(0))
             {
                 int totalSold = 0;
                 int totalQuant = 0;

                 int prod = 142;
                 String que = "select OnHand from Inventory where DocNum="+ prod +"";

              // String que2="select SUM(Quantity) from ProcessDocs_Details where DocNum="+prod+"";

                 String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

                 DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
                 DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
                 int rows = 0;
                 rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
              // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
              
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);
               

               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident,totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident,current);

             }
                 }
             catch(Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }


             try {
                 if (productID.SelectedIndex.Equals(1))
                 {
                     int totalSold = 0;
                     int totalQuant = 0;
                     int prod = 144;
                     String que = "select OnHand from Inventory where DocNum=" + prod + "";

                     String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

                     DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
                     DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
                     int rows = 0;
                     rows = dtable1.Rows.Count;
                     totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
                     //Inventory_product2 t2 = new Inventory_product2();
                     // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
                     totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


                     t7.totalQuantities(ident, totalQuant);
                     t7.Show();
                     t7.TotalSold(ident, totalSold);
                     t7.ProductID(ident, prod);
                     int current = (totalQuant - totalSold);
                     t7.CurrentTotal(ident, current);

                 }

           }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }


             try {
                 if (productID.SelectedIndex.Equals(2))
                 {
                     int totalSold = 0;
                     int totalQuant = 0;
                     int prod = 145;

                     String que = "select OnHand from Inventory where DocNum=" + prod + "";
                     String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
                     DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
                     DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
                     int rows = 0;
                     rows = dtable1.Rows.Count;
                     totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
                     //Inventory_product2 t2 = new Inventory_product2();
                     // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
                     totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


                     t7.totalQuantities(ident, totalQuant);
                     t7.Show();
                     t7.TotalSold(ident, totalSold);
                     t7.ProductID(ident, prod);
                     int current = (totalQuant - totalSold);
                     t7.CurrentTotal(ident, current);

                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }


             try
             {

                 if (productID.SelectedIndex.Equals(3))
                 {

                     int prod = 148;
                     int totalSold = 0;
                     int totalQuant = 0;

                     String que = "select OnHand from Inventory where DocNum=" + prod + "";

                     String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

                     DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
                     DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
                     int rows = 0;
                     rows = dtable1.Rows.Count;
                     totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
                     //Inventory_product2 t2 = new Inventory_product2();
                     // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
                     totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


                     t7.totalQuantities(ident, totalQuant);
                     t7.Show();
                     t7.TotalSold(ident, totalSold);
                     t7.ProductID(ident, prod);
                     int current = (totalQuant - totalSold);
                     t7.CurrentTotal(ident, current);


                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try {


                 if (productID.SelectedIndex.Equals(4))
                 {

                     int prod = 153;
                     int totalSold = 0;
                     int totalQuant = 0;

                     String que = "select OnHand from Inventory where DocNum=" + prod + "";

                     String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

                     DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
                     DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
                     int rows = 0;
                     rows = dtable1.Rows.Count;
                     totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
                     //Inventory_product2 t2 = new Inventory_product2();
                     // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);

                     totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


                     t7.totalQuantities(ident, totalQuant);
                     t7.Show();
                     t7.TotalSold(ident, totalSold);
                     t7.ProductID(ident, prod);
                     int current = (totalQuant - totalSold);
                     t7.CurrentTotal(ident, current);
                 }

           }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try
             {


                 if (productID.SelectedIndex.Equals(5))
                 {

                     int prod = 186;
                     int totalSold = 0;
                     int totalQuant = 0;

                     String que = "select OnHand from Inventory where DocNum=" + prod + "";
                     String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
                     DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
                     DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
                     int rows = 0;
                     rows = dtable1.Rows.Count;
                     totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
                     //Inventory_product2 t2 = new Inventory_product2();
                     // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
                     totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


                     t7.totalQuantities(ident, totalQuant);
                     t7.Show();
                     t7.TotalSold(ident, totalSold);
                     t7.ProductID(ident, prod);
                     int current = (totalQuant - totalSold);
                     t7.CurrentTotal(ident, current);

                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
             
             if (productID.SelectedIndex.Equals(6))
           {
               int prod = 188;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";
               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
           if (productID.SelectedIndex.Equals(7))
           {

               int prod = 208;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);

           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
             if (productID.SelectedIndex.Equals(8))
           {

               int prod = 212;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);

           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
           if (productID.SelectedIndex.Equals(9))
           {

               int prod = 214;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);

           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 
           if (productID.SelectedIndex.Equals(10))
           {

               int prod = 216;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";
               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 

           if (productID.SelectedIndex.Equals(11))
           {

               int prod = 224;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 
           if (productID.SelectedIndex.Equals(12))
           {

               int prod = 225;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";
               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 
           if (productID.SelectedIndex.Equals(13))
           {

               int prod = 226;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 
           if (productID.SelectedIndex.Equals(14))
           {

               int prod = 244;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 
           if (productID.SelectedIndex.Equals(15))
           {

               int prod = 256;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 
           if (productID.SelectedIndex.Equals(16))
           {

               int prod = 258;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";
               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

           try {
               if (productID.SelectedIndex.Equals(17))
               {

                   int prod = 275;
                   int totalSold = 0;
                   int totalQuant = 0;

                   String que = "select OnHand from Inventory where DocNum=" + prod + "";

                   String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
                   DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
                   DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
                   int rows = 0;
                   rows = dtable1.Rows.Count;
                   totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
                   //Inventory_product2 t2 = new Inventory_product2();
                   // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
                   totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


                   t7.totalQuantities(ident, totalQuant);
                   t7.Show();
                   t7.TotalSold(ident, totalSold);
                   t7.ProductID(ident, prod);
                   int current = (totalQuant - totalSold);
                   t7.CurrentTotal(ident, current);
               }

           }

           catch (Exception ex)
           {
               MessageBox.Show("No Items Sold yet or no Items in Inventory");

           }

           try { 
             if (productID.SelectedIndex.Equals(18))
           {

               int prod = 278;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
           }
           catch (Exception ex)
           {
               MessageBox.Show("No Items Sold yet or no Items in Inventory");

           }
           try { 
           if (productID.SelectedIndex.Equals(19))
           {

               int prod = 280;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
           }
           catch (Exception ex)
           {
               MessageBox.Show("No Items Sold yet or no Items in Inventory");

           }
           try { 
           if (productID.SelectedIndex.Equals(20))
           {
               int prod = 288;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";
               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
           }
           catch (Exception ex)
           {
               MessageBox.Show("No Items Sold yet or no Items in Inventory");

           }
           try { 

           if (productID.SelectedIndex.Equals(21))
           {

               int prod = 291;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";
               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
           }
           catch (Exception ex)
           {
               MessageBox.Show("No Items Sold yet or no Items in Inventory");

           }

           try { 
           if (productID.SelectedIndex.Equals(22))
           {

               int prod = 295;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";
               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
           }
           catch (Exception ex)
           {
               MessageBox.Show("No Items Sold yet or no Items in Inventory");

           }

             try {
                 if (productID.SelectedIndex.Equals(23))
           {

               int prod = 301;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
           if (productID.SelectedIndex.Equals(24))
           {

               int prod = 302;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
           if (productID.SelectedIndex.Equals(25))
           {

               int prod = 303;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
           if (productID.SelectedIndex.Equals(26))
           {

               int prod = 304;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
           if (productID.SelectedIndex.Equals(27))
           {

               int prod = 311;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";
               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 
           if (productID.SelectedIndex.Equals(28))
           {

               int prod = 312;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);


           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
           if (productID.SelectedIndex.Equals(29))
           {

               int prod = 401;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
           if (productID.SelectedIndex.Equals(30))
           {

               int prod = 402;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 
           if (productID.SelectedIndex.Equals(31))
           {

               int prod = 403;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21"; ;

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 
           if (productID.SelectedIndex.Equals(32))
           {

               int prod = 404;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(33))
           {

               int prod = 405;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(34))
           {

               int prod = 406;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(35))
           {

               int prod = 407;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(36))
           {

               int prod = 408;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(37))
           {

               int prod = 409;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(38))
           {

               int prod = 411;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(39))
           {

               int prod = 412;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(40))
           {

               int prod = 413;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(41))
           {

               int prod = 414;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(42))
           {

               int prod = 415;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(43))
           {

               int prod = 416;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(44))
           {

               int prod = 417;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 

           if (productID.SelectedIndex.Equals(45))
           {

               int prod = 418;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21"; ;

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
             try { 

           if (productID.SelectedIndex.Equals(46))
           {

               int prod = 419;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(47))
           {

               int prod = 420;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";
               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(48))
           {

               int prod = 421;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(49))
           {

               int prod = 422;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }

             try { 


           if (productID.SelectedIndex.Equals(50))
           {

               int prod = 423;
               int totalSold = 0;
               int totalQuant = 0;

               String que = "select OnHand from Inventory where DocNum=" + prod + "";

               String que2 = "select SUM(Quantity) from ProcessDocs_Details where Index1=" + prod + " and DocType=21";

               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(que);
               DataTable dtable2 = Utilities.DataBaseUtility.GetTable(que2);
               int rows = 0;
               rows = dtable1.Rows.Count;
               totalQuant = Convert.ToInt32(dtable1.Rows[0]["OnHand"]);
               //Inventory_product2 t2 = new Inventory_product2();
               // InventoryManagement.Inventory_product2 t2 = new InventoryManagement.Inventory_product2(base.ident);
               totalSold = Convert.ToInt32(dtable2.Rows[0]["Expr1000"]);


               t7.totalQuantities(ident, totalQuant);
               t7.Show();
               t7.TotalSold(ident, totalSold);
               t7.ProductID(ident, prod);
               int current = (totalQuant - totalSold);
               t7.CurrentTotal(ident, current);



           }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No Items Sold yet or no Items in Inventory");

             }
           



         }

         private void productID_SelectedIndexChanged(object sender, EventArgs e)
         {

         }
       
    }
}
