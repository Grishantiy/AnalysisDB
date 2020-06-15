using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AppSql
{
    public partial class Form1 : Form
    {
        public static string server { get; set; }
        public static string login { get; set; }
        public static string password { get; set; }

        private static string typeDB = "IZM_TII";

        List<Channel> listChannel;

        List<Counter> listCounter;





        public Form1()
        {
            InitializeComponent();

            ((ListBox)checkedListBoxMeasure).DataSource = typeof(MeasureType).ToList();
            checkedListBoxMeasure.DisplayMember = "Value";
            checkedListBoxMeasure.ValueMember = "Key";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public class Channel
        {
            public string id { get; set; }
            public string Name { get; set; }

        }
        public class Counter
        {
            public string id { get; set; }
            public string Name { get; set; }

        }

        private void comboBoxDB_DropDown(object sender, EventArgs e)
        {

            comboBoxDB.Items.Clear();

            string connectionString = $"Server={server};user id={login};" + $"password={password};";
            string queryString = "SELECT name FROM sys.databases";


            List<object> dbList = new List<object>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Не удается подключиться к SQL Server");
                        return;
                    }
                    SqlCommand command = new SqlCommand(queryString, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dbList.Add(reader.GetValue(0));
                        }
                    }
                    reader.Close();

                    for (int i = 4; i < dbList.Count; i++)
                    {

                        command = new SqlCommand($"SELECT TABLE_NAME FROM {dbList[i]}.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", connection);

                        reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(0) == typeDB)
                                {
                                    comboBoxDB.Items.Add(dbList[i]);
                                }

                            }
                        }

                        reader.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void sendConnParametrs()
        {
            DB.server = server;
            DB.login = login;
            DB.password = password;
            DB.database = comboBoxDB.Text;
        }

        private bool checkBox()
        {

            if (comboBoxDB.Text == "")
            {
                MessageBox.Show("Запросите имя базы данных");
                return true;
            }
            if (comboxQuery.Text == "")
            {
                MessageBox.Show("Выберите проверку");
                return true;
            }
            if (comboboxDevice.Text == "")
            {
                MessageBox.Show("Выберите устройство");
                return true;
            }
            return false;
        }
        private bool checkBoxScada()
        {

            if (comboBoxDB.Text == "")
            {
                MessageBox.Show("Запросите имя базы данных");
                return true;
            }
            if (comboxQueryScada.Text == "")
            {
                MessageBox.Show("Выберите проверку");
                return true;
            }
            if (comboboxChannelScada.Text == "")
            {
                MessageBox.Show("Выберите канал");
                return true;
            }

            return false;
        }
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            dataGridEnegryRes.DataSource = null;

            if (checkBox())
                return;

            sendConnParametrs();

            DB db = new DB();

            string queryChange = comboxQuery.Text;
            string queryString = "";
            string device = comboboxDevice.Text;

            switch (queryChange)
            {
                case "Анализ времени вставки":
                    if (!dateTimeBegin.Checked && !dateTimeEnd.Checked)
                    {
                        queryString = "SELECT i.TIME AS Дата, COUNT(i.TIME)/4 AS Количество, MIN(i.TIME_INSERT) AS Min, " +
                            "DATEADD(SECOND, (datediff(SECOND, MIN(i.TIME_INSERT), MAX(i.TIME_INSERT))) / (COUNT(i.TIME) / 4), MIN(i.TIME_INSERT)) AS AVG, " +
                            "MAX(i.TIME_INSERT) AS Max FROM IZM_TII AS i WHERE i.IDCHANNEL IN(SELECT c.IDCHANNEL FROM CHANNELS AS c " +
                            "JOIN POINT_CONNECTIONS AS p ON c.IDDEVICE= p.IDPOINT_CONNECTION " +
                            "JOIN LIB_CHANNELS AS l ON c.IDTYPE_CHANNEL= l.IDTYPE_CHANNEL " +
                            "WHERE p.IDPOINT_CONNECTION IN(SELECT POINT_OBJ.IDPOINT_CONNECTION FROM POINT_OBJ " +
                            $"JOIN OBJECTS ON POINT_OBJ.IDOBJECT= OBJECTS.IDOBJECT WHERE OBJECTS.NAME_OBJECT= '{device}') " +
                            "AND l.NAME_TYPE IN('Активная прямая (Сутки)', 'Активная обратная (Сутки)','Реактивная прямая (Сутки)', 'Реактивная обратная (Сутки)')) " +
                            "GROUP BY i.TIME " +
                            "ORDER BY i.TIME";
                    }
                    if (dateTimeBegin.Checked && dateTimeEnd.Checked)
                    {
                        string dateBegin = dateTimeBegin.Value.ToShortDateString();
                        string dateEnd = dateTimeEnd.Value.ToShortDateString();
                        queryString = "SELECT i.TIME AS Дата, COUNT(i.TIME)/4 AS Количество, MIN(i.TIME_INSERT) AS Min, " +
                            "DATEADD(SECOND, (datediff(SECOND, MIN(i.TIME_INSERT), MAX(i.TIME_INSERT))) / (COUNT(i.TIME) / 4), MIN(i.TIME_INSERT)) AS AVG, " +
                            $"MAX(i.TIME_INSERT) AS Max FROM IZM_TII AS i WHERE (i.TIME BETWEEN '{dateBegin}' AND '{dateEnd}') AND i.IDCHANNEL IN(SELECT c.IDCHANNEL FROM CHANNELS AS c " +
                            "JOIN POINT_CONNECTIONS AS p ON c.IDDEVICE= p.IDPOINT_CONNECTION " +
                            "JOIN LIB_CHANNELS AS l ON c.IDTYPE_CHANNEL= l.IDTYPE_CHANNEL " +
                            "WHERE p.IDPOINT_CONNECTION IN(SELECT POINT_OBJ.IDPOINT_CONNECTION FROM POINT_OBJ " +
                            $"JOIN OBJECTS ON POINT_OBJ.IDOBJECT= OBJECTS.IDOBJECT WHERE OBJECTS.NAME_OBJECT= '{device}') " +
                            "AND l.NAME_TYPE IN('Активная прямая (Сутки)', 'Активная обратная (Сутки)','Реактивная прямая (Сутки)', 'Реактивная обратная (Сутки)')) " +
                            "GROUP BY i.TIME " +
                            "ORDER BY i.TIME";
                    }
                    if (dateTimeBegin.Checked == false && dateTimeEnd.Checked == true)
                    {
                        string dateEnd = dateTimeEnd.Value.ToShortDateString();
                        queryString = "SELECT i.TIME AS Дата, COUNT(i.TIME)/4 AS Количество, MIN(i.TIME_INSERT) AS Min, " +
                            "DATEADD(SECOND, (datediff(SECOND, MIN(i.TIME_INSERT), MAX(i.TIME_INSERT))) / (COUNT(i.TIME) / 4), MIN(i.TIME_INSERT)) AS AVG, " +
                            $"MAX(i.TIME_INSERT) AS Max FROM IZM_TII AS i WHERE (i.TIME <= '{dateEnd}') AND i.IDCHANNEL IN(SELECT c.IDCHANNEL FROM CHANNELS AS c " +
                            "JOIN POINT_CONNECTIONS AS p ON c.IDDEVICE= p.IDPOINT_CONNECTION " +
                            "JOIN LIB_CHANNELS AS l ON c.IDTYPE_CHANNEL= l.IDTYPE_CHANNEL " +
                            "WHERE p.IDPOINT_CONNECTION IN(SELECT POINT_OBJ.IDPOINT_CONNECTION FROM POINT_OBJ " +
                            $"JOIN OBJECTS ON POINT_OBJ.IDOBJECT= OBJECTS.IDOBJECT WHERE OBJECTS.NAME_OBJECT= '{device}') " +
                            "AND l.NAME_TYPE IN('Активная прямая (Сутки)', 'Активная обратная (Сутки)','Реактивная прямая (Сутки)', 'Реактивная обратная (Сутки)')) " +
                            "GROUP BY i.TIME " +
                            "ORDER BY i.TIME";
                    }
                    if (dateTimeBegin.Checked == true && dateTimeEnd.Checked == false)
                    {
                        string dateBegin = dateTimeBegin.Value.ToShortDateString();
                        queryString = "SELECT i.TIME AS Дата, COUNT(i.TIME)/4 AS Количество, MIN(i.TIME_INSERT) AS Min, " +
                            "DATEADD(SECOND, (datediff(SECOND, MIN(i.TIME_INSERT), MAX(i.TIME_INSERT))) / (COUNT(i.TIME) / 4), MIN(i.TIME_INSERT)) AS AVG, " +
                            $"MAX(i.TIME_INSERT) AS Max FROM IZM_TII AS i WHERE (i.TIME >= '{dateBegin}') AND i.IDCHANNEL IN(SELECT c.IDCHANNEL FROM CHANNELS AS c " +
                            "JOIN POINT_CONNECTIONS AS p ON c.IDDEVICE= p.IDPOINT_CONNECTION " +
                            "JOIN LIB_CHANNELS AS l ON c.IDTYPE_CHANNEL= l.IDTYPE_CHANNEL " +
                            "WHERE p.IDPOINT_CONNECTION IN(SELECT POINT_OBJ.IDPOINT_CONNECTION FROM POINT_OBJ " +
                            $"JOIN OBJECTS ON POINT_OBJ.IDOBJECT= OBJECTS.IDOBJECT WHERE OBJECTS.NAME_OBJECT= '{device}') " +
                            "AND l.NAME_TYPE IN('Активная прямая (Сутки)', 'Активная обратная (Сутки)','Реактивная прямая (Сутки)', 'Реактивная обратная (Сутки)')) " +
                            "GROUP BY i.TIME " +
                            "ORDER BY i.TIME";
                    }
                    break;
            }

            dataGridEnegryRes.DataSource = db.getData(queryString);
            for (int i = 0; i < dataGridEnegryRes.Rows.Count; i++)
                dataGridEnegryRes.Rows[i].HeaderCell.Value = (i + 1).ToString();

        }

        private void comboboxDevice_DropDown(object sender, EventArgs e)
        {

            if (comboBoxDB.Text == "")
            {
                MessageBox.Show("Запросите имя базы данных");
                return;
            }
            comboboxDevice.Items.Clear();
            sendConnParametrs();
            DB.database = comboBoxDB.Text;
            DB db = new DB();

            string queryString = "Select NAME_OBJECT from OBJECTS WHERE IDTYPE_OBJECT='2'";

            SqlCommand command = new SqlCommand(queryString, db.openConnection());

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboboxDevice.Items.Add(reader.GetValue(0));
                }
            }
            reader.Close();
        }

        private void comboxQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxQuery.Text.Contains("Анализ времени вставки"))
            {
                dateTimeBegin.Visible = true;
                dateTimeEnd.Visible = true;
                labelChangeInterval.Visible = true;
            }
            else
            {
                dateTimeBegin.Visible = false;
                dateTimeEnd.Visible = false;
                labelChangeInterval.Visible = false;
            }
        }

        private void pictureDB_Click(object sender, EventArgs e)
        {
            Sign sign = new Sign();
            this.Hide();
            sign.Show();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDB.Items.Clear();
            if (tabControl.SelectedTab.Text == "EnergyRes")
            {
                typeDB = "IZM_TII";
            }
            else
            {
                typeDB = "METERINGS";
            }

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboboxChannelScada_DropDown(object sender, EventArgs e)
        {
            if (comboBoxDB.Text == "")
            {
                MessageBox.Show("Запросите имя базы данных");
                return;
            }

            comboboxChannelScada.DataSource = null;
            sendConnParametrs();
            DB.database = comboBoxDB.Text;
            DB db = new DB();

            listChannel = new List<Channel>();

            string queryString = "Select OBJECT_NAME,IDOBJECT from OBJECTS WHERE IDTYPE_OBJECT IN ('1050002','1050001','3124')";

            SqlCommand command = new SqlCommand(queryString, db.openConnection());

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listChannel.Add(new Channel { id = reader[1].ToString(), Name = reader[0].ToString() });
                }
            }
            reader.Close();

            this.comboboxChannelScada.SelectedIndexChanged -= new EventHandler(comboboxChannelScada_SelectedIndexChanged);
            comboboxChannelScada.DataSource = listChannel;
            comboboxChannelScada.DisplayMember = "Name";
            comboboxChannelScada.ValueMember = "id";
            this.comboboxChannelScada.SelectedIndexChanged += new EventHandler(comboboxChannelScada_SelectedIndexChanged);
        }


        private void comboboxChannelScada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDB.Text == "")
            {
                MessageBox.Show("Запросите имя базы данных");
                return;
            }
            if (checkedListBoxCounter.Items.Count > 1)
            {
                while (checkedListBoxCounter.Items.Count > 1)
                {
                    checkedListBoxCounter.Items.RemoveAt(1);
                }
            }

            sendConnParametrs();
            DB.database = comboBoxDB.Text;
            DB db = new DB();
            listCounter = new List<Counter>();
            string queryString = "SELECT OBJECT_NAME,IDOBJECT FROM OBJECTS WHERE IDTYPE_OBJECT = '200231' AND IDOBJECT IN( " +
                                 "SELECT IDOBJECT_TO FROM LINK_OBJECTS WHERE IDOBJECT_FROM IN( SElECT IDOBJECT_TO FROM LINK_OBJECTS " +
                                 "WHERE IDOBJECT_FROM IN(SELECT l.IDOBJECT_TO FROM OBJECTS AS o JOIN LINK_OBJECTS AS l ON o.IDOBJECT = l.IDOBJECT_FROM " +
                                 $"WHERE l.IDOBJECT_FROM = '{comboboxChannelScada.SelectedValue}')))";

            SqlCommand command = new SqlCommand(queryString, db.openConnection());

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listCounter.Add(new Counter { id = reader[1].ToString(), Name = reader[0].ToString() });

                }
            }
            reader.Close();
            ((ListBox)checkedListBoxCounter).DataSource = listCounter;
            checkedListBoxCounter.DisplayMember = "Name";
            checkedListBoxCounter.ValueMember = "id";

        }

        private void checkBoxAllCounter_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAllCounter.Checked)
            {
                for (int i = 0; i < checkedListBoxCounter.Items.Count; i++)
                { checkedListBoxCounter.SetItemChecked(i, true); }
            }
            else
            {
                for (int i = 0; i < checkedListBoxCounter.Items.Count; i++)
                { checkedListBoxCounter.SetItemChecked(i, false); }
            }
        }

        private void buttonQueryScada_Click(object sender, EventArgs e)
        {
            dataGridScada.DataSource = null;

            if (checkBoxScada())
                return;

            sendConnParametrs();

            DB db = new DB();

            string queryChange = comboxQueryScada.Text;
            string queryString = "";
            DataTable table = new DataTable();
            DataTable tableCopy = new DataTable();


            switch (queryChange)
            {
                case "Запрос измерений":
                    queryString = "SELECT IDOBJECT AS Счётчик, IDTYPE_OBJECT AS Измерение, TIME_END AS Время, VALUE_METERING AS Значение, TIME_INSERT AS Вставка FROM METERINGS" +
                                    $" WHERE IDOBJECT IN ({GetCounter()}) AND IDTYPE_OBJECT IN ({GetMeasure()}) {GetTime()} ";

                    table = db.getData(queryString);
                    if (table.Rows.Count == 0)
                        return;
                    tableCopy = table.Clone();
                    tableCopy.Columns[0].DataType = typeof(System.String);
                    tableCopy.Columns[1].DataType = typeof(System.String);
                    foreach (DataRow row in table.Rows)
                    {
                        tableCopy.ImportRow(row);
                    }
                    for (int i = 0; i < tableCopy.Rows.Count; i++)
                    {
                        tableCopy.Rows[i][1] = Enum.GetName(typeof(MeasureType), Convert.ToInt32(tableCopy.Rows[i][1]));

                        for (int y = 0; y < listCounter.Count; y++)
                        {
                            if (tableCopy.Rows[i][0].ToString() == listCounter[y].id)
                            {
                                tableCopy.Rows[i][0] = listCounter[y].Name;
                            }

                        }

                    }
                    break;
                case "Количество событий":
                    List<string> listMeasure =new List<string>( GetMeasure().Split(new char[] { ',' }));
                    for (int i = 0; i < listMeasure.Count; i++)
                    {
                        queryString = "SELECT o.OBJECT_NAME AS Счётчик,COUNT(CAST(m.TIME_END AS DATE)) AS Count FROM METERINGS AS m JOIN OBJECTS AS o ON o.IDOBJECT = m.IDOBJECT " +
                                        $"WHERE CAST(m.TIME_END AS DATE)= '{GetTime()}' AND m.IDTYPE_OBJECT = '{listMeasure[i]}'AND o.IDOBJECT IN({GetCounter()})" +
                                        " GROUP BY o.OBJECT_NAME ORDER BY o.OBJECT_NAME";
                        tableCopy = db.getData(queryString);
                    }
                    break;

                case "Запрос уникальных счетчиков":
                    break;
            }



            dataGridScada.DataSource = tableCopy;
            for (int i = 0; i < dataGridScada.Rows.Count; i++)
                dataGridScada.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }
        private string GetTime()
        {
            string stringTime = String.Empty;
            string queryChange = comboxQueryScada.Text;

            switch (queryChange)
            {
                case "Запрос измерений":
                    if(checkBoxCustomDate.Checked) 
                        stringTime= $"AND TIME_END BETWEEN '{dateTimePickerScadaBegin.Value.ToShortDateString()}' AND '{dateTimePickerScadaEnd.Value.ToShortDateString()}'"; 
                    else
                        stringTime = $"AND TIME_END = '{dateTimePickerScadaBegin.Value.ToShortDateString()}'";
                    break;
                case "Количество событий":
                    stringTime = $"{dateTimePickerScadaBegin.Value.ToShortDateString()}";
                    break;
                case "Запрос уникальных счетчиков":
                    break;
            }
            return stringTime;
        }
        private string GetMeasure()
        {
            string stringMeasure = String.Empty;
            List<string> allKeys = new List<string>();
            if (checkedListBoxMeasure.CheckedItems.Count > 0)
            {
                foreach (KeyValuePair<Enum, string> kvp in checkedListBoxMeasure.CheckedItems)
                {
                    allKeys.Add(Convert.ToString(Convert.ToInt32(kvp.Key)));
                }
                stringMeasure = String.Join(",", allKeys.ToArray());
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одно измерение");
            }
            return stringMeasure;
        }

        private string GetCounter()
        {
            string stringCounter = string.Empty;
            List<string> stringList = new List<string>();

            if (checkedListBoxCounter.CheckedItems.Count > 0)
            {
                foreach (var value in checkedListBoxCounter.CheckedItems)
                {
                    stringList.Add(((value as Counter).id).ToString());
                }
                stringCounter = String.Join(",", stringList.ToArray());
            }
            else
            {
                MessageBox.Show("Выберите хотя бы один счетчик");
            }

            return stringCounter;
        }

        private void comboxQueryScada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxQueryScada.Text.Contains("Запрос измерений"))
            {
                dateTimePickerScadaBegin.Visible = true;
                checkBoxCustomDate.Visible = true;
                dateTimePickerScadaEnd.Visible = false;
                labelChangeIntervalScada.Visible = true;
                checkBoxAllCounter.Visible = true;
                checkedListBoxCounter.Visible = true;
                checkedListBoxMeasure.Visible = true;
                labelChangeCounter.Visible = true;
                labelChangeMeasure.Visible = true;
                checkBoxCustomDate.Checked = false;
            }
            else if (comboxQueryScada.Text.Contains("Запрос уникальных счетчиков"))
            {
                dateTimePickerScadaBegin.Visible = true;
                dateTimePickerScadaEnd.Visible = false;
                labelChangeIntervalScada.Visible = true;
                checkBoxAllCounter.Visible = false;
                checkedListBoxCounter.Visible = false;
                checkedListBoxMeasure.Visible = true;
                labelChangeCounter.Visible = false;
                labelChangeMeasure.Visible = true;
            }
            else if (comboxQueryScada.Text.Contains("Количество событий"))
            {
                dateTimePickerScadaBegin.Visible = true;
                checkBoxCustomDate.Visible = false;
                dateTimePickerScadaEnd.Visible = false;
                labelChangeIntervalScada.Visible = true;
                checkBoxAllCounter.Visible = true;
                checkedListBoxCounter.Visible = true;
                checkedListBoxMeasure.Visible = true;
                labelChangeCounter.Visible = true;
                labelChangeMeasure.Visible = true;
                checkBoxCustomDate.Checked = false;
            }
            else
            {
                dateTimePickerScadaBegin.Visible = false;
                dateTimePickerScadaEnd.Visible = false;
                labelChangeIntervalScada.Visible = false;
                checkBoxAllCounter.Visible = false;
                checkedListBoxCounter.Visible = false;
                checkedListBoxMeasure.Visible = false;
                labelChangeCounter.Visible = false;
                labelChangeMeasure.Visible = false;
                checkBoxCustomDate.Visible = false;
            }
        }


        public enum MeasureType
        {
            [EnumDescription("Активная прямая")]
            PEEnergy = 1200001,

            [EnumDescription("Активная обратная")]
            PIEnergy = 1200002,

            [EnumDescription("Реактивная прямая")]
            QEEnergy = 1200003,

            [EnumDescription("Реактивная обратная")]
            QIEnergy = 1200004,

            [EnumDescription("Напряжение линейное AB")]
            ULineAB = 1200500,

            [EnumDescription("Напряжение линейное BC")]
            ULineBC = 1200501,

            [EnumDescription("Напряжение линейное CA")]
            ULineCA = 1200502,

            [EnumDescription("Напряжение нулевой послед-ти")]
            U_3U0 = 1200503,

            [EnumDescription("Мощность активная")]
            PPower = 1200085,

            [EnumDescription("Мощность активная фаза A")]
            PaPower = 1200185,

            [EnumDescription("Мощность активная фаза B")]
            PbPower = 1200285,

            [EnumDescription("Мощность активная фаза C")]
            PcPower = 1200385,

            [EnumDescription("Мощность реактивная")]
            QPower = 1200086,

            [EnumDescription("Мощность реактивная фаза A")]
            QaPower = 1200186,

            [EnumDescription("Мощность реактивная фаза B")]
            QbPower = 1200286,

            [EnumDescription("Мощность реактивная фаза C")]
            QcPower = 1200386,

            [EnumDescription("Мощность полная")]
            SPower = 1200087,

            [EnumDescription("Косинус фи")]
            CosF = 1200095,

            [EnumDescription("Мощность активная прямая фаза A")]
            PEaPower = 1200181,

            [EnumDescription("Мощность активная обратная фаза A")]
            PIaPower = 1200182,

            [EnumDescription("Мощность реактивная прямая фаза A")]
            QEaPower = 1200183,

            [EnumDescription("Мощность реактивная обратная фаза A")]
            QIaPower = 1200184,

            [EnumDescription("Мощность полная фаза A")]
            SaPower = 1200187,

            [EnumDescription("Косинус фи фаза A")]
            CosFa = 1200195,

            [EnumDescription("Мощность активная прямая фаза B")]
            PEbPower = 1200281,

            [EnumDescription("Мощность активная обратная фаза B")]
            PIbPower = 1200282,

            [EnumDescription("Мощность реактивная прямая фаза B")]
            QEbPower = 1200283,

            [EnumDescription("Мощность реактивная обратная фаза B")]
            QIbPower = 1200284,

            [EnumDescription("Мощность полная фаза B")]
            SbPower = 1200287,

            [EnumDescription("Косинус фи фаза B")]
            CosFb = 1200295,

            [EnumDescription("Мощность активная прямая фаза C")]
            PEcPower = 1200381,

            [EnumDescription("Мощность активная обратная фаза C")]
            PIcPower = 1200382,

            [EnumDescription("Мощность реактивная прямая фаза C")]
            QEcPower = 1200383,

            [EnumDescription("Мощность реактивная обратная фаза C")]
            QIcPower = 1200384,

            [EnumDescription("Мощность полная фаза C")]
            ScPower = 1200387,

            [EnumDescription("Косинус фи фаза C")]
            CosFc = 1200395,

            [EnumDescription("Частота сети")]
            F = 1200092,

            [EnumDescription("Ток фаза A")]
            Ia = 1200197,

            [EnumDescription("Напряжение фаза A")]
            Ua = 1200196,

            [EnumDescription("Ток фаза B")]
            Ib = 1200297,

            [EnumDescription("Напряжение фаза B")]
            Ub = 1200296,

            [EnumDescription("Ток фаза C")]
            Ic = 1200397,

            [EnumDescription("Напряжение фаза C")]
            Uc = 1200396,

            [EnumDescription("Ток нейтрали")]
            In = 1200090,

            [EnumDescription("Дифференциальный ток")]
            Idiff = 1200091,

            [EnumDescription("Температура")]
            T = 1200900,

            [EnumDescription("Активная суммарная")]
            PEnergy = 1200005,

            [EnumDescription("Реактивная суммарная")]
            QEnergy = 1200006,

            [EnumDescription("Полная суммарная")]
            SEnergy = 1200007

        }

        private void checkBoxCustomDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomDate.Checked)
            dateTimePickerScadaEnd.Visible = true;
            else
            dateTimePickerScadaEnd.Visible = false;
        }
    }
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class EnumDescriptionAttribute : Attribute
    {
        private string description;


        public string Description
        {
            get
            {
                return this.description;
            }
        }

        public EnumDescriptionAttribute(string description)
            : base()
        {
            this.description = description;
        }
    }

    public static class EnumHelper
    {

        public static string GetDescription(this Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            string description = value.ToString();
            FieldInfo fieldInfo = value.GetType().GetField(description);
            EnumDescriptionAttribute[] attributes =
               (EnumDescriptionAttribute[])
             fieldInfo.GetCustomAttributes(typeof(EnumDescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                description = attributes[0].Description;
            }
            return description;
        }


        public static IList ToList(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            ArrayList list = new ArrayList();
            Array enumValues = Enum.GetValues(type);

            foreach (Enum value in enumValues)
            {
                list.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
            }

            return list;
        }
    }
}
