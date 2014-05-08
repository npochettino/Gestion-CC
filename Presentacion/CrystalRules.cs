using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace Presentacion
{
    public class CrystalRules
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.GestionCCConnectionString"].ConnectionString);


        public string _dbName;
        public string _serverName;
        public string _userID;
        public string _passWord;

        public string dataBase
        {
            get { return _dbName; }
            set { _dbName = value; }
        }

        public string serverName
        {
            get { return _serverName; }
            set { _serverName = value; }
        }

        public string userName
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string dataBasePassword
        {
            get { return _passWord; }
            set { _passWord = value; }
        }




        internal ReportDocument ApplyInfo(ReportDocument _oRpt)
        {
            dataBase = builder.InitialCatalog;
            serverName = builder.DataSource;
            userName = builder.UserID;
            dataBasePassword = builder.Password;

            Database oCRDb = _oRpt.Database;
            Tables oCRTables = oCRDb.Tables;
            //Table oCRTable = default(Table);
            TableLogOnInfo oCRTableLogonInfo = default(TableLogOnInfo);
            ConnectionInfo oCRConnectionInfo = new ConnectionInfo();

            oCRConnectionInfo.DatabaseName = _dbName;
            oCRConnectionInfo.ServerName = _serverName;
            oCRConnectionInfo.UserID = _userID;
            oCRConnectionInfo.Password = _passWord;

            foreach (Table oCRTable in oCRTables)
            {
                oCRTableLogonInfo = oCRTable.LogOnInfo;
                oCRTableLogonInfo.ConnectionInfo = oCRConnectionInfo;
                oCRTable.ApplyLogOnInfo(oCRTableLogonInfo);


            }

            return _oRpt;


        }





    }
}
