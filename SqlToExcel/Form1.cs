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

                    cnn.Open();

                    DataTable table = cnn.GetSchema("databases");
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
            //finally
            //{
            //    if (cnn.State== ConnectionState.Open)
            //    {
            //        cnn.Close();
            //    }
            //}
        }
        string selectDb ="";
        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           var result = cmbDatabase.SelectedItem;
            selectDb = result.ToString();
           

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt;
           

            if (rdbtnXLSX.Checked)
            {
                try
                {
                    cmd = new SqlCommand("USE " + selectDb + " \n" + txtSorgu.Text, cnn);

                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    da.Fill(dt);

                    //dt.WriteXml(@"C:\Users\user\Desktop\Name.xls");
                    
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else if (rdbtnXLT.Checked)
            {
                MessageBox.Show("Excel Formatı XLT");
            }
            else if (rdbtnXLS.Checked)
            {
                MessageBox.Show("Excel Formatı XLS");
            }
            else if (rdbtnCSV.Checked)
            {
                MessageBox.Show("Excel Formatı CSV");
            }
            else
            {
                MessageBox.Show("Excel Formatı boş geçilemez!!");
            }
        }

        
    }
}
