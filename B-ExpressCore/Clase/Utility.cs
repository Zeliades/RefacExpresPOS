using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Xml;

namespace Express.Clase
{
    internal class Utility
    {
        public static void FillDataGrid(string sql, DataGridView dgv)
        {
            SQLiteConnection conn = new SQLiteConnection(DbHandler.CnString);
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter adp = new SQLiteDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = cmd;
                adp.Fill(dt);
                dgv.DataSource = dt;
                adp.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // FillCombo Box dynamically
        public static void FillComboBox(string sql, string Value_Member, string Display_Member, ComboBox combo)
        {
            DataTable dt = new DataTable();
            using (var connection = new SQLiteConnection(DbHandler.CnString))
            {
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(" Error : " + e.ToString());
                    }
                }
            }
            combo.DataSource = dt;
            combo.ValueMember = Value_Member;
            combo.DisplayMember = Display_Member;
        }

        public static double num_repl(string a)
        {
            double n;
            bool isNumeric = double.TryParse(a, out n);
            return n;
        }

        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static string GenarateAutoBarcode(string barcode)
        {
            double val = 0;
            DbHandler.ExecuteSQLQuery("SELECT * FROM Barcode");
            if (DbHandler.sqlDT.Rows.Count > 0)
            {
                barcode = DbHandler.sqlDT.Rows[0]["Barcode"].ToString();
                val = Int64.Parse(barcode) + 1;
                DbHandler.ExecuteSQLQuery("UPDATE  Barcode  SET  Barcode='" + val + "' ");
                barcode = val.ToString();
            }
            else
            {
                DbHandler.ExecuteSQLQuery("INSERT INTO Barcode (Barcode) VALUES ('1000000000') ");
                barcode = "1000000000";
            }
            return barcode;
        }

        public static void MesgBoxShow(string msg, string alertType)
        {
            MsgBox frmMsgBox = new MsgBox(msg, alertType);
            frmMsgBox.ShowDialog();
        }

        public static object fltr_combo(ComboBox cmbo)
        {
            if (cmbo.SelectedIndex == -1)
            {
                return 0;
            }
            return cmbo.SelectedValue;
        }

