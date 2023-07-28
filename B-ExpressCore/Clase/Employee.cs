using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Windows.Forms;

namespace Express.Clase
{
    internal class Employee
    {
        public static void Preview__EmployeePayment(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reports\\employee_payment.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "EmployeePayment");
            rpt_Document.SetDataSource(my_DataSource);
            ParamCollection.Add(CrystalFieldValue.crpString);
            rpt_Document.ParameterFields["ShareDate"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpID);
            rpt_Document.ParameterFields["ID"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDescription);
            rpt_Document.ParameterFields["Description"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDesignation);
            rpt_Document.ParameterFields["DESIGNATION"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpEmpName);
            rpt_Document.ParameterFields["EMP_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpAmount);
            rpt_Document.ParameterFields["Amount"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpEmpPayment);
            rpt_Document.ParameterFields["EMP_PAYMENT"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

        public static void Preview__EmployeeAttandance(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reports\\attendance.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "Attendance");
            rpt_Document.SetDataSource(my_DataSource);
            ParamCollection.Add(CrystalFieldValue.crpString);
            rpt_Document.ParameterFields["ShareDate"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpID);
            rpt_Document.ParameterFields["ID"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDesignation);
            rpt_Document.ParameterFields["DESIGNATION"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpEmpName);
            rpt_Document.ParameterFields["EMP_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpAttandance);
            rpt_Document.ParameterFields["Attandance"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPresent);
            rpt_Document.ParameterFields["Present"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpAbsent);
            rpt_Document.ParameterFields["Absent"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpRemarks);
            rpt_Document.ParameterFields["Remarks"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

        public static void Preview__EmployeeList(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\empleado_lista.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "Employee");
            rpt_Document.SetDataSource(my_DataSource);
            ParamCollection.Add(CrystalFieldValue.crpCompanyName);
            rpt_Document.ParameterFields["CompanyName"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpAddress);
            rpt_Document.ParameterFields["Address"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTelephone);
            rpt_Document.ParameterFields["Telephone"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpEmail);
            rpt_Document.ParameterFields["Email"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpWEB);
            rpt_Document.ParameterFields["WEB"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpID);
            rpt_Document.ParameterFields["ID"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpEmpName);
            rpt_Document.ParameterFields["EMP_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDesignation);
            rpt_Document.ParameterFields["DESIGNATION"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustAddress);
            rpt_Document.ParameterFields["CustAddress"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustPhone);
            rpt_Document.ParameterFields["CustPhone"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpEmployeeList);
            rpt_Document.ParameterFields["EmployeeList"].CurrentValues = ParamCollection;
            CrystalFieldValue.AppStartDirectory.Value = Application.StartupPath + @"\Upload\Empleado\";
            ParamCollection.Add(CrystalFieldValue.AppStartDirectory);
            rpt_Document.ParameterFields["CrystalFieldValue.AppStartDirectory"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

    }
}
