﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
//using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
namespace Utilities
{
    public class DataBaseUtility
    {
        static Char[] delim = { ',' };
        Char[] delim2 = { '\r', '\n' };

        /**********************************  Access Connection Code Begins  **************************************************************************************************************************************
         \***************/

       
        public static OleDbConnection GetConnectionObject()
        {
             String _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Frontend.accdb";
            //  String _connectionString = @"Provider=SQLOLEDB;Data Source=ISAM5635.db.10408957.hostedresource.com; Initial Catalog=ISAM5635; User ID= ISAM5635; Password=UhCL123#"; 

            OleDbConnection conn = new OleDbConnection(_connectionString);  //ConfigurationManager.AppSettings["ConnectionString"]);
            // conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AppData\Frontend.accdb";

            try
            {
                conn.Open();
                conn.Close();
                return conn;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();

            }
            return conn;
        }

        public static DataTable GetFullTable(string _fullTableName)
        {
           // delim = {','};
            DataTable dtable = new DataTable(_fullTableName);
            try
            {
                DataSet dset1 = new DataSet();
                OleDbConnection conn = GetConnectionObject();
                OleDbDataAdapter adapter1 = new OleDbDataAdapter("select * from " + _fullTableName , conn);
              //  try   {
                    adapter1.Fill(dset1);
                    dtable = dset1.Tables[0];
                    return dtable;
             }
            catch (Exception)
            {
                MessageBox.Show("Table not compatable");
                return dtable;
            }
        }
        public static DataTable  GetTable(string _query)
        {
            DataSet dset1 = new DataSet();
            DataTable dtable; // = new DataTable();
            OleDbConnection conn = GetConnectionObject();
            OleDbDataAdapter adapter1 = new OleDbDataAdapter(_query, conn);
            try
            {
                adapter1.Fill(dset1);
                dtable = dset1.Tables[0];
                return dtable;
            }
            catch
            {
              //  MessageBox.Show("can't find table for " + _query);
                return null;
            }
        }
        public static int GetNextNumber(string tableName, int _column, string oldTarget)
        {
            int nextNumber = -1;
            string target = "";
            if (oldTarget != "")
                try
                {
                    int lastnumber = Int32.Parse(oldTarget);
                    if (lastnumber > -1) return lastnumber + 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Non-numeric target in TextBox  : " + oldTarget);
                    return -1;
                }
            try
            {
                List<string> _list = GetList("select * from " + tableName);
                int lastrow = _list.Count - 1;
                string[] lastrowStr = _list[lastrow].Split(',');
                target = lastrowStr[_column];
                nextNumber = Int32.Parse(target) + 1;

                return nextNumber;
            }
            catch (Exception)
            {
                MessageBox.Show("Non-numeric target in table index  : " + target);
                return -1;
            }

        }
        public static int GetLastNumber(string tableName, int _column, int lowerBound, int upperbound)
        {
            int nextNumber = -1;
            string target = "";
            string oldTarget = "999";
            if (oldTarget != "")
                try
                {
                    int lastnumber = Int32.Parse(oldTarget);
                    if (lastnumber > -1) return lastnumber + 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Non-numeric target in TextBox  : " + oldTarget);
                    return -1;
                }
            try
            {
                List<string> _list = GetList("select * from " + tableName);
                int lastrow = _list.Count - 1;
                string[] lastrowStr = _list[lastrow].Split(delim );
                target = lastrowStr[_column];
                nextNumber = Int32.Parse(target) + 1;

                return nextNumber;
            }
            catch (Exception)
            {
                MessageBox.Show("Non-numeric target in table index  : " + target);
                return -1;
            }

        }

