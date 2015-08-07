using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Purchases
{
    class Delivery
    {
        #region Attributes

        private int _docNumber;
        private DateTime  _po_Date;
        private int  _employeeID;
        private int _status;
        private int _supplierID;
        private DateTime  _deliveryDate;
        private string _comment;
      
        private List<Del_DetailItem>  _deliveryDetails   ;
       
        //    _poProdDetails;
     //   private List<string>  //PurchaseOrderServiceDetails>      _poServDetails;
        

        #endregion

        #region Constructors
        public Delivery()
        { }
        public Delivery( string _records)
        {
            _records.Replace('\r', '\0');
            _deliveryDetails = new List<Del_DetailItem>();
            string[] record = _records.Split('\n');
            char delim = ',';
            if (record[0].IndexOf(delim) < 1) delim = '\t';
            string[] field = record[0].Split(delim);
            DocNumber = Int32.Parse(field[0]);
            //  double ord_Date = Double.Parse(field[1]);
            PO_Date = DateTime.Now;// .Parse( field[1]);
            EmployeeID = Int32.Parse(field[2]);
            Status = Int32.Parse(field[3]);
            SupplierID = Int32.Parse(field[4]);

            DeliveryDate = DateTime.Now;  //.Parse(field[5]); 
            Comment = field[6].Trim();
          
            for (int i = 1; i < record.Length; i++)
               if(record[i].Length > 3) _deliveryDetails.Add(new Del_DetailItem(record[i]));
        }
        public Delivery(List<string[]> field)
       {
         //  DocNumber = Int32.Parse(field[0]);
         ////  double ord_Date = Double.Parse(field[1]);
         //  PO_Date = DateTime.Now;// .Parse( field[1]);
         //  EmployeeID = Int32.Parse(field[2]);
         //  Status = Int32.Parse(field[3]);
         //  SupplierID = Int32.Parse(field[4]);
        
         //  DeliveryDate = DateTime.Now;  //.Parse(field[5]); 
         //  Comment = field[6].Trim();
     
       }

    //    public PurchaseOrder(int purchaseNbr)
    //   {
    ////       purchaseOrderNbr = purchaseNbr;
    //   }

        #endregion

        #region Properties

        //public int PO_ID
        //{
        //    get
        //    {
        //        return _po_ID;
        //    }
        //    set
        //    {
        //        _po_ID = value;
        //    }
        //}

        public int EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID = value;
            }
        }


        public int SupplierID
        {
            get
            {
                return _supplierID;
            }
            set
            {
                _supplierID = value;
            }
        }

        public DateTime  PO_Date
        {
            get
            {
                return _po_Date;
            }
            set
            {
                _po_Date = value;
            }
        }
     
        public DateTime  DeliveryDate
        {
            get
            {
                return _deliveryDate;
            }
            set
            {
                _deliveryDate = value;
            }
        }
        public int DocNumber
        {
            get
            {
                return _docNumber;
            }
            set
            {
                _docNumber = value;
            }
        }

        public string Comment
        {
            get
            {
                return _comment;
            }
            set 
            {
                _comment = value;
            }
        }

        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        //  public double AmountPaid
        //{
        //    get
        //    {
        //        return _amountPaid;
        //    }
        //    set
        //    {
        //        _amountPaid = value;
        //    }
        //}

    


        

        public List<Del_DetailItem >    DeliveryDetails 
           
        {
            get
            {
                return _deliveryDetails;
            }
            set
            {
                _deliveryDetails = value;
            }
        }

    
        #endregion

        #region Methods


        public  Delivery  GetDelivery(int docNbr)
        {
               Delivery myOrder = new Delivery();
               string _cmd = "Select * from " + PODConstants.DELIVERY_TABLE_NAME + " WHERE DocNum = " + docNbr.ToString() + " and DocType = 13"; ;
               DataTable _table = Utilities.DataBaseUtility.GetTable(_cmd);
                      
                int nrows = _table.Rows.Count;
                if (nrows != 1) return myOrder;
       
                myOrder.DocNumber = Convert.ToInt32(_table.Rows[0][0]);
                myOrder.SupplierID = Convert.ToInt32(_table.Rows[0]["ExtRef"]);
                myOrder.PO_Date = Convert.ToDateTime(_table.Rows[0]["TextValue2"]);
                myOrder.DeliveryDate = Convert.ToDateTime(_table.Rows[0]["TextValue1"]);
             //   myOrder.PurchaseQuotedPrice  = Convert.ToDouble(_table.Rows[0]["QuotedPrice"]);
                myOrder.Status = Convert.ToInt32(_table.Rows[0]["status"]);
                return myOrder;
          }

        #endregion


    }
}
