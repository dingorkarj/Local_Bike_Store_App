using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Gross_Pay
    {
        int _docNum;

        public int DocNum
        {
            get { return _docNum; }
            set { _docNum = value; }
        }
        int _docType;

        public int DocType
        {
            get { return _docType; }
            set { _docType = value; }
        }
        int _emplId;

        public int EmplId
        {
            get { return _emplId; }
            set { _emplId = value; }
        }
        int _extRef;

        public int ExtRef
        {
            get { return _extRef; }
            set { _extRef = value; }
        }
        int _timeCardStatus;

        public int Status
        {
            get { return _timeCardStatus; }
            set { _timeCardStatus = value; }
        }
        int _docRef;

        public int DocRef
        {
            get { return _docRef; }
            set { _docRef = value; }
        }
        String _payStartDate;

        public String PayStartDate
        {
            get { return _payStartDate; }
            set { _payStartDate = value; }
        }
        String _payEndDate;

        public String PayEndDate
        {
            get { return _payEndDate; }
            set { _payEndDate = value; }
        }
        int _workHours;

        public int WorkHours
        {
            get { return _workHours; }
            set { _workHours = value; }
        }
        int _overTimeHours;

        public int OverTimeHours
        {
            get { return _overTimeHours; }
            set { _overTimeHours = value; }
        }
        double grossPay;

        public double GrossPay
        {
            get { return grossPay; }
            set { grossPay = value; }
        }
        string month;

        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }


        public Gross_Pay(double _record)
        {
            GrossPay = grossPay;
        }
        public Gross_Pay(string _record)
        {
            string[] _items = _record.Split(',');
            DocNum = Int32.Parse(_items[0]);
            DocType = Int32.Parse(_items[1]);
            EmplId = Int32.Parse(_items[2]);
            ExtRef = Int32.Parse(_items[3]);
            Status = Int32.Parse(_items[4]);
            DocRef = Int32.Parse(_items[5]);
            PayStartDate = _items[6];
            PayEndDate = _items[7];
            WorkHours = Int32.Parse(_items[8]);
            OverTimeHours = Int32.Parse(_items[9]);
            GrossPay = Convert.ToDouble(_items[10]);
            Month = _items[11];
            Comment = _items[12];
        }

   
    }
}
