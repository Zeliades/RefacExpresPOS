using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Express.Clase
{
    internal class DbHandler
    {
        public static string CnString = Properties.Settings.Default.App_Conn_string;
        public static DataTable sqlDT = new DataTable();
        public static DataTable sqlDT2 = new DataTable();
        public static string UserID;
        public static string UserName;
        public static string UsersPrivilege;

        // Initializing Database Connection
        public static bool DBConnectionInitializing()
        {
            bool functionReturnValue = false;
            try
            {
                SQLiteConnection sqlCon = new SQLiteConnection();
                sqlCon.ConnectionString = CnString;
                sqlCon.Open();
                functionReturnValue = true;
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                functionReturnValue = false;
                Properties.Settings.Default.App_Default_Conn = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Error : " + ex.Message, "Error establishing the database connection..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
            return functionReturnValue;
        }

        public static void GetCompanyDetails_ReportsParameters()
        {
            ExecuteSQLQuery(" SELECT * FROM BusinessInformation ");
            if (sqlDT.Rows.Count > 0)
            {
                CrystalFieldValue.crpCompanyName.Value = sqlDT.Rows[0]["CompanyName"].ToString();
                CrystalFieldValue.crpAddress.Value = sqlDT.Rows[0]["Address"].ToString();
                CrystalFieldValue.crpTelephone.Value = sqlDT.Rows[0]["PhoneNo"].ToString();
                CrystalFieldValue.crpEmail.Value = sqlDT.Rows[0]["Email"].ToString();
                CrystalFieldValue.crpWEB.Value = sqlDT.Rows[0]["WebSite"].ToString();
                CrystalFieldValue.crpSlogan.Value = sqlDT.Rows[0]["WebSite"].ToString();
            }
            else
            {
                CrystalFieldValue.crpCompanyName.Value = "Empresa";
                CrystalFieldValue.crpAddress.Value = "Domicilio";
                CrystalFieldValue.crpTelephone.Value = "Teléfono";
                CrystalFieldValue.crpEmail.Value = "Email";
                CrystalFieldValue.crpWEB.Value = "Web";
                CrystalFieldValue.crpSlogan.Value = "Slogan...";
            }
        }
        //Your Company Name
        public static DataTable ExecuteSQLQuery(string SQLQuery)
        {
            try
            {
                SQLiteConnection sqlCon = new SQLiteConnection(CnString);
                SQLiteDataAdapter sqlDA = new SQLiteDataAdapter(SQLQuery, sqlCon);
                SQLiteCommandBuilder sqlCB = new SQLiteCommandBuilder(sqlDA);
                sqlDT.Reset();
                sqlDA.Fill(sqlDT);
            }
            catch (Exception ex)
            {
                Properties.Settings.Default.App_Default_Conn = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDT;
        }


        public static DataTable ExecuteSQLQuery2(string SQLQuery)
        {
            try
            {
                SQLiteConnection sqlCon = new SQLiteConnection(CnString);
                SQLiteDataAdapter sqlDA = new SQLiteDataAdapter(SQLQuery, sqlCon);
                SQLiteCommandBuilder sqlCB = new SQLiteCommandBuilder(sqlDA);
                sqlDT2.Reset();
                sqlDA.Fill(sqlDT2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDT2;
        }


    }
}
