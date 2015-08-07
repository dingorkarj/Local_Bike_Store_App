using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class TimeCard
    {
        #region Attributes

         int _docNum;
         int _docType;
         int _emplId;
         int _extRef;
         int _timeCardStatus;
         int _docRef;
         string _payStartDate;
         string _payEndDate;
         int _workHours;
         int _overTimeHours;
         string approval;
         string _comment;


        #endregion
         public TimeCard(string _StartDate, string _EndDate)
         {
             PayStartDate =_StartDate;
             PayEndDate = _EndDate;

         }

         public TimeCard(string _record)
       {
           string[] _items = _record.Split(',');
           DocNum = Int32.Parse(_items[0]);
           DocType = Int32.Parse(_items[1]);
           EmplId = Int32.Parse(_items[2]);
           ExtRef      = Int32.Parse(_items[3]);
           Status = Int32.Parse(_items[4]);
           DocRef = Int32.Parse(_items[5]);
           PayStartDate = _items[6];
           PayEndDate = _items[7];
           WorkHours = Int32.Parse(_items[8]);
           OverTimeHours = Int32.Parse(_items[9]);
           Appr = _items[10]; 
           Comment     = _items[11];
        
                 
         
         }

         public int DocNum
         {
             get
             {
                 return _docNum;
             }
             set
             {
                 _docNum = value;
             }
         }

         public int DocType
         {
             get
             {
                 return _docType;
             }
             set
             {
                 _docType = value;
             }
         }

          public int EmplId
         {
             get
             {
                 return _emplId;
             }
             set
             {
                 _emplId = value;
             }
         }
          public int ExtRef
         {
             get
             {
                 return _extRef;
             }
             set
             {
                 _extRef = value;
             }
         }
          public int Status
         {
             get
             {
                 return _timeCardStatus;
             }
             set
             {
                 _timeCardStatus = value;
             }
         }

          public int DocRef
         {
             get
             {
                 return _docRef;
             }
             set
             {
                 _docRef = value;
             }
         }

          public string PayStartDate
        {
            get
            {
                return _payStartDate;
            }
            set
            {
                _payStartDate = value;
            }
        }
          public string PayEndDate
        {
            get
            {
                return _payEndDate;
            }
            set
            {
                _payEndDate = value;
            }
        }

         public int WorkHours
         {
             get
             {
                 return _workHours;
             }
             set
             {
                 _workHours = value;
             }
         }
         public int OverTimeHours
         {
             get
             {
                 return _overTimeHours;
             }
             set
             {
                 _overTimeHours = value;
             }
         }
            
        public string Appr
        {
            get
            {
                return approval;
            }
            set 
            {
                approval = value;
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


    }
}
