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
            SqlDataSourceEnumerator inst = SqlDataSourceEnumerator.Instance;
            DataTable DT = inst.GetDataSources();
            foreach (System.Data.DataRow row in DT.Rows)
            {
                comboBoxServer.Items.Add(row[0]);
            }
        }

        public static List<string> GetDatabases(string conn)
        {
            List<string> dbList = new List<string>();
            using (PersonContext db = new PersonContext(conn))
            {
                var comps = db.Database.SqlQuery<string>("SELECT name FROM sys.databases");
                foreach (string str in comps)
                {
                    dbList.Add(str);
                }
            }
            return dbList;
        }

            private void comboBoxDB_DropDown(object sender, EventArgs e)
        {
           
        }
    }
}
