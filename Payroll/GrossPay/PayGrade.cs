using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class PayGrade
    {


        private int _docNum;

        public int DocNum
        {
            get { return _docNum; }
            set { _docNum = value; }
        }
        private int _docType;

        public int DocType
        {
            get { return _docType; }
            set { _docType = value; }
        }
        private int _emplId;

        public int EmplId
        {
            get { return _emplId; }
            set { _emplId = value; }
        }
        private int _extRef;

        public int ExtRef
        {
            get { return _extRef; }
            set { _extRef = value; }
        }
        private int _timeCardStatus;

        public int TimeCardStatus
        {
            get { return _timeCardStatus; }
            set { _timeCardStatus = value; }
        }
        private int _docRef;

        public int DocRef
        {
            get { return _docRef; }
            set { _docRef = value; }
        }
        private int _salBasis;

        public int SalBasis
        {
            get { return _salBasis; }
            set { _salBasis = value; }
        }
        private int _hourlyBasis;

        public int HourlyBasis
        {
            get { return _hourlyBasis; }
            set { _hourlyBasis = value; }
        }
        private int _payRate;

        public int PayRate
        {
            get { return _payRate; }
            set { _payRate = value; }
        }
        private double _overTimeRate;

        public double OverTimeRate
        {
            get { return _overTimeRate; }
            set { _overTimeRate = value; }
        }
        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
    

        public PayGrade(string _record)
        {
            string[] _items = _record.Split(',');
            DocNum = Int32.Parse(_items[0]);
            DocType = Int32.Parse(_items[1]);
            EmplId = Int32.Parse(_items[2]);
            ExtRef = Int32.Parse(_items[3]);
            TimeCardStatus = Int32.Parse(_items[4]);
            DocRef = Int32.Parse(_items[5]);
            SalBasis = Int32.Parse(_items[6]);
            HourlyBasis = Int32.Parse(_items[7]);
            PayRate = Int32.Parse(_items[8]);
            OverTimeRate = Convert.ToDouble(_items[9]);
            
            Comment = _items[10];



        }

    }

   




}
