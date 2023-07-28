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
using System.Windows.Forms;

namespace Express.Clase
{
    internal class Item
    {
        public static void Preview__ListOfItem(string sql, CrystalReportViewer CrystalReportViewer)
        {
            Utility.ReportLanguegePack();
            DbHandler.GetCompanyDetails_ReportsParameters();
            ReportDocument rpt_Document = new ReportDocument();
            ParameterValues ParamCollection = new ParameterValues();
            rpt_Document.Load(Application.StartupPath + "\\Reportes\\articulo_lista.rpt");
            SQLiteConnection My_Connection = default(SQLiteConnection);
            SQLiteCommand my_Command = new SQLiteCommand();
            SQLiteDataAdapter my_DataAdapter = new SQLiteDataAdapter();
            dsExpress my_DataSource = new dsExpress();
            My_Connection = new SQLiteConnection(DbHandler.CnString);
            my_Command.CommandText = sql;
            my_Command.Connection = My_Connection;
            my_Command.CommandType = CommandType.Text;
            my_DataAdapter.SelectCommand = my_Command;
            my_DataAdapter.Fill(my_DataSource, "ItemDetails");
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
            ParamCollection.Add(CrystalFieldValue.crpWEB);
            rpt_Document.ParameterFields["WEB"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpID);
            rpt_Document.ParameterFields["ID"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpItemName);
            rpt_Document.ParameterFields["ITEM_NAME"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpUom);
            rpt_Document.ParameterFields["UOM"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpBatch);
            rpt_Document.ParameterFields["BATCH"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpBarcode);
            rpt_Document.ParameterFields["BARCODE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpCost);
            rpt_Document.ParameterFields["COST"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpPrice);
            rpt_Document.ParameterFields["PRICE"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpVAT);
            rpt_Document.ParameterFields["VAT"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpReorder);
            rpt_Document.ParameterFields["REORDER"].CurrentValues = ParamCollection;
            ParamCollection.Add(CrystalFieldValue.crpWarehouse);
            rpt_Document.ParameterFields["WAREHOUSE"].CurrentValues = ParamCollection;
            CrystalFieldValue.AppStartDirectory.Value = Application.StartupPath + @"\Upload\ItemImage\";
            ParamCollection.Add(CrystalFieldValue.AppStartDirectory);
            rpt_Document.ParameterFields["AppStartDirectory"].CurrentValues = ParamCollection;
            CrystalReportViewer.ReportSource = rpt_Document;
        }

    }
}
