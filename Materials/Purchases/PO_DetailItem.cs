using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Purchases
{
    class PO_DetailItem
    {
        #region Attributes

        private int _po_ID;
        private int  _productID;
        private int _quantity;
        private double _price;
        string _commnet;
        #endregion

        #region Constructors
        public PO_DetailItem()
        { }
        public PO_DetailItem(string record)
        {
            char delim = ',';
            if (record.IndexOf(',') < 1) delim = '\t';
            string[] fields = record.Split(delim);
            new PO_DetailItem(fields);
        }
        public PO_DetailItem(string[] field)
       {
           PO_ID = Int32.Parse(field[0]);
           ProductID = Int32.Parse(field[1]);
           Quantity = Int32.Parse(field[2]);
           Price = Double.Parse(field[3]);
           Name = field[4];
           Comment = "Product No:" + ProductID + "(" + Name + ")";
       }

    //    public PurchaseOrder(int purchaseNbr)
    //   {
    ////       purchaseOrderNbr = purchaseNbr;
    //   }

        #endregion

        #region Properties

        public int PO_ID
        {
            get
            {
                return _po_ID;
            }
            set
            {
                _po_ID = value;
            }
        }

        public int ProductID
        {
            get
            {
                return _productID;
            }
            set
            {
                _productID = value;
            }
        }

        public string Name
        {
            get;
            set;
        }


        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

          public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

          public string Comment { get; set; }
        
        #endregion

        #region Methods

        #endregion


    }
}
