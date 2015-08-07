using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Payroll;

namespace Payroll
{
    public partial class Create_Timecard : Payroll_Template
    {
        int totalHours = 0;
        int totalOtHours = 0;
        String emp_ID;
        IdentityObject obj;
        int Userid = 0;
        GenDoc gd;
        String format = "MM/dd/yyyy";
        // Payroll. pg;
        PayGrade pg;
        TimeCard tc;
        Gross_Pay gp;
        double grossPay = 0.0;
        DataTable dtProcessDoc = new DataTable();
        string prodoc_LastRow = "";

        string insert_Command = "";   //Insert String for insert commandsS
        string cmd_Part1 = ""; // Insert Part 1 string 
        string cmd_Part2 = "";// Insert Part 2 String
        int monValue = 0;
        int tueValue = 0;
        int wedValue = 0;
        int thuValue = 0;
        int friValue = 0;


        //Overtime Variables
        int satValue = 0;
        int sunValue = 0;
        int monOtValue = 0;
        int tueOtValue = 0;
        int wedOtValue = 0;
        int thuOtValue = 0;
        int friOtValue = 0;
        int satOtValue = 0;
        int sunOtValue = 0;

        public Create_Timecard(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
            String emp_Name = base.ident.UserName.Trim();
            emp_ID = base.ident.UserID.Trim();
            Userid = int.Parse(base.ident.UserID.Trim());
            // testidentity = base.ident.UserID;
            empName.Text = emp_Name;
            empId.Text = emp_ID;
            noOvertimeRadio.Checked = true;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.startDatePicker, "TimeCard must always start from Monday");
            if (noOvertimeRadio.Checked == true)
            {
                satTextBox.Enabled = false;
                sunTextBox.Enabled = false;
                satOtTextBox.Enabled = false;
                sunOtTextBox.Enabled = false;
                monOtTextBox.Enabled = false;
                tueOtTextBox.Enabled = false;
                wedOtTextBox.Enabled = false;
                thuOtTextBox.Enabled = false;
                friOtTextBox.Enabled = false;

            }
            startDatePicker.ValueChanged += new EventHandler(startDatePicker_ValueChanged);
            endDatePicker.ValueChanged += new EventHandler(startDatePicker_ValueChanged);
            noOvertimeRadio.CheckedChanged += new EventHandler(noOvertimeRadio_ValueChanged);
            after8Radiobtn.CheckedChanged += new EventHandler(after8Radiobtn_ValueChanged);
            after40Radiobtn.CheckedChanged += new EventHandler(after40Radiobtn_ValueChanged);

            monTextBox.TextChanged += new EventHandler(addTotalHours);
            tueTextBox.TextChanged += new EventHandler(addTotalHours);
            wedTextBox.TextChanged += new EventHandler(addTotalHours);
            thuTextBox.TextChanged += new EventHandler(addTotalHours);
            friTextBox.TextChanged += new EventHandler(addTotalHours);


            //Overtime text change events
            satTextBox.TextChanged += new EventHandler(addTotalHours);
            sunTextBox.TextChanged += new EventHandler(addTotalHours);

            monOtTextBox.TextChanged += new EventHandler(addTotalHours);
            tueOtTextBox.TextChanged += new EventHandler(addTotalHours);
            wedOtTextBox.TextChanged += new EventHandler(addTotalHours);
            thuOtTextBox.TextChanged += new EventHandler(addTotalHours);
            friOtTextBox.TextChanged += new EventHandler(addTotalHours);
            satOtTextBox.TextChanged += new EventHandler(addTotalHours);
            sunOtTextBox.TextChanged += new EventHandler(addTotalHours);


        }
        private void Create_Timecard_Load(object sender, EventArgs e)
        {
           
        }
        void noOvertimeRadio_ValueChanged(object sender, EventArgs e)
        {
            if (noOvertimeRadio.Checked == true)
            {
                satTextBox.Enabled = false;
                sunTextBox.Enabled = false;
                satOtTextBox.Enabled = false;
                sunOtTextBox.Enabled = false;
                monOtTextBox.Enabled = false;
                tueOtTextBox.Enabled = false;
                wedOtTextBox.Enabled = false;
                thuOtTextBox.Enabled = false;
                friOtTextBox.Enabled = false;
            }


        }
        void after8Radiobtn_ValueChanged(object sender, EventArgs e)
        {
            if (after8Radiobtn.Checked == true)
            {
                satTextBox.Enabled = false;
                sunTextBox.Enabled = false;
                satOtTextBox.Enabled = false;
                sunOtTextBox.Enabled = false;
                monOtTextBox.Enabled = true;
                tueOtTextBox.Enabled = true;
                wedOtTextBox.Enabled = true;
                thuOtTextBox.Enabled = true;
                friOtTextBox.Enabled = true;
            }
        }
        void after40Radiobtn_ValueChanged(object sender, EventArgs e)
        {
            if (after40Radiobtn.Checked == true)
            {
                satTextBox.Enabled = true;
                sunTextBox.Enabled = true;
                satOtTextBox.Enabled = true;
                sunOtTextBox.Enabled = true;
                monOtTextBox.Enabled = true;
                tueOtTextBox.Enabled = true;
                wedOtTextBox.Enabled = true;
                thuOtTextBox.Enabled = true;
                friOtTextBox.Enabled = true;
            }
        }

       

