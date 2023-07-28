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
    internal class Bill
    {
        public static void Preview__TaxInvoice(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reports\\tax_invoice.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "SalesInvoice");
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
            ParamCollection.Add(CrystalFieldValue.crpInvNo);
            rpt_Document.ParameterFields["INV_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTime);
            rpt_Document.ParameterFields["TIME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDiscount);
            rpt_Document.ParameterFields["DISCOUNT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTotal);
            rpt_Document.ParameterFields["TOTAL"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCashPay);
            rpt_Document.ParameterFields["CASH"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCardPay);
            rpt_Document.ParameterFields["CARD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDue);
            rpt_Document.ParameterFields["DUE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpItemName);
            rpt_Document.ParameterFields["ITEM_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpQty);
            rpt_Document.ParameterFields["QTY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpUom);
            rpt_Document.ParameterFields["UOM"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpExprDate);
            rpt_Document.ParameterFields["EXPR_DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTermCond);
            rpt_Document.ParameterFields["TERM_COND"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTerm1);
            rpt_Document.ParameterFields["TERM_1"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTerm2);
            rpt_Document.ParameterFields["TERM_2"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSoldBy);
            rpt_Document.ParameterFields["ENTRY_BY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSoldBy);
            rpt_Document.ParameterFields["SOLD_BY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpShipping);
            rpt_Document.ParameterFields["SHIP_ADD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpBilling);
            rpt_Document.ParameterFields["BILL_ADD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpComment);
            rpt_Document.ParameterFields["COMMENT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpAuthSigh);
            rpt_Document.ParameterFields["AUTH_SIGN"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpGrossAmount);
            rpt_Document.ParameterFields["GROSS_AMT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpUnit);
            rpt_Document.ParameterFields["UNIT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTotalPrice);
            rpt_Document.ParameterFields["TOTAL_PRICE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpUnitVat);
            rpt_Document.ParameterFields["UNIT_VAT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTotalVat);
            rpt_Document.ParameterFields["TOTAL_VAT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTaxInv);
            rpt_Document.ParameterFields["TAX_INV"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

        public static void Preview__SalesReceipt(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reports\\sales_receipt.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "SalesInvoice");
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
            ParamCollection.Add(CrystalFieldValue.crpSlogan);
            rpt_Document.ParameterFields["Slogan"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpInvNo);
            rpt_Document.ParameterFields["INV_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTime);
            rpt_Document.ParameterFields["TIME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSoldBy);
            rpt_Document.ParameterFields["SOLD_BY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpItemName);
            rpt_Document.ParameterFields["ITEM_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpRcpVat);
            rpt_Document.ParameterFields["VAT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTotal);
            rpt_Document.ParameterFields["TOTAL"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpGrossAmount);
            rpt_Document.ParameterFields["GROSS_AMT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDiscount);
            rpt_Document.ParameterFields["DISCOUNT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCashPay);
            rpt_Document.ParameterFields["CASH"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCardPay);
            rpt_Document.ParameterFields["CARD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDue);
            rpt_Document.ParameterFields["DUE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPayment);
            rpt_Document.ParameterFields["PAYMENT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpRcpNotice);
            rpt_Document.ParameterFields["Notice"].CurrentValues = ParamCollection;

            CrystalFieldValue.AppStartDirectory.Value = Application.StartupPath + @"\Upload\Empresa\BrandLogo.jpg";
            ParamCollection.Add(CrystalFieldValue.AppStartDirectory);
            rpt_Document.ParameterFields["AppStartDirectory"].CurrentValues = ParamCollection;
            //CrystalReportViewer.ReportSource = rpt_Document;
            rpt_Document.PrintToPrinter(1, false, 1, 1);
        }

        public static void Preview__Barcode(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reports\\barcode.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "Barcode");
            rpt_Document.SetDataSource(my_DataSource);
            ParamCollection.Add(CrystalFieldValue.crpPrice);
            rpt_Document.ParameterFields["Price"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

    }
}