        public static void ReportLanguegePack()
        {
            if (Properties.Settings.Default.App_Default_Language)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(@"Language\" + Properties.Settings.Default.App_Language + ".xml");
                    XmlNodeList languageNodes = xmlDocument.GetElementsByTagName("language");
                    foreach (XmlNode languageNode in languageNodes)
                    {
                        XmlNode l1182 = languageNode["l1182"];
                        CrystalFieldValue.crpID.Value = l1182.InnerText;
                        XmlNode l1030 = languageNode["l1030"];
                        CrystalFieldValue.crpItemName.Value = l1030.InnerText;
                        XmlNode l1031 = languageNode["l1031"];
                        CrystalFieldValue.crpUom.Value = l1031.InnerText;
                        XmlNode l1032 = languageNode["l1032"];
                        CrystalFieldValue.crpBatch.Value = l1032.InnerText;
                        XmlNode l1034 = languageNode["l1034"];
                        CrystalFieldValue.crpBarcode.Value = l1034.InnerText;
                        XmlNode l1037 = languageNode["l1037"];
                        CrystalFieldValue.crpCost.Value = l1037.InnerText;
                        CrystalFieldValue.crpPurchaseCost.Value = l1037.InnerText;
                        XmlNode l1038 = languageNode["l1038"];
                        CrystalFieldValue.crpPrice.Value = l1038.InnerText;
                        XmlNode l1039 = languageNode["l1039"];
                        CrystalFieldValue.crpReorder.Value = l1039.InnerText;
                        XmlNode l1036 = languageNode["l1036"];
                        CrystalFieldValue.crpVAT.Value = l1036.InnerText;
                        XmlNode l1042 = languageNode["l1042"];
                        CrystalFieldValue.crpWarehouse.Value = l1042.InnerText;
                        XmlNode l1043 = languageNode["l1043"];
                        CrystalFieldValue.crpShelf.Value = l1043.InnerText;
                        XmlNode l1053 = languageNode["l1053"];
                        CrystalFieldValue.crpQty.Value = l1053.InnerText;
                        XmlNode l1055 = languageNode["l1055"];
                        CrystalFieldValue.crpStock.Value = l1055.InnerText;
                        XmlNode l1132 = languageNode["l1132"];
                        CrystalFieldValue.crpBestSale.Value = l1132.InnerText;
                        XmlNode l1046 = languageNode["l1046"];
                        CrystalFieldValue.crpExprDate.Value = l1046.InnerText;
                        XmlNode l1011 = languageNode["l1011"];
                        CrystalFieldValue.crpCustName.Value = l1011.InnerText;
                        XmlNode l1004 = languageNode["l1004"];
                        CrystalFieldValue.crpCustAddress.Value = l1004.InnerText;
                        XmlNode l1005 = languageNode["l1005"];
                        CrystalFieldValue.crpCustPhone.Value = l1005.InnerText;
                        XmlNode l1070 = languageNode["l1070"];
                        CrystalFieldValue.crpDiscount.Value = l1070.InnerText;
                        XmlNode l1073 = languageNode["l1073"];
                        CrystalFieldValue.crpCashPay.Value = l1073.InnerText;
                        XmlNode l1074 = languageNode["l1074"];
                        CrystalFieldValue.crpCardPay.Value = l1074.InnerText;
                        XmlNode l1076 = languageNode["l1076"];
                        CrystalFieldValue.crpDue.Value = l1076.InnerText;
                        XmlNode l1071 = languageNode["l1071"];
                        CrystalFieldValue.crpTotal.Value = l1071.InnerText;
                        XmlNode l1195 = languageNode["l1195"];
                        CrystalFieldValue.crpTime.Value = l1195.InnerText;
                        XmlNode l1097 = languageNode["l1097"];
                        CrystalFieldValue.crpSoldBy.Value = l1097.InnerText;
                        XmlNode l1065 = languageNode["l1065"];
                        CrystalFieldValue.crpDate.Value = l1065.InnerText;
                        XmlNode l1067 = languageNode["l1067"];
                        CrystalFieldValue.crpInvNo.Value = l1067.InnerText;
                        XmlNode l1196 = languageNode["l1196"];
                        CrystalFieldValue.crpProfit.Value = l1196.InnerText;
                        XmlNode l1127 = languageNode["l1127"];
                        CrystalFieldValue.crpSale.Value = l1127.InnerText;
                        XmlNode l1018 = languageNode["l1018"];
                        CrystalFieldValue.crpSuppName.Value = l1018.InnerText;
                        XmlNode l1086 = languageNode["l1086"];
                        CrystalFieldValue.crpPurchase.Value = l1086.InnerText;
                        XmlNode l1089 = languageNode["l1089"];
                        CrystalFieldValue.crpSaleReturn.Value = l1089.InnerText;
                        XmlNode l1092 = languageNode["l1092"];
                        CrystalFieldValue.crpPurchaseReturn.Value = l1092.InnerText;
                        XmlNode l1175 = languageNode["l1175"];
                        CrystalFieldValue.crpExpenditure.Value = l1175.InnerText;
                        XmlNode l1115 = languageNode["l1115"];
                        CrystalFieldValue.crpDescription.Value = l1115.InnerText;
                        XmlNode l1116 = languageNode["l1116"];
                        CrystalFieldValue.crpAmount.Value = l1116.InnerText;
                        XmlNode l1105 = languageNode["l1105"];
                        CrystalFieldValue.crpDesignation.Value = l1105.InnerText;
                        XmlNode l1104 = languageNode["l1104"];
                        CrystalFieldValue.crpEmpName.Value = l1104.InnerText;
                        XmlNode l1113 = languageNode["l1113"];
                        CrystalFieldValue.crpEmpPayment.Value = l1113.InnerText;
                        XmlNode l1110 = languageNode["l1110"];
                        CrystalFieldValue.crpPresent.Value = l1110.InnerText;
                        XmlNode l1111 = languageNode["l1111"];
                        CrystalFieldValue.crpAbsent.Value = l1111.InnerText;
                        XmlNode l1112 = languageNode["l1112"];
                        CrystalFieldValue.crpRemarks.Value = l1112.InnerText;
                        XmlNode l1106 = languageNode["l1106"];
                        CrystalFieldValue.crpAttandance.Value = l1106.InnerText;
                        XmlNode l1102 = languageNode["l1102"];
                        CrystalFieldValue.crpEmployeeList.Value = l1102.InnerText;
                        XmlNode l1094 = languageNode["l1094"];
                        CrystalFieldValue.crpColl.Value = l1094.InnerText;
                        XmlNode l1098 = languageNode["l1098"];
                        CrystalFieldValue.crpPayment.Value = l1098.InnerText;
                        XmlNode l1197 = languageNode["l1197"];
                        CrystalFieldValue.crpTermCond.Value = l1197.InnerText;
                        XmlNode l1198 = languageNode["l1198"];
                        CrystalFieldValue.crpTerm1.Value = l1198.InnerText;
                        XmlNode l1199 = languageNode["l1199"];
                        CrystalFieldValue.crpTerm2.Value = l1199.InnerText;
                        XmlNode l1204 = languageNode["l1204"];
                        CrystalFieldValue.crpGrossAmount.Value = l1204.InnerText;
                        XmlNode l1205 = languageNode["l1205"];
                        CrystalFieldValue.crpUnit.Value = l1205.InnerText;
                        XmlNode l1206 = languageNode["l1206"];
                        CrystalFieldValue.crpTotalPrice.Value = l1206.InnerText;
                        XmlNode l1207 = languageNode["l1207"];
                        CrystalFieldValue.crpUnitVat.Value = l1207.InnerText;
                        XmlNode l1208 = languageNode["l1208"];
                        CrystalFieldValue.crpTotalVat.Value = l1208.InnerText;
                        XmlNode l1200 = languageNode["l1200"];
                        CrystalFieldValue.crpShipping.Value = l1200.InnerText;
                        XmlNode l1201 = languageNode["l1201"];
                        CrystalFieldValue.crpBilling.Value = l1201.InnerText;
                        XmlNode l1202 = languageNode["l1202"];
                        CrystalFieldValue.crpAuthSigh.Value = l1202.InnerText;
                        XmlNode l1203 = languageNode["l1203"];
                        CrystalFieldValue.crpComment.Value = l1203.InnerText;
                        XmlNode l1209 = languageNode["l1209"];
                        CrystalFieldValue.crpTaxInv.Value = l1209.InnerText;
                        XmlNode l1069 = languageNode["l1069"];
                        CrystalFieldValue.crpRcpVat.Value = l1069.InnerText;
                        XmlNode l1210 = languageNode["l1210"];
                        CrystalFieldValue.crpRcpNotice.Value = l1210.InnerText;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CrystalFieldValue.crpID.Value = "ID #";
                CrystalFieldValue.crpItemName.Value = "ITEM NAME";
                CrystalFieldValue.crpUom.Value = "UOM";
                CrystalFieldValue.crpBatch.Value = "BATCH";
                CrystalFieldValue.crpBarcode.Value = "BARCODE";
                CrystalFieldValue.crpCost.Value = "COST";
                CrystalFieldValue.crpPrice.Value = "PRICE";
                CrystalFieldValue.crpReorder.Value = "ROP";
                CrystalFieldValue.crpVAT.Value = "VAT";
                CrystalFieldValue.crpWarehouse.Value = "WAREHOUSE";
                CrystalFieldValue.crpQty.Value = "QTY.";
                CrystalFieldValue.crpShelf.Value = "SHELF";
                CrystalFieldValue.crpShelf.Value = "STOCK";
                CrystalFieldValue.crpPurchaseCost.Value = "PURCHASE COST";
                CrystalFieldValue.crpBestSale.Value = "BEST PRODUCT SALE";
                CrystalFieldValue.crpExprDate.Value = "EXPR. DATE";
                CrystalFieldValue.crpCustName.Value = "CUSTOMER NAME";
                CrystalFieldValue.crpCustAddress.Value = "ADDRESS";
                CrystalFieldValue.crpCustPhone.Value = "PHONE NO";
                CrystalFieldValue.crpDiscount.Value = "DISCOUNT";
                CrystalFieldValue.crpCashPay.Value = "CASH";
                CrystalFieldValue.crpCardPay.Value = "CARD";
                CrystalFieldValue.crpDue.Value = "DUE";
                CrystalFieldValue.crpTotal.Value = "TOTAL";
                CrystalFieldValue.crpTime.Value = "TIME";
                CrystalFieldValue.crpInvNo.Value = "INV. NO";
                CrystalFieldValue.crpDate.Value = "DATE";
                CrystalFieldValue.crpSoldBy.Value = "BY";
                CrystalFieldValue.crpProfit.Value = "PROFIT";
                CrystalFieldValue.crpSale.Value = "SALES";
                CrystalFieldValue.crpSuppName.Value = "SUPP. NAME";
                CrystalFieldValue.crpPurchase.Value = "PURCHASE";
                CrystalFieldValue.crpSaleReturn.Value = "SALE RETURN";
                CrystalFieldValue.crpPurchaseReturn.Value = "PURCHASE RETURN";
                CrystalFieldValue.crpExpenditure.Value = "Expenditure Account";
                CrystalFieldValue.crpDescription.Value = "Description";
                CrystalFieldValue.crpAmount.Value = "AMOUNT";
                CrystalFieldValue.crpDesignation.Value = "Designation";
                CrystalFieldValue.crpEmpName.Value = "Employee Name";
                CrystalFieldValue.crpEmpPayment.Value = "Employee Payment";
                CrystalFieldValue.crpPresent.Value = "Present";
                CrystalFieldValue.crpAbsent.Value = "Absent";
                CrystalFieldValue.crpRemarks.Value = "Remarks";
                CrystalFieldValue.crpAttandance.Value = "Attendance";
                CrystalFieldValue.crpEmployeeList.Value = "EMPLOYEE LIST";
                CrystalFieldValue.crpColl.Value = "COLLECTION";
                CrystalFieldValue.crpPayment.Value = "PAYMENT";
                CrystalFieldValue.crpTermCond.Value = "TERMS  AND CONDITION";
                CrystalFieldValue.crpTerm1.Value = "All goods returned for replacement must be in salable condition with original packing.";
                CrystalFieldValue.crpTerm2.Value = "We are not responsible for any transit damage loss or leakage.";

                CrystalFieldValue.crpShipping.Value = "Shipping Address";
                CrystalFieldValue.crpBilling.Value = "Billing Address";
                CrystalFieldValue.crpAuthSigh.Value = "Authorized Signature";
                CrystalFieldValue.crpComment.Value = "COMMENTS";

                CrystalFieldValue.crpGrossAmount.Value = "GROSS PRICE";
                CrystalFieldValue.crpUnit.Value = "UNIT";
                CrystalFieldValue.crpTotalPrice.Value = "TOTAL PRICE";
                CrystalFieldValue.crpUnitVat.Value = "UNIT VAT";
                CrystalFieldValue.crpTotalVat.Value = "TOTAL VAT";
                CrystalFieldValue.crpTaxInv.Value = "TAX INVOICE";
                CrystalFieldValue.crpRcpVat.Value = "VAT";
                CrystalFieldValue.crpRcpNotice.Value = "GOODS ONCE SOLD CAN’T BE RETURNED OR EXCHANGE.";
                CrystalFieldValue.crpStock.Value = "STOCK";
            }
        }

    }
}
