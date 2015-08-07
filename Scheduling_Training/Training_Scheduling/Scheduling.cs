using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Scheduling
{
    class Scheduling
    {
         #region Attributes

        private int cust_id;
        private int course_id;
        private int session_id;
        private int booking_id;
        private int emp_id;
        private string custfname;
        private string custlname;
        private string email;
        private int phone;
        private string course_name;
        private string course_day;
        private double course_fees;
        private string coursestartdate;
        private string courseenddate;
        private int session_status;
        private int booking_status;    
        
        #endregion

        #region Constructors


        public Scheduling(string record)
        {
            string[] items = record.Split('\t');
            
            CustId = Int32.Parse(items[0]);
            CourseId = Int32.Parse(items[1]);
            SessionId = Int32.Parse(items[2]);
            BookingId = Int32.Parse(items[3]);
            EmpId = Int32.Parse(items[4]);
            Cust_fname = items[5];
            Cust_lname = items[6];
            Email_Id = items[7];
            Phone = Int32.Parse(items[8]);
            Course_Name = items[9];
            Course_Day = items[10];
            Course_fees = Convert.ToDouble(items[11]);
            Course_StartDate = items[12];
            Course_EndDate = items[13];
            Session_Status = Int32.Parse(items[14]);
            Booking_Status = Int32.Parse(items[15]);            
        }
        public Scheduling(int custid, int courseid, int sessionid, int bookingid, int empid,
            string custfname, string custlname, string emailid, int phone, string coursename, string courseday,
            double fees, string startdate, string enddate, int sessstatus, int bookstatus)
        {

            CustId = custid;
            CourseId = courseid;
            SessionId = sessionid;
            BookingId = bookingid;
            EmpId = empid;
            Cust_fname = custfname;
            Cust_lname = custlname;
            Email_Id = emailid;
            Phone = phone;
            Course_Name = coursename;
            Course_Day = courseday;
            Course_fees = fees;
            Course_StartDate = startdate;
            Course_EndDate = enddate;
            Session_Status = sessstatus;
            Booking_Status = bookstatus;
        }

        #endregion

        #region Properties

    
        public int CustId
        {
            get
            {
                return cust_id ;
            }
            set
            {
                cust_id  = value;
            }
        }
        public int CourseId
        {
            get
            {
                return course_id;
            }
            set
            {
                course_id = value;
            }
        }
   
        public int SessionId
        {
            get
            {
                return session_id;
            }
            set
            {
                session_id = value;
            }
        }
        public int BookingId
        {
            get
            {
                return booking_id;
            }
            set
            {
                booking_id = value;
            }
        }
        public int EmpId
        {
            get
            {
                return emp_id;
            }
            set
            {
                emp_id = value;
            }
        }
        public string Cust_fname
        {
            get
            {
                return custfname;
            }
            set
            {
                custfname = value;
            }
        }
        public string Cust_lname
        {
            get
            {
                return custlname;
            }
            set
            {
                custlname = value;
            }
        }
        public string Email_Id
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string Course_Name
        {
            get
            {
                return course_name;
            }
            set
            {
                course_name = value;
            }
        }
        public string Course_Day
        {
            get
            {
                return course_day;
            }
            set
            {
                course_day = value;
            }
        }
     
        public double Course_fees
        {
            get
            {
                return course_fees;
            }
            set
            {
                course_fees = value;
            }
        }

        public string Course_StartDate
        {
            get
            {
                return coursestartdate;
            }
            set
            {
                coursestartdate = value;
            }
        }
        public string Course_EndDate
        {
            get
            {
                return courseenddate;
            }
            set
            {
                courseenddate = value;
            }
        }        
        public int Booking_Status
        {
            get
            {
                return booking_status;
            }
            set
            {
                booking_status = value;
            }
        }
        public int Session_Status
        {
            get
            {
                return session_status;
            }
            set
            {
                session_status = value;
            }
        }
        
        #endregion

        #region Methods

        #endregion


    }
}
