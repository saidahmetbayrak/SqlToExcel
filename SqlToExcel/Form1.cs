using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.IO;

namespace SqlToExcel
{
    public partial class Form1 : Form
    {

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnect sql = new SqlConnect();
                sql.ServerName = txtServerName.Text;
                sql.UserName = txtLogin.Text;
                sql.Password = txtPass.Text;


                if (!string.IsNullOrEmpty(sql.ServerName) && !string.IsNullOrEmpty(sql.UserName) && !string.IsNullOrEmpty(sql.Password))
                {
                    cnn.ConnectionString = string.Format("Data Source={0}; User ID={1}; Password={2}", sql.ServerName, sql.UserName, sql.Password);

                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                        MessageBox.Show("Baglantı Başaralı");
                    }
                    else
                    {
                        MessageBox.Show("Baglantı Başarısız!!");
                    }

                    System.Data.DataTable table = cnn.GetSchema("databases");
                    foreach (DataRow item in table.Rows)
                    {
                        cmbDatabase.Items.Add(item.Field<string>("database_name"));
                    }
                }
                else
                {
                    MessageBox.Show("Baglantı Değerleri Bos Geçilemez!!");
                }
            }
            catch (Exception exp)
            {
                 MessageBox.Show(exp.Message);
            }
        }

        string selectDb ="";
        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        { 
           var result = cmbDatabase.SelectedItem;
            selectDb = result.ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            System.Data.DataTable table = new System.Data.DataTable();
            Application xlApp;
            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            string fileName = String.Empty;
            SaveFileDialog saveFileExcel = new SaveFileDialog();


            try
            {
                cmd = new SqlCommand("USE " + selectDb + " \n" + txtSorgu.Text, cnn);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);


                if (table != null && table.Rows.Count > 0)
                {

                    int checkSize = 100000;
                    double checkCountD = (double)table.Rows.Count / (double)checkSize;
                    int checkCount = table.Rows.Count / checkSize;
                    checkCount = checkCountD > checkCount ? checkCount + 1 : checkCount;

                    xlApp = new Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.Add();


                    int col = 1;
                    foreach (DataColumn c in table.Columns)
                    {
                        xlWorkSheet.Cells[1, col] = c.ColumnName;
                        col++;
                    }

                    int i = 0;
                    string[,] data = new string[table.Rows.Count, table.Columns.Count];
                    foreach (DataRow row in table.Rows)
                    {
                        int j = 0;
                        foreach (DataColumn c in table.Columns)
                        {
                            data[i, j] = row[c].ToString();
                            j++;
                        }
                        i++;
                    }

                    int processed = 0;
                    int data2DLength = data.GetLength(1);
                    for (int chunk = 1; chunk <= checkCount; chunk++)
                    {
                        if (table.Rows.Count - processed < checkSize) checkSize = table.Rows.Count - processed;
                        string[,] chunkData = new string[checkSize, data2DLength];
                        int l = 0;
                        for (int k = processed; k < checkSize + processed; k++)
                        {
                            for (int m = 0; m < data2DLength; m++)
                            {
                                chunkData[l, m] = table.Rows[k][m].ToString();
                            }
                            l++;
                        }

                        xlWorkSheet.Range[xlWorkSheet.Cells[2 + processed, 1], xlWorkSheet.Cells[processed + checkSize + 1, data2DLength]].Value = chunkData;
                        processed += checkSize;
                    }
                    xlWorkSheet.Cells.EntireColumn.AutoFit();


                    if (rndbtnXLSX.Checked)
                    {

                        saveFileExcel.FileName = "Kitap";
                        saveFileExcel.Filter = "Excel files (*.xlsx)|*.xlsx*";
                        saveFileExcel.FilterIndex = 2;
                        saveFileExcel.RestoreDirectory = true;
                        if (saveFileExcel.ShowDialog() == DialogResult.OK)
                        {
                            fileName = saveFileExcel.FileName;
                            xlWorkBook.SaveAs(fileName, XlFileFormat.xlOpenXMLStrictWorkbook, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                            xlWorkBook.Close(true, misValue, misValue);

                            xlApp.Quit();
                        }

                    }
                    else if (rndbtnXLT.Checked)
                    {
                        saveFileExcel.FileName = "Kitap";
                        saveFileExcel.Filter = "Excel files (*.xlt)|*.xlt*";
                        saveFileExcel.FilterIndex = 2;
                        saveFileExcel.RestoreDirectory = true;
                        if (saveFileExcel.ShowDialog() == DialogResult.OK)
                        {
                            fileName = saveFileExcel.FileName;
                            xlWorkBook.SaveAs(fileName, XlFileFormat.xlOpenXMLStrictWorkbook, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                            xlWorkBook.Close(true, misValue, misValue);

                            xlApp.Quit();
                        }
                    }
                    else if (rndbtnXLS.Checked)
                    {
                        saveFileExcel.FileName = "Kitap";
                        saveFileExcel.Filter = "Excel files (*.xls)|*.xls*";
                        saveFileExcel.FilterIndex = 2;
                        saveFileExcel.RestoreDirectory = true;
                        if (saveFileExcel.ShowDialog() == DialogResult.OK)
                        {
                            fileName = saveFileExcel.FileName;
                            xlWorkBook.SaveAs(fileName, XlFileFormat.xlOpenXMLStrictWorkbook, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                            xlWorkBook.Close(true, misValue, misValue);

                            xlApp.Quit();
                        }
                    }
                    else if (rndbtnCSV.Checked)
                    {
                        saveFileExcel.FileName = "Kitap";
                        saveFileExcel.Filter = "Excel files (*.csv)|*.csv*";
                        saveFileExcel.FilterIndex = 2;
                        saveFileExcel.RestoreDirectory = true;
                        if (saveFileExcel.ShowDialog() == DialogResult.OK)
                        {
                            fileName = saveFileExcel.FileName;
                            xlWorkBook.SaveAs(fileName, XlFileFormat.xlOpenXMLStrictWorkbook, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                            xlWorkBook.Close(true, misValue, misValue);

                            xlApp.Quit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Excel Formatı boş geçilemez!!");
                    }






                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                cnn.Close();
            }
        }

    }
}