        public static List<string> GetList(string query, char delim)
        {
            List<string> list = new List<string>();
            string strrow = string.Empty;
            string strcolumn = string.Empty;

            OleDbConnection conn = GetConnectionObject();
            DataTable dtable = new DataTable();

            try
            {
                OleDbDataAdapter dr = new OleDbDataAdapter(query, conn);
                dr.Fill(dtable);

            
                foreach (DataColumn col in dtable.Columns)
                {
                    strcolumn = strcolumn + col.ColumnName.ToString() + "  " + delim ;
                }

                list.Add(strcolumn + Environment.NewLine);

                foreach (DataRow row in dtable.Rows)
                {
                    strrow = row[0].ToString();
                    for (int i = 1; i < dtable.Columns.Count; i++)
                    {
                        strrow = strrow + "  " + delim + row[i].ToString();
                    }
                    list.Add(strrow);
                }
                return list;
            }
            catch (Exception e)
            {
              //  MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
        public static List<string> GetDocumentData(string tablename,  int docType, int docNum)
        {
            List<string> _list = new List<string>();
            List<string> _detailList = new List<string>();
            try
            {
                string getListString = String.Format("select * from {0} where DocType = {1} and DocNum = {2}", tablename, docType, docNum);
                _list = GetList(getListString);
                if (_list.Count < 2) MessageBox.Show(" could not find GenDoc for : " + docType.ToString() + " , " + docNum.ToString());
                if (_list.Count > 2) MessageBox.Show(" multiple GenDocs for : " + docType.ToString() + " , " + docNum.ToString());
                //  list.Count = 2 (1 data record and 1 Names record)
                getListString = String.Format("select * from {0}_Details where DocType = {1} and DocNum = {2}", tablename.Trim(), docType, docNum);
                _detailList = GetList(getListString);
                for (int i = 1; i < _detailList.Count; i++)
                {
                    _list.Add(_detailList[i]);
                }

                return _list;
            }
            catch (Exception )
            { }
            return _list;
        }
        public static List<string> GetGenDocData(int docType, int docNum)
        {
           // string getListString = String.Format("select * from {0}  where DocType = {1} and DocNum = {2}", "GenDocs", docType, docNum);
            string tablename = "GenDocs";
            List<string> _list = GetDocumentData(tablename, docType, docNum);
            return _list;
        }

        public static List<string> GetDocumentData(string getListString)
        {
            List<string> _list = new List<string>();
            List<string> _detailList = new List<string>();
            try
            {
              //  string getListString = String.Format("select * from {0}  where DocType = {1} and DocNum = {2}", "GenDocs", docType, docNum);
                _list = GetList(getListString);
                if (_list.Count < 2) MessageBox.Show(" could not find GenDoc for : " + getListString); //docType.ToString() + " , " + docNum.ToString());
                if (_list.Count > 2) MessageBox.Show(" multiple GenDocs for : " + getListString);      //docType.ToString() + " , " + docNum.ToString());
                //  list.Count = 2 (1 data record and 1 Names record)
                //return _list;
                //getListString = String.Format("select * from DocumentDetails where DocType = {0} and DocNum = {1}", docType, docNum);
                //_detailList = GetList(getListString);
                //for (int i = 1; i < _detailList.Count; i++)
                //{
                //    _list.Add(_detailList[i]);
                //}

                return _list;
            }
            catch (Exception )
            { }
            return _list;
        }
     
        public static List<string> GetList(string query)
        {
           try{
               List<string> list = GetList(query, ',');
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
          
        }
        public static string GetCommonObject(string objectName, string objectID)
        {
            string objectString = "";
            string cmd = "select * from " + objectName;
            List<string> _records = GetList(cmd);
            if (_records.Count < 2)
            {
                MessageBox.Show("could not find table " + objectName);
                return objectString;
            }
            for (int i = 1; i < _records.Count; i++)
            {
                string[] fields = _records[i].Split(',');
                if (fields[0] == objectID)
                {
                    objectString = _records[i];
                }
            }
            return objectString;
        }

        public static string Execute(string _sqlCommand, IdentityObject ident)
        {
            string _message = "no errors";
            OleDbConnection conn;
            conn = GetConnectionObject();
            try
            {
                //if (ident.ActionLevel < 5)
                //{
                //    _message = "command requires a higher permission level than " + ident.ActionLevel + " by user : " + ident.UserName;
                //    //     return _message;
                //}
                OleDbCommand _command = new OleDbCommand(_sqlCommand, conn);
                conn.Open();
                int _count = _command.ExecuteNonQuery();
                if (_count < 1)
                {
                    _message = "could not execute  " + _sqlCommand;
                    return _message;
                }
                else return "no errors";
            }
            catch (Exception e)
            {
                return (e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
     
        public static int Execute( IdentityObject ident,string _sqlCommand)
        {
           // int retcode = 0;         //string _message = "no errors";
        
            OleDbConnection conn;
            conn = GetConnectionObject();
            try
            {
                //if (ident.ActionLevel < 5)
                //{
                //   // _message = "command requires a higher permission level than " + ident.ActionLevel + " by user : " + ident.UserName;
                //        return 5;
                //}
                OleDbCommand _command = new OleDbCommand(_sqlCommand, conn);
                conn.Open();
                int _count = _command.ExecuteNonQuery();
                if (_count < 1)
                {
                    return 1;  // _message = "could not execute  " + _sqlCommand;
                    
                }
                else return 0;  // "no errors";
            }
            catch (Exception )
            {
                return 2;  // (e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteDocument ( IdentityObject ident, string _tablename,string docNumStr, string docTypeStr)
        {
            OleDbConnection conn = GetConnectionObject();
            //if (ident.ActionLevel < 5)
            //{
            //    _message = "command requires a higher permission level than " + ident.ActionLevel + " by user : " + ident.UserName;
            //    //     return _message;
            //}

            try  {
                int docNum = Int32.Parse(docNumStr);
                int docType = Int32.Parse(docTypeStr);
                string cmdStr = String.Format("delete from {0} where DocNum = {1} and DocType = {2}", _tablename, docNum, docType); //where DocNum = {1}",/* and
                OleDbCommand cmd = new OleDbCommand(cmdStr, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
           
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Report: " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            try{
                int docNum = Int32.Parse(docNumStr);
                int docType = Int32.Parse(docTypeStr);
                string cmdStr2 = String.Format("delete from {0}_Details where DocNum = {1} and DocType = {2}", _tablename, docNum, docType); //where DocNum = {1}",/* and
                OleDbCommand cmd2 = new OleDbCommand(cmdStr2, conn);
                conn.Open();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception )
            {
                //   MessageBox.Show("Error Report: " + e.Message);
            }
            finally
            {
                conn.Close();
            }
          
        }
    
  }

}