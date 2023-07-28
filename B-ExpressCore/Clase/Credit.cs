using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Windows.Forms;

namespace Express.Clase
{
    internal class Credit
    {
        public static void Preview__Collection(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\coleccion.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "Collection");
            rpt_Document.SetDataSource(my_DataSource);
            ParamCollection.Add(CrystalFieldValue.crpString);
            rpt_Document.ParameterFields["ShareDate"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpID);
            rpt_Document.ParameterFields["ID"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpInvNo);
            rpt_Document.ParameterFields["INV_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustName);
            rpt_Document.ParameterFields["CUSTOMER_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustPhone);
            rpt_Document.ParameterFields["PHONE_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCashPay);
            rpt_Document.ParameterFields["CASH"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCardPay);
            rpt_Document.ParameterFields["CARD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpColl);
            rpt_Document.ParameterFields["COLLECTION"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

        public static void Preview__SupplierPayment(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reports\\payment.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "Payment");
            rpt_Document.SetDataSource(my_DataSource);
            ParamCollection.Add(CrystalFieldValue.crpString);
            rpt_Document.ParameterFields["ShareDate"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpID);
            rpt_Document.ParameterFields["ID"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpInvNo);
            rpt_Document.ParameterFields["INV_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSuppName);
            rpt_Document.ParameterFields["SUPP_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustPhone);
            rpt_Document.ParameterFields["PHONE_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCashPay);
            rpt_Document.ParameterFields["CASH"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCardPay);
            rpt_Document.ParameterFields["CARD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPayment);
            rpt_Document.ParameterFields["PAYMENT"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

    }
}
