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

        SqlConnection con = new SqlConnection();
        SqlCommand komut = new SqlCommand();
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnect sql = new SqlConnect();
            sql.ServerName = txtServerName.Text;
            sql.UserName = txtLogin.Text;
            sql.Password = txtPass.Text;
            

            try
            {
                if (sql.ServerName != " "  && sql.UserName != " "  && sql.Password != " ")
                {

                    string baglanti = string.Format("Data Source={0};  User ID={1}; Password={2}", sql.ServerName, sql.UserName, sql.Password);

                    con.ConnectionString = baglanti;
                    con.Open();
                    DataTable table = con.GetSchema("databases");
                    foreach (DataRow item in table.Rows)
                    {
                        cmbDatabase.Items.Add(item.Field<string>("database_name"));
                    }

                }
                else
                {
                    MessageBox.Show("Baglantı Degerleri Bos Geçilemez!!");
                }

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDatabase.SelectedItem.ToString());
            var result = cmbDatabase.SelectedIndex;

            switch (result)
            {
                case 22:
                    int sayac = 0;
                    komut.Connection = con;
                    komut.CommandText = "Select Kullanı from dbo.Kullanici";
                    reader = komut.ExecuteReader();
                    while (reader.Read())
                    {
                        sayac++;
                        Console.WriteLine(reader[0] + ":" + reader[1] + " " + reader[2]);

                    }


                    //SqlDataAdapter cmd = new SqlDataAdapter("Select * from Kullanici", con);
                    //DataTable tablo = new DataTable();
                    //cmd.Fill(tablo);
                    //foreach (DataRow item in tablo.Rows)
                    //{
                    //    Console.WriteLine(item.ItemArray);
                    //}
                    break;
                    


                default:
                    break;
            }
        }
    }
}
