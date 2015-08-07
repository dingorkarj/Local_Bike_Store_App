using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Utilities
{
    class Employee
    {
        #region Attributes

        private int _employeeID;
        private string  _firstName;
        private string  _lastName;
        string _role;
        int _deptID;
        int _admLevel;
        private string  _address;
        private string  _address2;
        private string  _city;
        private string  _state;
        private string  _zipCode;
        private string  _phone;
        private string  _email;

        #endregion

        #region Constructors

         public Employee(string _record)
       {
           string[] _items = _record.Split(',');
           EmployeeID = Int32.Parse(_items[0]);
           FirstName = _items[1];
           LastName  = _items[2];
           Role      = _items[3];
           DeptID = Int32.Parse(_items[4]);
           AdmLevel = Int32.Parse(_items[5]);
           Address = _items[6];
           Address2 = _items[7];
           City = _items[8];
           State = _items[9];
           ZipCode = _items[10]; 
           Phone     = _items[11];
           Email     = _items[12];
       }

        #endregion

        #region Properties

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

        
        public string  LastName
        {
            get
            {
                return  _lastName;
            }
            set
            {
                 _lastName = value;
            }
        }

        public string  FirstName
        {
            get
            {
                return  _firstName;
            }
            set
            {
                 _firstName = value;
            }
        }

        public string  WholeName
        {
            get
            {
                return  FirstName + " " +  LastName;
            }

        }

        public string  Address
        {
            get
            {
                return  _address;
            }
            set
            {
                 _address = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public string Address2
        {
            get
            {
                return _address2;
            }
            set
            {
                _address2 = value;
            }
        }


        public string ZipCode
        {
            get
            {
                return _zipCode;
            }
            set
            {
                _zipCode = value;
            }
        }

        public int DeptID
        {
            get
            {
                return _deptID;
            }
            set
            {
                _deptID = value;
            }
        }


        public int AdmLevel
        {
            get
            {
                return _admLevel;
            }
            set
            {
                _admLevel = value;
            }
        }

        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }

        public string  Email
        {
            get
            {
                return  _email;
            }
            set
            {
                 _email = value;
            }
        }

        public string  AddressFull
        {
            get
            {
                return  Address + " " +  Address2;
            }
           
        }

        public string  Phone
        {
            get
            {
                return  _phone;
            }
            set
            {
                 _phone = value;
            }
        }

 


           #endregion


    }
}
