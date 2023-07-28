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
    internal class Expense
    {
        public static void Preview__ExpenseList(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\gasto_lista.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "Expenses");
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
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpExpenditure);
            rpt_Document.ParameterFields["Expenditure"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDescription);
            rpt_Document.ParameterFields["Description"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpAmount);
            rpt_Document.ParameterFields["Amount"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

    }
}
