using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AppSql
{
    class DB
    {
        public static string server { get; set; }
        public static string login { get; set; }
        public static string password { get; set; }
        public static string database { get; set; }
        public static string connectionString = "Server=" + server + ";user id =" + login + "; password=" + password + ";Initial Catalog = " + database + ";";

        SqlConnection connection = new SqlConnection(new SqlConnectionStringBuilder()
        {
            DataSource = server,
            InitialCatalog = database,
            UserID = login,
            Password = password
        }.ConnectionString
        );

        public SqlConnection openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
                return connection;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return connection;
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }

        public DataTable getData(string queryString)
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(queryString, openConnection());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                    closeConnection();
                }
                else
                {
                    MessageBox.Show("Запрос не дал результата");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return table;
        }

    }
}
