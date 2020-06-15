using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppSql
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
           

            DB.server = comboBoxServer.Text;
            DB.login = userDB.Text;
            DB.password = passDB.Text;
            DB.database = "master";

            DB db = new DB();

            db.openConnection();

            if (db.GetConnection().State == System.Data.ConnectionState.Open)
            {               
                db.closeConnection();
                labelConnState.Visible = true;
                labelConnState.Text = "Okay";
                this.Hide();
                Form1 form = new Form1();
                form.labelSQl.Text = comboBoxServer.Text;
                Form1.server= comboBoxServer.Text;
                Form1.login = userDB.Text;
                Form1.password = passDB.Text;
                form.Show();
                return;
            }
            else
            {
                MessageBox.Show("Данные введены неправильно или нет связи с базой");
                return;
            }
            
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
       
    }
    
}
