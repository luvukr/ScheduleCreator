using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.OleDb;

namespace ScheduleCreator.Helpers
{
    public static class ExcelHelper
    {
        public static System.Data.DataTable GetExcel(string excelFilePath,string sheetName)
        {
            //string fullPathToExcel = "<Path to Excel file>"; //ie C:\Temp\YourExcel.xls
            string connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=yes'", excelFilePath);
            System.Data.DataTable dt = GetDataTable("SELECT * from ["+ sheetName+"$]", connString);
            return dt;

        }
        public static System.Data.DataTable GetDataTable(string sql, string connectionString)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using var conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbDataAdapter oleAdpt = new OleDbDataAdapter(sql, conn); //here we read data from sheet1  

            oleAdpt.Fill(dt);
            return dt;
        }
    }
}