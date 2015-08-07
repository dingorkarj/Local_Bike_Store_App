using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Purchases
{
    class PurchaseOrder
    {
        #region Attributes

        private int _po_ID;
        private DateTime  _po_Date;
        private int  _employeeID;
        private int _purchaseOrderStatus;
        private int _supplierID;
        private DateTime  _deliveryDate;
        private string _comment;
      
        private List<PO_DetailItem>  //PurchaseOrderProductDetails> 
            _poDetails;
      
        #endregion

        #region Constructors
        public PurchaseOrder()
        { }
        public PurchaseOrder(string record)
        { 
            string[] fields = record.Split(',')
                                    .Select(s => s.Trim())
                                    .Where(s => s != String.Empty)
                                    .ToArray();;
           new PurchaseOrder(fields);
        }
        public PurchaseOrder(string[] field)
        {
            PO_ID = Int32.Parse(field[0]);
            PO_Date = DateTime.FromOADate(double.Parse( field[1]));
            EmployeeID = Int32.Parse(field[2]);
            PO_Status = Int32.Parse(field[3]);
            SupplierID = Int32.Parse(field[4]);
            DeliveryDate = DateTime.FromOADate(double.Parse(field[5]));
            Comment = field[6];
        }
        public PurchaseOrder(List<string[]> field)
        {
            int linecount = field.Count;
            _poDetails = new List<PO_DetailItem>();
            PO_ID = Int32.Parse(field[0][0]);
            PO_Date = DateTime.Now; // Parse(field[0][1]);
            EmployeeID = Int32.Parse(field[0][2]);
            PO_Status = Int32.Parse(field[0][3]);
            SupplierID = Int32.Parse(field[0][4]);
            DeliveryDate = DateTime.Now;  // Parse(field[0][5]);
            Comment = field[0][6];
            for (int i = 1; i < linecount; i++)
            {
                PO_DetailItem detailItem = new PO_DetailItem(field[i]);
                _poDetails.Add(detailItem);
            }
        }
        public PurchaseOrder(List<string> records)
        {
            int linecount = records.Count;
            _poDetails = new List<PO_DetailItem>();
            string[] field = records[0].Split(',');
            PO_ID = Int32.Parse(field[0]);
            PO_Date = DateTime.Now;  // Parse(field[1]);
            EmployeeID = Int32.Parse(field[2]);
            PO_Status = Int32.Parse(field[3]);
            SupplierID = Int32.Parse(field[4]);
            DeliveryDate = DateTime.Now;  // Parse(field[5]);
            Comment = field[6];
            for (int i = 1; i < linecount; i++)
            {
                string[] detailStrings = records[i].Split(',');
                PO_DetailItem detailItem = new PO_DetailItem(detailStrings );
                _poDetails.Add(detailItem);
            }
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

        public int PO_Status
        {
            get
            {
                return _purchaseOrderStatus;
            }
            set
            {
                _purchaseOrderStatus = value;
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

    


        

        public List<PO_DetailItem >    //PurchaseOrderProductDetails> 
            PO_Details
        {
            get
            {
                return _poDetails;
            }
            set
            {
                _poDetails = value;
            }
        }

 
       

        #endregion

        #region Methods


        public  PurchaseOrder  GetPurchaseOrder(int purchaseNbr)
        {
               PurchaseOrder myOrder = new PurchaseOrder();
               string poCmd = "Select * from PURCHASE_ORDERS WHERE DocNum = " + purchaseNbr.ToString();
               DataTable _table = Utilities.DataBaseUtility.GetTable(poCmd);
                      
                int nrows = _table.Rows.Count;
                if (nrows != 1) return myOrder;
       
                myOrder.PO_ID = Convert.ToInt32(_table.Rows[0][0]);
                myOrder.SupplierID = Convert.ToInt32(_table.Rows[0]["ExtRef"]);
                DateTime dt,dt1;
                if ((_table.Rows[0]["TextValue2"] != null) && DateTime.TryParse(_table.Rows[0]["TextValue2"].ToString(), out dt))
                    myOrder.PO_Date = dt;
                if ((_table.Rows[0]["TextValue1"] != null) && DateTime.TryParse(_table.Rows[0]["TextValue1"].ToString(), out dt1))
                    myOrder.DeliveryDate = dt1;
             //   myOrder.PurchaseQuotedPrice  = Convert.ToDouble(_table.Rows[0]["QuotedPrice"]);
                myOrder.PO_Status = Convert.ToInt32(_table.Rows[0]["status"]);
            
                return myOrder;
          }

        #endregion


    }
}
