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
using System.Windows.Forms;

namespace Express.Clase
{
    internal class Stock
    {
        public static void Preview__CurrentStock(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\existencias_actuales.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "StockDetails");
            rpt_Document.SetDataSource(my_DataSource);
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
            ParamCollection.Add(CrystalFieldValue.crpCost);
            rpt_Document.ParameterFields["COST"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPrice);
            rpt_Document.ParameterFields["PRICE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpShelf);
            rpt_Document.ParameterFields["SHELF"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpWarehouse);
            rpt_Document.ParameterFields["WAREHOUSE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpStock);
            rpt_Document.ParameterFields["STOCK"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPurchaseCost);
            rpt_Document.ParameterFields["PurchaseCost"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

    }
}
