using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Customer : Entity 
    {
        Customer():base()
        {  }
      public  Customer(string record):base(record)
        {
        }
        public  Customer(string[] _items)  : base (_items)             
        { }
            
        public int CustID
        {
            get   { return _entityID;  }
            set   { _entityID = value; }
        }

    
        public new  int EntityType
        {
            get { return 2; }
           set { _entityType = 2;  }
        }

  
       public override string ToString()
        {
 	        string entityStr = String.Format("{0} ,{1} ,'{2}' ,'{3}' ,'{4}' ,'{5}' ,'{6}' ,'{7}' ,'{8}' ,'{9}' ,'{10}' ,'{11}' ,'{12}' ,'{13}' ,'{14}' ,'{15}' ,'{16}'",
                                        EntityID,EntityType,Name,Name2,Address,Address2,
                                                                                   City,State,PostalCode,Country,Phone,Phone2,Email,NetAddress,Other,Other2,Other3);
            return base.ToString();
        }
    
    }  
}
