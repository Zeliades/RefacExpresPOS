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
    internal class Sale
    {
        public static void Preview__BestProductSale(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\venta_mejor_item.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "BestProductSale");
            rpt_Document.SetDataSource(my_DataSource);
            ParamCollection.Add(CrystalFieldValue.crpString);
            rpt_Document.ParameterFields["ShareDate"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpID);
            rpt_Document.ParameterFields["ID"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpItemName);
            rpt_Document.ParameterFields["ITEM_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpQty);
            rpt_Document.ParameterFields["QTY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpUom);
            rpt_Document.ParameterFields["UOM"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpBarcode);
            rpt_Document.ParameterFields["BARCODE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpBestSale);
            rpt_Document.ParameterFields["BestSale"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

        public static void Preview__SaleDetails(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\venta_reporte.rpt");
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
            ParamCollection.Add(CrystalFieldValue.crpString);
            rpt_Document.ParameterFields["ShareDate"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpItemName);
            rpt_Document.ParameterFields["ITEM_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpQty);
            rpt_Document.ParameterFields["QTY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpUom);
            rpt_Document.ParameterFields["UOM"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCost);
            rpt_Document.ParameterFields["COST"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPrice);
            rpt_Document.ParameterFields["PRICE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpVAT);
            rpt_Document.ParameterFields["VAT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpExprDate);
            rpt_Document.ParameterFields["EXP_DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustName);
            rpt_Document.ParameterFields["CUST_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustAddress);
            rpt_Document.ParameterFields["CUST_ADD"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustPhone);
            rpt_Document.ParameterFields["CUST_PHN"].CurrentValues = ParamCollection;
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
            ParamCollection.Add(CrystalFieldValue.crpSoldBy);
            rpt_Document.ParameterFields["SOLD_BY"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpTime);
            rpt_Document.ParameterFields["TIME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpDate);
            rpt_Document.ParameterFields["DATE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpInvNo);
            rpt_Document.ParameterFields["INV_NO"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpProfit);
            rpt_Document.ParameterFields["PROFIT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSale);
            rpt_Document.ParameterFields["SALES"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

        public static void Preview__SalesReturn(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\venta_retorno.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "SalesReturn");
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
            ParamCollection.Add(CrystalFieldValue.crpVAT);
            rpt_Document.ParameterFields["VAT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCustName);
            rpt_Document.ParameterFields["CUST_NAME"].CurrentValues = ParamCollection;
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
            ParamCollection.Add(CrystalFieldValue.crpSaleReturn);
            rpt_Document.ParameterFields["SALES_RETURN"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpSale);
            CrystalReportViewer.ReportSource = rpt_Document;
        }

    }
}
