using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxServer_DropDown(object sender, EventArgs e)
        {
            comboBoxServer.Items.Clear();
            SqlDataSourceEnumerator inst = SqlDataSourceEnumerator.Instance;
            DataTable DT = inst.GetDataSources();
            foreach (System.Data.DataRow row in DT.Rows)
            {
                comboBoxServer.Items.Add(row[0]);
            }
        }

        //public static List<string> GetDatabases(string conn)
        //{
        //    List<string> dbList = new List<string>();
        //    using (PersonContext db = new PersonContext(conn))
        //    {
        //        var comps = db.Database.SqlQuery<string>("SELECT name FROM sys.databases");
        //        foreach (string str in comps)
        //        {
        //            dbList.Add(str);
        //        }
        //    }
        //    return dbList;
        //}

        private void comboBoxDB_DropDown(object sender, EventArgs e)
        {
            
            comboBoxDB.Items.Clear();
            string server = comboBoxServer.Text;
            string password = passDB.Text;
            string login = userDB.Text;

            if (server == "")
            {
                MessageBox.Show("Введите имя или ip сервера");
                return; 
            }
            if (password == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (login == "")
            {
                MessageBox.Show("Введите имя пользователя");
                return;
            }

            string connectionString = $"Server={server};user id={login};" + $"password={password};";
            string queryString = "SELECT name FROM sys.databases";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(queryString, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comboBoxDB.Items.Add(reader.GetValue(0));
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxDB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (comboBoxServer.Text == "")
            {
                MessageBox.Show("Введите имя или ip сервера");
                return;
            }
            if (passDB.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (userDB.Text == "")
            {
                MessageBox.Show("Введите имя пользователя");
                return;
            }
            if (comboBoxDB.Text == "")
            {
                MessageBox.Show("Запросите имя базы данных");
                return;
            }

            DB.server = comboBoxServer.Text;
            DB.login = userDB.Text;
            DB.password = passDB.Text;
            DB.database = comboBoxDB.Text;
            
            DB db = new DB();

            db.openConnection();

            if (db.GetConnection().State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено");
                return;
            }
            else
            {
                MessageBox.Show("Данные введены неправильно или нет связи с базой");
                return;
            }
            db.closeConnection();
        }

        private void comboboxChannel_DropDown(object sender, EventArgs e)
        {
            if (comboBoxServer.Text == "")
            {
                MessageBox.Show("Введите имя или ip сервера");
                return;
            }
            if (passDB.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (userDB.Text == "")
            {
                MessageBox.Show("Введите имя пользователя");
                return;
            }
            if (comboBoxDB.Text == "")
            {
                MessageBox.Show("Запросите имя базы данных");
                return;
            }

            DB.server = comboBoxServer.Text;
            DB.login = userDB.Text;
            DB.password = passDB.Text;
            DB.database = comboBoxDB.Text;

            DB db = new DB();

            string queryString = "Select NAME_OBJECT from OBJECTS WHERE IDTYPE_OBJECT='1'";

            SqlCommand command = new SqlCommand(queryString, db.openConnection());

            SqlDataReader reader = command.ExecuteReader();
          
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboboxChannel.Items.Add(reader.GetValue(0));
                }
            }
            reader.Close();        
     
        }
    }
}
