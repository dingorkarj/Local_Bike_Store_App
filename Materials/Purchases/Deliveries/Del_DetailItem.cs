using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Purchases
{
    class Del_DetailItem
    {
        #region Attributes

        private int _del_ID;
        private int  _productID;
        private int _quantity;
        private double _price;
  
        #endregion

        #region Constructors
        public Del_DetailItem()
        { }
       public Del_DetailItem(string record)
       {
           char delim = ',';
           if (record.IndexOf(delim) < 1) delim = '\t';
           string[] field = record.Split(delim );
           Del_ID = Int32.Parse(field[0]);
           ProductID = Int32.Parse(field[1]);
           Quantity = Int32.Parse(field[2]);
           Price = Double.Parse(field[3]);
       }

    //    public PurchaseOrder(int purchaseNbr)
    //   {
    ////       purchaseOrderNbr = purchaseNbr;
    //   }

        #endregion

        #region Properties

        public int Del_ID
        {
            get
            {
                return _del_ID;
            }
            set
            {
                _del_ID = value;
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

        #endregion

        #region Methods

        #endregion


    }
}
