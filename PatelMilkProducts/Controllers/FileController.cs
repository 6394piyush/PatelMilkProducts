using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mvc;
using PatelMilkProducts.Models;
using System.Data;
using System.Xml;

namespace PatelMilkProducts.Controllers
{   [Authorize(Roles="Admin")]
    public class FileController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(ImportExcel importExcel)
        {

            if (ModelState.IsValid)
            {
                EmpDBContext db = new EmpDBContext();
                bool flag=true;

                int pos = importExcel.file.FileName.LastIndexOf("\\");
                string fileName = importExcel.file.FileName.Substring(pos + 1);
                string dateFormat = "A" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day;
                String timeFormat = "A" + DateTime.Now.ToString("hhmmssfff");

                string path = Server.MapPath("~/Content/Upload/" + dateFormat + timeFormat + fileName);
                importExcel.file.SaveAs(path);

                string excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
                OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);

                //Sheet Name
                excelConnection.Open();
                string tableName = excelConnection.GetSchema("Tables").Rows[0]["TABLE_NAME"].ToString();
                excelConnection.Close();
                //End

                OleDbCommand cmd = new OleDbCommand("Select * from [" + tableName + "] where EmployeeId is NOT NULL", excelConnection);

                excelConnection.Open();

                OleDbDataReader dReader;
                dReader = cmd.ExecuteReader();
                while (dReader.Read())
                {
                    int eid = Int32.Parse(dReader.GetValue(0).ToString());
                    string sy = dReader.GetValue(35).ToString();
                    string sm = dReader.GetValue(36).ToString();
                    MilkEntryUpload meu = new MilkEntryUpload();
                    List<MilkEntryUpload> milkEntries = db.MilkEntryUploads.Where(e => e.EmployeesId == eid & e.SMonth == sm & e.SYear == sy).ToList();
                    if (milkEntries.Count != 0)
                    {
                        ViewBag.Result = "File Already Imported";
                        flag = false;
                        break;
                    }
                    
                }

                if(flag)
                {
                    SqlBulkCopy sqlBulk = new SqlBulkCopy(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);


                    //Destination table name
                    sqlBulk.DestinationTableName = "MilkEntryUploads";
                    //Mappings


                    sqlBulk.ColumnMappings.Add("EmployeeId", "EmployeesId");

                    sqlBulk.ColumnMappings.Add("_1", "_1");
                    sqlBulk.ColumnMappings.Add("_2", "_2");
                    sqlBulk.ColumnMappings.Add("_3", "_3");
                    sqlBulk.ColumnMappings.Add("_4", "_4");
                    sqlBulk.ColumnMappings.Add("_5", "_5");
                    sqlBulk.ColumnMappings.Add("_6", "_6");
                    sqlBulk.ColumnMappings.Add("_7", "_7");
                    sqlBulk.ColumnMappings.Add("_8", "_8");
                    sqlBulk.ColumnMappings.Add("_9", "_9");
                    sqlBulk.ColumnMappings.Add("_10", "_10");
                    sqlBulk.ColumnMappings.Add("_11", "_11");
                    sqlBulk.ColumnMappings.Add("_12", "_12");
                    sqlBulk.ColumnMappings.Add("_13", "_13");
                    sqlBulk.ColumnMappings.Add("_14", "_14");
                    sqlBulk.ColumnMappings.Add("_15", "_15");
                    sqlBulk.ColumnMappings.Add("_16", "_16");
                    sqlBulk.ColumnMappings.Add("_17", "_17");
                    sqlBulk.ColumnMappings.Add("_18", "_18");
                    sqlBulk.ColumnMappings.Add("_19", "_19");
                    sqlBulk.ColumnMappings.Add("_20", "_20");
                    sqlBulk.ColumnMappings.Add("_21", "_21");
                    sqlBulk.ColumnMappings.Add("_22", "_22");
                    sqlBulk.ColumnMappings.Add("_23", "_23");
                    sqlBulk.ColumnMappings.Add("_24", "_24");
                    sqlBulk.ColumnMappings.Add("_25", "_25");
                    sqlBulk.ColumnMappings.Add("_26", "_26");
                    sqlBulk.ColumnMappings.Add("_27", "_27");
                    sqlBulk.ColumnMappings.Add("_28", "_28");
                    sqlBulk.ColumnMappings.Add("_29", "_29");
                    sqlBulk.ColumnMappings.Add("_30", "_30");
                    sqlBulk.ColumnMappings.Add("_31", "_31");
                    sqlBulk.ColumnMappings.Add("Total", "TotalMilk");
                    sqlBulk.ColumnMappings.Add("Amount", "Amount");
                    sqlBulk.ColumnMappings.Add("Year", "SYear");
                    sqlBulk.ColumnMappings.Add("Month", "SMonth");



                    sqlBulk.WriteToServer(dReader);
                    excelConnection.Close();

                    ViewBag.Result = "Successfully Imported";
                }
            }         
               
            return View();
        }
    }
}