        void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDatePicker.Value = startDatePicker.Value.AddDays(6);

            if (startDatePicker.Value.DayOfWeek != DayOfWeek.Monday)
            {
                MessageBox.Show(" Start Date must be Monday");
               
            }
          

            textBox1.Text = Convert.ToString(startDatePicker.Value.ToString(format));
            textBox2.Text = Convert.ToString(startDatePicker.Value.AddDays(1).ToString(format));
            textBox3.Text = Convert.ToString(startDatePicker.Value.AddDays(2).ToString(format));
            textBox4.Text = Convert.ToString(startDatePicker.Value.AddDays(3).ToString(format));
            textBox5.Text = Convert.ToString(startDatePicker.Value.AddDays(4).ToString(format));
            textBox6.Text = Convert.ToString(startDatePicker.Value.AddDays(5).ToString(format));
            textBox7.Text = Convert.ToString(endDatePicker.Value.ToString(format));

        }

        void addTotalHours(object sender, EventArgs e)
        {
            button1.Enabled = true;
            int.TryParse(monTextBox.Text, out monValue);
                if (monValue > 8)
            {
                button1.Enabled = false;
                //  MessageBox.Show(monOtTextBox, "the value must be less than or equal 8", "Error");
                errorProvider1.SetError(monTextBox, "Please input hours less than or equal to 8");
                
            }
            else
            {
                errorProvider1.Clear();
                totalHours = monValue;
                totTextBox.Text = Convert.ToString(totalHours);
            }


            int.TryParse(tueTextBox.Text, out tueValue);
            if (tueValue > 8)
            {
                button1.Enabled = false;
                errorProvider2.SetError(tueTextBox, "Please input hours less than or equal to 8");
            }
               
            else
            {
                errorProvider2.Clear();
                totalHours += tueValue;
                totTextBox.Text = Convert.ToString(totalHours);
            }
            //Validating wed TextBox
            int.TryParse(wedTextBox.Text, out wedValue);
            if (wedValue > 8)
            {
                errorProvider3.SetError(wedTextBox, "Please input hours less than or equal to 8");
                button1.Enabled = false;

            }
            else
            {
                errorProvider3.Clear();
                totalHours += wedValue;
                totTextBox.Text = Convert.ToString(totalHours);
            }

            int.TryParse(thuTextBox.Text, out thuValue);
            if (thuValue > 8)
            {
                errorProvider4.SetError(thuTextBox, "Please input hours less than or equal to 8");
                button1.Enabled = false;

            }
            else
            {
                errorProvider4.Clear();
               
                totalHours += thuValue;
                totTextBox.Text = Convert.ToString(totalHours);
            }
            int.TryParse(friTextBox.Text, out friValue);
            if (friValue > 8)
            {
                button1.Enabled = false;
                errorProvider5.SetError(friTextBox, "Please input hours less than or equal to 8");
            }
            else
            {

               errorProvider5.Clear();
                totalHours += friValue;
                totTextBox.Text = Convert.ToString(totalHours);
            }


            if ((after8Radiobtn.Checked == true) || (after40Radiobtn.Checked == true))
            {
                int.TryParse(satTextBox.Text, out satValue);
                if (satValue > 8)
                {
                    button1.Enabled = false;
                    errorProvider6.SetError(satTextBox, "Please input hours less than or equal to 8");
                }

                else
                {
                    errorProvider6.Clear();
                    totalOtHours = satValue;
                    totOtTextBox.Text = Convert.ToString(totalOtHours);
                }

                int.TryParse(sunTextBox.Text, out sunValue);
                if (sunValue > 8)
                {
                    errorProvider7.SetError(sunTextBox, "Please input hours less than or equal to 8");
                    button1.Enabled = false;
                }
                else
                {
                    errorProvider7.Clear();
                    totalOtHours += sunValue;
                    totOtTextBox.Text = Convert.ToString(totalOtHours);
                }

                int.TryParse(monOtTextBox.Text, out monOtValue);
                if (monOtValue > 8)
                {
                    errorProvider8.SetError(monOtTextBox, "Please input hours less than or equal to 8");
                    button1.Enabled = false;
                }
                else
                {
                    errorProvider8.Clear();
                    totalOtHours += monOtValue;
                    totOtTextBox.Text = Convert.ToString(totalOtHours);
                }


                int.TryParse(tueOtTextBox.Text, out tueOtValue);
                if (tueOtValue > 8)
                {
                    button1.Enabled = false;
                    errorProvider9.SetError(tueOtTextBox, "Please input hours less than or equal to 8");
                }

                else
                {
                    errorProvider9.Clear();
                    totalOtHours += tueOtValue;
                    totOtTextBox.Text = Convert.ToString(totalOtHours);
                }

                int.TryParse(wedOtTextBox.Text, out wedOtValue);
                if (wedOtValue > 8)
                {
                    button1.Enabled = false;
                    errorProvider10.SetError(wedOtTextBox, "Please input hours less than or equal to 8");
                }
                else
                {
                    errorProvider10.Clear();
                    totalOtHours += wedOtValue;
                    totOtTextBox.Text = Convert.ToString(totalOtHours);
                }

                int.TryParse(thuOtTextBox.Text, out thuOtValue);
                if (thuOtValue > 8)
                {
                    errorProvider11.SetError(thuOtTextBox, "Please input hours less than or equal to 8");
                    button1.Enabled = false;
                }
                else
                {
                    errorProvider11.Clear();
                    totalOtHours += thuOtValue;
                    totOtTextBox.Text = Convert.ToString(totalOtHours);
                }

                int.TryParse(friOtTextBox.Text, out friOtValue);
                if (friOtValue > 8)
                {
                    button1.Enabled = false;
                    errorProvider12.SetError(friOtTextBox, "Please input hours less than or equal to 8");
                }
                else
                {
                    errorProvider12.Clear();
                    totalOtHours += friOtValue;
                    totOtTextBox.Text = Convert.ToString(totalOtHours);
                }


                int.TryParse(satOtTextBox.Text, out satOtValue);
                if (satOtValue > 8)
                {
                    button1.Enabled = false;
                    errorProvider13.SetError(satOtTextBox, "Please input hours less than or equal to 8");
                }
                else
                {
                    errorProvider13.Clear();
                    totalOtHours += satOtValue;
                    totOtTextBox.Text = Convert.ToString(totalOtHours);
                }

                int.TryParse(sunOtTextBox.Text, out sunOtValue);
                if (sunOtValue > 8)
                {
                    button1.Enabled = false;
                    errorProvider14.SetError(sunOtTextBox, "Please input hours less than or equal to 8");
                }
                else
                {
                    errorProvider14.Clear();
                   totalOtHours += sunOtValue;
                    totOtTextBox.Text = Convert.ToString(totalOtHours);
                }

            }
           
        }
        


        private void button1_Click(object sender, EventArgs e)

        {
            int totNormHrs =0 ;
            int.TryParse(totTextBox.Text, out totNormHrs);
            int totOtHrs = 0;
            int.TryParse(totTextBox.Text, out totOtHrs);
         
            if (totNormHrs > 40 || totOtHrs > 40)
            {
                MessageBox.Show("Invalid Number of hours Please enter correct Number of Hrs");
            }
            if (totTextBox.Text.Equals("0") || totTextBox.Text.Equals("") || startDatePicker.Value.DayOfWeek != DayOfWeek.Monday || endDatePicker.Value.DayOfWeek != DayOfWeek.Sunday)
            {
                
                MessageBox.Show("Please fill in the Time Sheet");
            }
            else if (MessageBox.Show("Are you sure to submit this time card", "Confirm Submit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataTable dtGrosscalc = new DataTable();
                String emp_ID = base.ident.UserID.Trim();
                int pg_hrly;
                int pg_sal;
                int pg_normRate;
                double pg_otRate;
                gd = new GenDoc();
                DataTable dtEmp = new DataTable();
                dtEmp = Utilities.DataBaseUtility.GetTable("Select * from emp_time_card ");
                string lastRow = Convert.ToString(dtEmp.Rows.Count);


                gd.DocNum = Utilities.DataBaseUtility.GetNextNumber("emp_time_card", 0, lastRow);

                List<string> _emplPayGrade = Utilities.DataBaseUtility.GetList("select * from emp_pay_grade where IntRef = " + empId.Text);
                Console.WriteLine("The employee ID isss" + _emplPayGrade[1]);
                PayGrade pg = new PayGrade(_emplPayGrade[1]);

                gd.DocType = 34;
                int emplID = pg.EmplId;
                pg.ExtRef = 0;
                pg.TimeCardStatus = 0;
                pg.DocRef = 0;

                if (_emplPayGrade[1] != null)
                {
                    tc = new TimeCard(textBox1.Text, textBox7.Text);

                    pg_hrly = pg.HourlyBasis;
                    pg_sal = pg.SalBasis;
                    pg_normRate = pg.PayRate;
                    pg_otRate = pg.OverTimeRate;

                    Console.WriteLine("The employee ID hrly" + pg_hrly);
                    Console.WriteLine("The employee ID sal" + pg_sal);
                    Console.WriteLine("The employee ID hrly" + pg_normRate);
                    Console.WriteLine("The employee ID sal" + pg.OverTimeRate);
                }

                string part1 = "INSERT into emp_time_card values (";
                string part2 = String.Format("{0}  ,{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,'{6}','{7}',{8},{9},{10},'{11}'",
                                       gd.DocNum, gd.DocType, pg.EmplId, pg.ExtRef, pg.TimeCardStatus, pg.DocRef, tc.PayStartDate, tc.PayEndDate, totalHours, totalOtHours, 0, pg.Comment);
                //        0          1           2              3                4               5            6
                string insert_Command = part1 + part2 + ");";
                
                Console.WriteLine("The Time card insert in emp_time_card" + insert_Command);
                Console.WriteLine(insert_Command);
                Utilities.DataBaseUtility.Execute(insert_Command, obj);
                Console.WriteLine("Time card Insert was executed");

                dtProcessDoc = Utilities.DataBaseUtility.GetTable("Select * from ProcessDocs ");
                string prodoc_LastRow = Convert.ToString(dtProcessDoc.Rows.Count);
                gd.DocNum = Utilities.DataBaseUtility.GetNextNumber("ProcessDocs", 0, prodoc_LastRow);

                 part1 = "INSERT into ProcessDocs values (";
                 part2 = String.Format("{0}  ,{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,'{6}','{7}',{8},{9},'{10}'",
                                       gd.DocNum, gd.DocType, pg.EmplId, pg.ExtRef, pg.TimeCardStatus, pg.DocRef, tc.PayStartDate, tc.PayEndDate, totalHours, totalOtHours, pg.Comment);
                //        0          1           2              3                4               5            6
                 insert_Command = part1 + part2 + ");";
                

                Console.WriteLine("Time card insert in ProcessDocs" + insert_Command);
                Utilities.DataBaseUtility.Execute(insert_Command, obj);
                Console.WriteLine("Time card Insert in Process Docs was executed");


                // Calculating grosss pay if Gross Pay is for the same month time card
               
                int tempMonth = startDatePicker.Value.Month;
                int startDateMonth = startDatePicker.Value.Month;
                int endDateMonth = endDatePicker.Value.Month;
                if (startDateMonth == endDateMonth)
                {
                    if (noOvertimeRadio.Checked == true)
                    {
                        grossPay += totalHours * pg.PayRate;
                        Console.WriteLine("grossPay is" + grossPay);
                    }

                    if (after8Radiobtn.Checked == true)
                    {
                        grossPay += totalHours * pg.PayRate;
                        grossPay += totalOtHours * (pg.PayRate * pg.OverTimeRate);
                        Console.WriteLine("grossPay is" + grossPay);
                    }

                    if (after40Radiobtn.Checked == true)
                    {
                        grossPay = totalHours * pg.PayRate;
                        grossPay += totalOtHours * (pg.PayRate * pg.OverTimeRate);
                        Console.WriteLine("grossPay is" + grossPay);
                    }
                    Console.WriteLine("Start date month Value is " + startDatePicker.Value.Month);

                    Gross_Pay gp = new Gross_Pay(grossPay);
                    //same month  Time Card gross pay calc
                    gd.DocType = 33;
                    pg.ExtRef = 0;
                    gd.Status = 0;
                    gd.ExternalRef = 0;
                    tc = new TimeCard(textBox1.Text, textBox7.Text);
                    gp.GrossPay = grossPay;
                    gp.Month = Convert.ToString(startDatePicker.Value.Month);

                    dtGrosscalc = Utilities.DataBaseUtility.GetTable("Select * from emp_gross_calc");

                    string gpc_LastRow = Convert.ToString(dtGrosscalc.Rows.Count);
                    gd.DocNum = Utilities.DataBaseUtility.GetNextNumber("emp_gross_calc", 0, gpc_LastRow);

                    cmd_Part1 = "INSERT into emp_gross_calc values (";
                    cmd_Part2 = String.Format("{0},{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,'{6}','{7}',{8},{9},{10},'{11}','{12}'",
                                          gd.DocNum, gd.DocType, pg.EmplId, pg.ExtRef, gd.Status, gd.ExternalRef, tc.PayStartDate, tc.PayEndDate, totalHours, totalOtHours, gp.GrossPay, gp.Month, gp.Comment);
                    //        0          1           2              3                4               5            6
                    insert_Command = cmd_Part1 + cmd_Part2 + ");";

                    Utilities.DataBaseUtility.Execute(insert_Command, ident);
                    Console.WriteLine("gross pay Insert was executed with output " + insert_Command);
                    Console.WriteLine("gross pay Insert was executed");

                    //Insert of same month Gross pay in Process docs
                    dtProcessDoc = Utilities.DataBaseUtility.GetTable("Select * from ProcessDocs ");
                    prodoc_LastRow = Convert.ToString(dtProcessDoc.Rows.Count);
                    gd.DocNum = Utilities.DataBaseUtility.GetNextNumber("ProcessDocs", 0, prodoc_LastRow);

                    cmd_Part1 = "INSERT into ProcessDocs values (";
                    cmd_Part2 = String.Format("{0},{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,'{6}','{7}',{8},{9},'{10}'", gp.DocNum, gd.DocType, pg.EmplId, pg.ExtRef, gd.Status, gd.ExternalRef, tc.PayStartDate, tc.PayEndDate, gp.GrossPay, gp.Month, gp.Comment);
                    //        0          1           2              3      4               5            6                7            8          9             10
                    insert_Command = cmd_Part1 + cmd_Part2 + ");";
                    Utilities.DataBaseUtility.Execute(insert_Command, ident);


                    this.Close();

                }
                // End of Calculating grosss pay if Gross Pay is for the same month time card
             
                //Different months in one  Time Card calculation
                int firstPart = 0;
                int twoPart = 0;
                int firstPartOt = 0;
                int twoPartOt = 0;
                double firstPartGrossPay = 0.0;
                double secondPartGrossPay = 0.0;
                int year = startDatePicker.Value.Year;
                int month = startDatePicker.Value.Month;
                DateTime dt = new DateTime(year, month, System.DateTime.DaysInMonth(System.DateTime.Now.Year, month));
                Console.WriteLine("last date of month" + dt.ToString(format));
                string ld_date = Convert.ToString(dt.ToString(format));

                if (startDateMonth != endDateMonth)
                {
                    if (startDateMonth == startDatePicker.Value.Month)
                    {
                        firstPart = monValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            firstPartOt += monOtValue;
                        }
                    }

                    if (startDateMonth == startDatePicker.Value.AddDays(1).Month)
                    {
                        firstPart += tueValue;

                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            firstPartOt += tueOtValue;
                        }
                    }

                    if (startDateMonth == startDatePicker.Value.AddDays(2).Month)
                    {
                        firstPart += wedValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            firstPartOt += wedOtValue;
                        }
                    }
                    if (startDateMonth == startDatePicker.Value.AddDays(3).Month)
                    {
                        firstPart += thuValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            firstPartOt += thuOtValue;
                        }
                    }
                    if (startDateMonth == startDatePicker.Value.AddDays(4).Month)
                    {
                        firstPart += friValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            firstPartOt += friOtValue;
                        }
                    }
                    if (startDateMonth == startDatePicker.Value.AddDays(5).Month)
                    {
                        firstPartOt = satOtValue;
                        firstPart += satValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            firstPartOt += satOtValue;
                        }
                    }

                    if (noOvertimeRadio.Checked == true)
                    {
                        firstPartGrossPay += firstPart * pg.PayRate;
                        Console.WriteLine("The first part grossPay is" + firstPartGrossPay);
                    }

                    if (after8Radiobtn.Checked == true)
                    {
                        firstPartGrossPay += firstPart * pg.PayRate;
                        firstPartGrossPay += firstPartOt * (pg.PayRate * pg.OverTimeRate);
                        Console.WriteLine("The first part grossPay is" + firstPartGrossPay);
                    }

                    if (after40Radiobtn.Checked == true)
                    {
                        firstPartGrossPay = firstPart * pg.PayRate;
                        firstPartGrossPay += firstPartOt * (pg.PayRate * pg.OverTimeRate);
                        Console.WriteLine("The first part grossPay is" + grossPay);
                    }

                    Gross_Pay gp = new Gross_Pay(firstPartGrossPay);

                    //Calculating number of rows
                    dtGrosscalc = Utilities.DataBaseUtility.GetTable("Select * from emp_gross_calc ");
                    string gpc_LastRow = Convert.ToString(dtGrosscalc.Rows.Count);
                    gd.DocNum = Utilities.DataBaseUtility.GetNextNumber("emp_gross_calc", 0, gpc_LastRow);

                    gd.DocType = 33;

                    pg.ExtRef = 0;
                    gd.Status = 0;
                    gd.ExternalRef = 0;

                    tc = new TimeCard(textBox1.Text, ld_date);

                    tc.PayEndDate = ld_date;
                    // Calcualate gross pay for the first part 
                    gp.GrossPay = firstPartGrossPay;
                    gp.Month = Convert.ToString(startDatePicker.Value.Month);


                    cmd_Part1 = "INSERT into emp_gross_calc values (";
                    cmd_Part2 = String.Format("{0},{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,'{6}','{7}',{8},{9},{10},'{11}','{12}'", gd.DocNum, gd.DocType, pg.EmplId, pg.ExtRef, gd.Status, gd.ExternalRef, tc.PayStartDate, tc.PayEndDate, firstPart, firstPartOt, gp.GrossPay, gp.Month, gp.Comment);
                    //        0          1           2      3           4               5            6
                    insert_Command = cmd_Part1 + cmd_Part2 + ");";
                    Utilities.DataBaseUtility.Execute(insert_Command, ident);

                    // Insert of First Part Gross Pay in Process docs

                    dtProcessDoc = Utilities.DataBaseUtility.GetTable("Select * from ProcessDocs ");
                    prodoc_LastRow = Convert.ToString(dtProcessDoc.Rows.Count);
                    gd.DocNum = Utilities.DataBaseUtility.GetNextNumber("ProcessDocs", 0, prodoc_LastRow);

                    cmd_Part1 = "INSERT into ProcessDocs values (";
                    cmd_Part2 = String.Format("{0},{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,'{6}','{7}',{8},{9},'{10}'", gp.DocNum, gd.DocType, pg.EmplId, pg.ExtRef, gd.Status, gd.ExternalRef, tc.PayStartDate, tc.PayEndDate, gp.GrossPay, gp.Month, gp.Comment);
                    //        0          1           2              3      4               5            6                7            8          9             10
                    insert_Command = cmd_Part1 + cmd_Part2 + ");";
                    Utilities.DataBaseUtility.Execute(insert_Command, ident);

                    Console.WriteLine("gross pay part 1 Insert was executed with output " + insert_Command);
                    Console.WriteLine("gross pay part 1 Insert was executed");


                    if (endDateMonth == startDatePicker.Value.AddDays(1).Month)
                    {
                        twoPart += tueValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            twoPartOt += tueOtValue;
                        }

                    }
                    if (endDateMonth == startDatePicker.Value.AddDays(2).Month)
                    {
                        twoPart += wedValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            twoPartOt += wedOtValue;
                        }

                    }
                    if (endDateMonth == startDatePicker.Value.AddDays(3).Month)
                    {
                        twoPart += thuValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            twoPartOt += thuOtValue;
                        }


                    }
                    if (endDateMonth == startDatePicker.Value.AddDays(4).Month)
                    {
                        twoPart += friValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            twoPartOt += friOtValue;
                        }


                    }
                    if (endDateMonth == startDatePicker.Value.AddDays(5).Month)
                    {
                        twoPartOt += satValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            twoPartOt += satOtValue;
                        }


                    }
                    if (endDateMonth == endDatePicker.Value.Month)
                    {
                        twoPartOt += sunValue;
                        if (after8Radiobtn.Checked == true || after40Radiobtn.Checked == true)
                        {
                            twoPartOt += sunOtValue;
                        }

                    }

                    Console.WriteLine("second part of normal hours" + twoPart);
                    Console.WriteLine("second part of over time hours " + twoPartOt);


                    if (noOvertimeRadio.Checked == true)
                    {
                        secondPartGrossPay += twoPart * pg.PayRate;
                        Console.WriteLine("grossPay for second part is" + secondPartGrossPay);
                    }

                    if (after8Radiobtn.Checked == true)
                    {
                        secondPartGrossPay += twoPart * pg.PayRate;
                        secondPartGrossPay += twoPartOt * (pg.PayRate * pg.OverTimeRate);
                        Console.WriteLine("grossPay for second partis" + secondPartGrossPay);
                    }

                    if (after40Radiobtn.Checked == true)
                    {
                        secondPartGrossPay = twoPart * pg.PayRate;
                        secondPartGrossPay += twoPartOt * (pg.PayRate * pg.OverTimeRate);
                        Console.WriteLine("grossPay for second part is" + grossPay);
                    }

                    int sd_year = startDatePicker.Value.Year;
                    int sd_month = endDatePicker.Value.Month;
                    DateTime sd = new DateTime(year, month, 1);
                    Console.WriteLine("start date of month" + sd.ToString(format));
                    string sd_date = sd.ToString(format);
                    tc = new TimeCard(sd_date, textBox7.Text);

                    tc.PayStartDate = sd.ToString(format);
                    gd.DocType = 33;


                    dtGrosscalc = Utilities.DataBaseUtility.GetTable("Select * from emp_gross_calc ");

                    string gpc_LastRow_2 = Convert.ToString(dtGrosscalc.Rows.Count);
                    gp.DocNum = Utilities.DataBaseUtility.GetNextNumber("emp_gross_calc", 0, gpc_LastRow_2);

                    // Calcualate gross pay for the second  part 
                    gp.GrossPay = secondPartGrossPay;
                    gp.Month = Convert.ToString(sd_month);

                    cmd_Part1 = "INSERT into emp_gross_calc values (";
                    cmd_Part2 = String.Format("{0},{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,'{6}','{7}',{8},{9},{10},'{11}','{12}'", gp.DocNum, gd.DocType, pg.EmplId, pg.ExtRef, gd.Status, gd.ExternalRef, tc.PayStartDate, tc.PayEndDate, firstPart, firstPartOt, gp.GrossPay, gp.Month, gp.Comment);
                    //        0          1           2              3                4               5            6
                    insert_Command = cmd_Part1 + cmd_Part2 + ");";

                    Utilities.DataBaseUtility.Execute(insert_Command, ident);
                    Console.WriteLine("gross pay part 2 Insert was executed with output " + insert_Command);
                    Console.WriteLine("gross pay part 2 Insert was executed");

                    // Insert of part 2 of Gross Pay in Process Docs
                    dtProcessDoc = Utilities.DataBaseUtility.GetTable("Select * from ProcessDocs ");
                    prodoc_LastRow = Convert.ToString(dtProcessDoc.Rows.Count);
                    gd.DocNum = Utilities.DataBaseUtility.GetNextNumber("ProcessDocs", 0, prodoc_LastRow);

                    cmd_Part1 = "INSERT into ProcessDocs values (";
                    cmd_Part2 = String.Format("{0},{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,'{6}','{7}',{8},{9},'{10}'", gp.DocNum, gd.DocType, pg.EmplId, pg.ExtRef, gd.Status, gd.ExternalRef, tc.PayStartDate, tc.PayEndDate, gp.GrossPay, gp.Month, gp.Comment);
                    //        0          1           2              3      4               5            6                7            8          9             10
                    insert_Command = cmd_Part1 + cmd_Part2 + ");";

                    Utilities.DataBaseUtility.Execute(insert_Command, ident);


                    this.Close();
                    //End of exception Time card

                }

                //Claculating Final Monthly Gross Pay

                DateTime fGp;
                if ((startDatePicker.Value.ToString(format).Equals(ld_date)))
                {
                    fGp = startDatePicker.Value;

                    CalculateFinalGrossPay(fGp);
                }

                if ((startDatePicker.Value.AddDays(1).ToString(format).Equals(ld_date)))
                {
                    fGp = startDatePicker.Value;

                    CalculateFinalGrossPay(fGp);
                }

                if ((startDatePicker.Value.AddDays(2).ToString(format).Equals(ld_date)))
                {
                    fGp = startDatePicker.Value;

                    CalculateFinalGrossPay(fGp);
                }

                if ((startDatePicker.Value.AddDays(3).ToString(format).Equals(ld_date)))
                {
                    fGp = startDatePicker.Value;

                    CalculateFinalGrossPay(fGp);
                }

                if ((startDatePicker.Value.AddDays(4).ToString(format).Equals(ld_date)))
                {
                    fGp = startDatePicker.Value;

                    CalculateFinalGrossPay(fGp);
                }

                if ((startDatePicker.Value.AddDays(5).ToString(format).Equals(ld_date)))
                {
                    fGp = startDatePicker.Value;

                    CalculateFinalGrossPay(fGp);
                }

                if ((startDatePicker.Value.AddDays(6).ToString(format).Equals(ld_date)))
                {
                    fGp = startDatePicker.Value;

                    CalculateFinalGrossPay(fGp);
                }



                this.Close();
            }

        }
        //  private void CalculateFinalGrossPay(object sender, EventArgs e)
        private void CalculateFinalGrossPay(DateTime month_date)
        {
            try{
            if (month_date != null)
            {
                int fgp_month = month_date.Month;
                GenDoc gd = new GenDoc();
                //     TimeCard tc = new TimeCard();
                DataTable dtGrossPay = new DataTable();
                dtGrossPay = Utilities.DataBaseUtility.GetTable("Select * from emp_gross_calc where IntRef=" + emp_ID + "and Month =" + fgp_month);
                double finGross = 0.0;

                for (int i = 0; i < dtGrossPay.Rows.Count; i++)
                {    // show Empl_ID : Firstname Lastname from Employees table
                    finGross += Convert.ToDouble(dtGrossPay.Rows[i][10]);
                    Console.WriteLine("The value of finGross" + i + "" + finGross);


                }
                Console.WriteLine("Displays the record for the emp_grossPay" + finGross);
                Gross_Pay gp = new Gross_Pay(finGross);

                gp.EmplId = Userid;
                //Calculating number of rows
                DataTable dtGrosscalc = new DataTable();
                dtGrosscalc = Utilities.DataBaseUtility.GetTable("Select * from emp_gross_pay ");
                string gpc_LastRow = Convert.ToString(dtGrosscalc.Rows.Count);
                gd.DocNum = Utilities.DataBaseUtility.GetNextNumber("emp_gross_pay", 0, gpc_LastRow);

                //{0}
                gd.DocType = 32;
                gd.Status = 0;
                gp.DocRef = 0;
                gp.ExtRef = 0;

                DateTime start_date = new DateTime(month_date.Year, month_date.Month, 1);
                string sd_date = start_date.ToString(format);

                DateTime end_date = new DateTime(month_date.Year, month_date.Month, System.DateTime.DaysInMonth(System.DateTime.Now.Year, month_date.Month));
                Console.WriteLine("last date of month for monthly gross pay " + end_date.ToString(format));
                string ld_date = Convert.ToString(end_date.ToString(format));
                TimeCard tc_date = new TimeCard(sd_date, ld_date);
                tc.PayStartDate = sd_date;
                tc.PayEndDate = ld_date;


                string gpPart1 = "INSERT into emp_gross_pay values (";
                string gpPart2 = String.Format("{0},{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,{6},'{7}','{8}','{9}'", gd.DocNum, gd.DocType, gp.EmplId, gp.ExtRef, gd.Status, gp.DocRef, finGross, tc.PayStartDate, tc.PayEndDate, gp.Comment);
                insert_Command = gpPart1 + gpPart2 + ");";
                Utilities.DataBaseUtility.Execute(insert_Command, ident);
                Console.WriteLine("gross pay in final GrossPay DocInsert was executed with output " + insert_Command);

                gd.ExternalRef = 0;
                //            DataTable dtProcessDoc = new DataTable();
                dtProcessDoc = Utilities.DataBaseUtility.GetTable("Select * from ProcessDocs ");
                prodoc_LastRow = Convert.ToString(dtProcessDoc.Rows.Count);
                gd.DocNum = Utilities.DataBaseUtility.GetNextNumber("ProcessDocs", 0, prodoc_LastRow);

                string pdPart1 = "INSERT into ProcessDocs values (";
                string pdPart2 = String.Format("{0},{1}  ,{2}  ,{3}  ,{4}  ,{5}  ,'{6}','{7}',{8},{9},'{10}'", gd.DocNum, gd.DocType, gp.EmplId, gd.ExternalRef, gd.Status, gd.ExternalRef, tc.PayStartDate, tc.PayEndDate, finGross,0, gp.Comment);
                insert_Command = pdPart1 + pdPart2 + ");";


                Utilities.DataBaseUtility.Execute(insert_Command, ident);
                Console.WriteLine("gross pay in Process DocInsert was executed with output " + insert_Command);
                Console.WriteLine("gross pay in processDoc was executed");

                Console.WriteLine(" fin value" + finGross);
            }
        }
            catch(NullReferenceException ne)
            {
                throw new InvalidOperationException("a message");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void totTextBox_TextChanged(object sender, EventArgs e)
        {
                      
        }

        private void button_DisplaySelectedObject_Click_1(object sender, EventArgs e)
        {

        }



    }


}

