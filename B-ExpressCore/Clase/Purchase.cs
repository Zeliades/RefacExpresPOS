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
using System.Net;
using System.Windows.Forms;

namespace Express.Clase
{
    internal class Purchase
    {
        public static void Preview__PurchaseDetails(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\compra_reporte.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "Purchase");
            rpt_Document.SetDataSource(my_DataSource);
            ParamCollection.Add(CrystalFieldValue.crpString);
            rpt_Document.ParameterFields["ShareDate"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpItemName);
            rpt_Document.ParameterFields["ITEM_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpQty);
            rpt_Document.ParameterFields["QTY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSuppName);
            rpt_Document.ParameterFields["SUPP_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustAddress);
            rpt_Document.ParameterFields["CUST_ADD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpWarehouse);
            rpt_Document.ParameterFields["WAREHOUSE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTotal);
            rpt_Document.ParameterFields["TOTAL"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDiscount);
            rpt_Document.ParameterFields["DISCOUNT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCashPay);
            rpt_Document.ParameterFields["CASH_PAY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCardPay);
            rpt_Document.ParameterFields["CARD_PAY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDue);
            rpt_Document.ParameterFields["DUE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpUom);
            rpt_Document.ParameterFields["UOM"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpInvNo);
            rpt_Document.ParameterFields["INV_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPurchase);
            rpt_Document.ParameterFields["PURCHASE"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

        public static void Preview__PurchaseReturn(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reports\\purchase_retrun.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "PurchaseReturn");
            rpt_Document.SetDataSource(my_DataSource);
            ParamCollection.Add(CrystalFieldValue.crpString);
            rpt_Document.ParameterFields["ShareDate"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpItemName);
            rpt_Document.ParameterFields["ITEM_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpQty);
            rpt_Document.ParameterFields["QTY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpUom);
            rpt_Document.ParameterFields["UOM"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPrice);
            rpt_Document.ParameterFields["PRICE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSuppName);
            rpt_Document.ParameterFields["SUPP_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustAddress);
            rpt_Document.ParameterFields["CUST_ADD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustPhone);
            rpt_Document.ParameterFields["CUST_PHN"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTotal);
            rpt_Document.ParameterFields["TOTAL"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCashPay);
            rpt_Document.ParameterFields["CASH_PAY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCardPay);
            rpt_Document.ParameterFields["CARD_PAY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDue);
            rpt_Document.ParameterFields["DUE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSoldBy);
            rpt_Document.ParameterFields["SOLD_BY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTime);
            rpt_Document.ParameterFields["TIME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpInvNo);
            rpt_Document.ParameterFields["INV_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPurchaseReturn);
            rpt_Document.ParameterFields["PurchaseReturn"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

        public static void Preview__Purchase(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\compra.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "Purchase");
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
            ParamCollection.Add(CrystalFieldValue.crpTotal);
            rpt_Document.ParameterFields["TOTAL"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPayment);
            rpt_Document.ParameterFields["PAYMENT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDue);
            rpt_Document.ParameterFields["DUE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCashPay);
            rpt_Document.ParameterFields["CASH"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCardPay);
            rpt_Document.ParameterFields["CARD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDiscount);
            rpt_Document.ParameterFields["DISCOUNT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpItemName);
            rpt_Document.ParameterFields["ITEM_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpQty);
            rpt_Document.ParameterFields["QTY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpUom);
            rpt_Document.ParameterFields["UOM"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpExprDate);
            rpt_Document.ParameterFields["EXP_DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpInvNo);
            rpt_Document.ParameterFields["INV_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSuppName);
            rpt_Document.ParameterFields["SUPP_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustAddress);
            rpt_Document.ParameterFields["SUPP_ADDRESS"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpWarehouse);
            rpt_Document.ParameterFields["TO_WAREHOUSE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPurchase);
            rpt_Document.ParameterFields["PUR_INV"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }


    }
}
