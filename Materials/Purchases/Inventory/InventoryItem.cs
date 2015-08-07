using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Purchases
{
   public class InventoryItem
   {

   #region Attributes
   
       private int _productID;
       private int _supplier;
       private string _maker;
       private string _model;
       private int _minQuantity;
       private int _onHand;
       private double _cost;
     
   #endregion
      
   #region Constructors
       public InventoryItem(string record)
       {
           string[] field = record.Split(',')
                                    .Select(s => s.Trim())
                                    .Where(s => s != String.Empty)
                                    .ToArray();
           InvID = field[0];
           ProductID = Int32.Parse(field[0]);
           ProductName = field[10];
           Category = field[6];
           Supplier = Int32.Parse(field[2]);
           Year = double.Parse(field[7]);
           MaxQuantity = double.Parse(field[3]);
           MinQuantity = Int32.Parse(field[4]);
           OnHand = Double.Parse(field[5]);
           Price = Double.Parse(field[8]);
           Cost = Double.Parse(field[9]);
       }

   #endregion
       
   #region Properties

       public string InvID { get; set; }
       public string ProductName { get; set; }
       public double Price { get; set; }
       public double MaxQuantity { get; set; }

       public int doctype { get; set; }
       public int ProductID
       {
           get;
           set;
       }
       public string Category
       {
           get;
           set;
       }


       public double Year
       {
           get;
           set;
       }

       public int Supplier
       {
           get
           {
               return _supplier;
           }
           set
           {
               _supplier = value;
           }

       }

       public double MinQuantity
       {
           get;
           set;
       }

       public double OnHand
       {
           get;
           set;
       }

       public double Cost
       {
           get;
           set;
       }

       #endregion   
           
       #region Methods

       #endregion

   }
}
