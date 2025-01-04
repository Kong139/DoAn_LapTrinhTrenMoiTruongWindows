using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using StudentManagementApp.DAL.Repositories;
using StudentManagementApp.DAL;

namespace StudentManagementApp.BLL
{
    public class Utilities
    {
        private readonly StudentRepository studentRepository = new StudentRepository();

        public List<string> GetAllClasses()
        {
            // Sử dụng HashSet để loại bỏ các lớp trùng lặp
            HashSet<string> classes = new HashSet<string>();

            var students = studentRepository.GetAll();
            foreach (var student in students)
            {
                if (!string.IsNullOrEmpty(student.Class))
                {
                    classes.Add(student.Class);
                }
            }

            return classes.ToList();
        }

        // Method to export DataGridView to Excel
        public void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            // Create a new DataTable
            DataTable dt = new DataTable();

            // Add columns to DataTable
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            // Add rows to DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dataRow);
            }

            // Create a new workbook
            using (XLWorkbook wb = new XLWorkbook())
            {
                // Add DataTable as a worksheet
                wb.Worksheets.Add(dt, "Sheet1");

                // Save the workbook to the specified file path
                wb.SaveAs(filePath);
            }
        }

        public void BackupDatabase(string backupFilePath)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.BackupDatabase(backupFilePath);
        }

        public void RestoreDatabase(string backupFilePath)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.RestoreDatabase(backupFilePath);
        }
    }
}
