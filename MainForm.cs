using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Collections.Generic;
using System.Data;

  public partial class MainForm : HAWK_Template_1 
  {
        Boolean authorized = true;  //  This will change when security is updated
       // public IdentityObject ident;
        string _password;
        public MainForm()
        {
            InitializeComponent();
            ident = new IdentityObject("000", "guest", "guest",0,0);
          
         }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           _password = textBox_Password.Text;
           if (_password.IndexOf(@"\") == 3)
           {
               string _userID = _password.Substring(0, 3);
               //  string _role = _password.Substring(4);
               List<string> _emplStr = Utilities.DataBaseUtility.GetList("select * from employees where emplID = " + _userID);
               Utilities.Employee _empl = new Utilities.Employee(_emplStr[1]);
               ident.UserID = _userID;
               ident.UserName = _empl.LastName;
               ident.Role = _empl.Role;
               ident.ActionLevel = _empl.AdmLevel;
               ident.Dept = _empl.DeptID;
               List<string> _dept = Utilities.DataBaseUtility.GetList("select * from departments");
               textBox_Dept.Text = _dept[_empl.DeptID + 1].Substring(2);
               textBox_Role.Text = _empl.Role;
               textBox_UserID.Text = _empl.LastName;
           }           
        }

       
        private void button_Materials_Click(object sender, EventArgs e)
        {
            {
                
               Materials.Materials_Main app2 = new Materials.Materials_Main(base.ident );   app2.ShowDialog();
              //  NewApplication.NewApplication_Main newapp = new NewApplication.NewApplication_Main(base.ident); newapp.Show();
            }
        }


         
   
        private void button_Marketing_Click(object sender, EventArgs e)
        {
           //  Marketing.Marketing_Main app4 = new Marketing.Marketing_Main (ident);    app4.ShowDialog();
          //  new SalesAndMarketing.SalesAndMarketing_Main(base.ident).Show();  // NewApplication.NewApplication_Main newapp = new NewApplication.NewApplication_Main(base.ident); newapp.Show();
            new SalesAndMarketing.SalesAndMarketingMain(base.ident).Show();
        }

        private void button_Payroll_Click(object sender, EventArgs e)
        {
            //   Purchases.PurchaseOrder_Main app2 = new Purchases.PurchaseOrder_Main(ident);     app2.ShowDialog();
            //NewApplication.NewApplication_Main newapp = new NewApplication.NewApplication_Main(base.ident); newapp.Show();
            Payroll.Payroll_Main app = new Payroll.Payroll_Main(base.ident); app.Show();
        }

        private void button_Utilities_Click(object sender, EventArgs e)
        {
            Infrastructure.Infrastructure_Main app4 = new Infrastructure.Infrastructure_Main(ident); 
            app4.Show();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    
        private void button_Login_Click(object sender, EventArgs e)
        {
            _password = textBox_Password.Text;
            if ((_password.IndexOf(@"\") == 3)
              ||(_password.IndexOf(@"/") == 3))
            {
                string _userID = _password.Substring(0, 3);
                string _role = _password.Substring(4);
                List<string> _emplStr = Utilities.DataBaseUtility.GetList("select * from employees where emplID = " + _userID);
                Utilities.Employee _empl = new Utilities.Employee(_emplStr[1]);
                ident.UserID = _userID;
                ident.UserName = _empl.LastName;
                ident.Role = _empl.Role;
                ident.ActionLevel = _empl.AdmLevel;
                ident.Dept = _empl.DeptID;
                List<string> _dept = Utilities.DataBaseUtility.GetList("select * from departments");
                textBox_Dept.Text = _dept[_empl.DeptID + 1].Substring(2);
                textBox_Role.Text = _empl.Role;
                textBox_UserID.Text = _empl.LastName;
                base.SaveIdent(ident);
                base.DisplayIdent(ident);

            }           
      
        }

        private void button_HR_Click(object sender, EventArgs e)
        {
            new HR.HR_Main(ident).Show();
          //  NewApplication.NewApplication_Main newapp = new NewApplication.NewApplication_Main(base.ident); newapp.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SearchDataSources_Click(object sender, EventArgs e)
        {
            Infrastructure.Search_Database app1 = new Infrastructure.Search_Database(ident); app1.Show();
  
        }

        private void button_ClientTraining_Click(object sender, EventArgs e)
        {
           // NewApplication.NewApplication_Main newapp = new NewApplication.NewApplication_Main(base.ident); newapp.Show();
            new Training.Training_Main(base.ident).Show();// ClientTraining.ClientTraining_Main(ident); app2.Show();
           // new Training_Evaluation.Training_Evaluation_Main(base.ident).Show();
        }

        private void button_Accounting_Click(object sender, EventArgs e)
        {
            new Accounting.Accounting_Main(base.ident).Show();
           // NewApplication.NewApplication_Main newapp = new NewApplication.NewApplication_Main(base.ident); newapp.Show();
           // AccountsReceivable.AccountsReceivable_Main app = new AccountsReceivable.AccountsReceivable_Main(ident); app.Show();
           //   Account_Payable.Account_Payable_Main app = new Account_Payable.Account_Payable_Main(ident);  app.Show();
        }

        private void button_Processes_Click(object sender, EventArgs e)
        {
            Infrastructure.Infrastructure_Main app1 = new Infrastructure.Infrastructure_Main(base.ident); app1.Show();
        }

    }
