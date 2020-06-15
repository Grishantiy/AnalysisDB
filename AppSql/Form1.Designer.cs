namespace AppSql
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelChangeInterval = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.comboboxDevice = new System.Windows.Forms.ComboBox();
            this.labelDevice = new System.Windows.Forms.Label();
            this.labelQuery = new System.Windows.Forms.Label();
            this.comboxQuery = new System.Windows.Forms.ComboBox();
            this.dataGridEnegryRes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridScada = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelChangeMeasure = new System.Windows.Forms.Label();
            this.checkedListBoxMeasure = new System.Windows.Forms.CheckedListBox();
            this.checkBoxAllCounter = new System.Windows.Forms.CheckBox();
            this.labelChangeCounter = new System.Windows.Forms.Label();
            this.checkedListBoxCounter = new System.Windows.Forms.CheckedListBox();
            this.labelChangeIntervalScada = new System.Windows.Forms.Label();
            this.dateTimePickerScadaEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerScadaBegin = new System.Windows.Forms.DateTimePicker();
            this.buttonQueryScada = new System.Windows.Forms.Button();
            this.comboboxChannelScada = new System.Windows.Forms.ComboBox();
            this.labelChannel = new System.Windows.Forms.Label();
            this.labelQueryScada = new System.Windows.Forms.Label();
            this.comboxQueryScada = new System.Windows.Forms.ComboBox();
            this.comboBoxDB = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureDB = new System.Windows.Forms.PictureBox();
            this.labelSQl = new System.Windows.Forms.Label();
            this.checkBoxCustomDate = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnegryRes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScada)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(675, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(675, 663);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridEnegryRes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EnergyRes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelChangeInterval);
            this.panel2.Controls.Add(this.dateTimeEnd);
            this.panel2.Controls.Add(this.dateTimeBegin);
            this.panel2.Controls.Add(this.buttonQuery);
            this.panel2.Controls.Add(this.comboboxDevice);
            this.panel2.Controls.Add(this.labelDevice);
            this.panel2.Controls.Add(this.labelQuery);
            this.panel2.Controls.Add(this.comboxQuery);
            this.panel2.Location = new System.Drawing.Point(8, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 160);
            this.panel2.TabIndex = 2;
            // 
            // labelChangeInterval
            // 
            this.labelChangeInterval.AutoSize = true;
            this.labelChangeInterval.Location = new System.Drawing.Point(190, 9);
            this.labelChangeInterval.Name = "labelChangeInterval";
            this.labelChangeInterval.Size = new System.Drawing.Size(96, 13);
            this.labelChangeInterval.TabIndex = 15;
            this.labelChangeInterval.Text = "Выбор интервала";
            this.labelChangeInterval.Visible = false;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Checked = false;
            this.dateTimeEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEnd.Location = new System.Drawing.Point(291, 25);
            this.dateTimeEnd.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimeEnd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.ShowCheckBox = true;
            this.dateTimeEnd.Size = new System.Drawing.Size(92, 20);
            this.dateTimeEnd.TabIndex = 14;
            this.dateTimeEnd.Visible = false;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Checked = false;
            this.dateTimeBegin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBegin.Location = new System.Drawing.Point(193, 25);
            this.dateTimeBegin.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimeBegin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.ShowCheckBox = true;
            this.dateTimeBegin.Size = new System.Drawing.Size(92, 20);
            this.dateTimeBegin.TabIndex = 13;
            this.dateTimeBegin.Visible = false;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuery.ForeColor = System.Drawing.Color.Black;
            this.buttonQuery.Location = new System.Drawing.Point(35, 125);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(100, 23);
            this.buttonQuery.TabIndex = 12;
            this.buttonQuery.Text = "Запросить";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // comboboxDevice
            // 
            this.comboboxDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDevice.FormattingEnabled = true;
            this.comboboxDevice.Location = new System.Drawing.Point(11, 74);
            this.comboboxDevice.Name = "comboboxDevice";
            this.comboboxDevice.Size = new System.Drawing.Size(165, 21);
            this.comboboxDevice.TabIndex = 11;
            this.comboboxDevice.DropDown += new System.EventHandler(this.comboboxDevice_DropDown);
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new System.Drawing.Point(9, 56);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(75, 13);
            this.labelDevice.TabIndex = 10;
            this.labelDevice.Text = "Выбор УСПД";
            // 
            // labelQuery
            // 
            this.labelQuery.AutoSize = true;
            this.labelQuery.Location = new System.Drawing.Point(8, 9);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new System.Drawing.Size(91, 13);
            this.labelQuery.TabIndex = 9;
            this.labelQuery.Text = "Выбор проверки";
            // 
            // comboxQuery
            // 
            this.comboxQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboxQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxQuery.FormattingEnabled = true;
            this.comboxQuery.Items.AddRange(new object[] {
            "Анализ времени вставки"});
            this.comboxQuery.Location = new System.Drawing.Point(10, 25);
            this.comboxQuery.Name = "comboxQuery";
            this.comboxQuery.Size = new System.Drawing.Size(165, 21);
            this.comboxQuery.TabIndex = 8;
            this.comboxQuery.SelectedIndexChanged += new System.EventHandler(this.comboxQuery_SelectedIndexChanged);
            // 
            // dataGridEnegryRes
            // 
            this.dataGridEnegryRes.AllowUserToAddRows = false;
            this.dataGridEnegryRes.AllowUserToDeleteRows = false;
            this.dataGridEnegryRes.AllowUserToOrderColumns = true;
            this.dataGridEnegryRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEnegryRes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridEnegryRes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridEnegryRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEnegryRes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEnegryRes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEnegryRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridEnegryRes.Location = new System.Drawing.Point(3, 175);
            this.dataGridEnegryRes.Name = "dataGridEnegryRes";
            this.dataGridEnegryRes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEnegryRes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEnegryRes.Size = new System.Drawing.Size(661, 459);
            this.dataGridEnegryRes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MintCream;
            this.tabPage2.Controls.Add(this.dataGridScada);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scada";
            // 
            // dataGridScada
            // 
            this.dataGridScada.AllowUserToAddRows = false;
            this.dataGridScada.AllowUserToDeleteRows = false;
            this.dataGridScada.AllowUserToOrderColumns = true;
            this.dataGridScada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridScada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridScada.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridScada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridScada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridScada.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridScada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridScada.Location = new System.Drawing.Point(3, 175);
            this.dataGridScada.Name = "dataGridScada";
            this.dataGridScada.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridScada.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridScada.Size = new System.Drawing.Size(661, 459);
            this.dataGridScada.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBoxCustomDate);
            this.panel3.Controls.Add(this.labelChangeMeasure);
            this.panel3.Controls.Add(this.checkedListBoxMeasure);
            this.panel3.Controls.Add(this.checkBoxAllCounter);
            this.panel3.Controls.Add(this.labelChangeCounter);
            this.panel3.Controls.Add(this.checkedListBoxCounter);
            this.panel3.Controls.Add(this.labelChangeIntervalScada);
            this.panel3.Controls.Add(this.dateTimePickerScadaEnd);
            this.panel3.Controls.Add(this.dateTimePickerScadaBegin);
            this.panel3.Controls.Add(this.buttonQueryScada);
            this.panel3.Controls.Add(this.comboboxChannelScada);
            this.panel3.Controls.Add(this.labelChannel);
            this.panel3.Controls.Add(this.labelQueryScada);
            this.panel3.Controls.Add(this.comboxQueryScada);
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 160);
            this.panel3.TabIndex = 5;
            // 
            // labelChangeMeasure
            // 
            this.labelChangeMeasure.AutoSize = true;
            this.labelChangeMeasure.Location = new System.Drawing.Point(359, 9);
            this.labelChangeMeasure.Name = "labelChangeMeasure";
            this.labelChangeMeasure.Size = new System.Drawing.Size(99, 13);
            this.labelChangeMeasure.TabIndex = 20;
            this.labelChangeMeasure.Text = "Выбор измерений";
            this.labelChangeMeasure.Visible = false;
            // 
            // checkedListBoxMeasure
            // 
            this.checkedListBoxMeasure.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxMeasure.CheckOnClick = true;
            this.checkedListBoxMeasure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBoxMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxMeasure.FormattingEnabled = true;
            this.checkedListBoxMeasure.Location = new System.Drawing.Point(362, 25);
            this.checkedListBoxMeasure.Name = "checkedListBoxMeasure";
            this.checkedListBoxMeasure.Size = new System.Drawing.Size(175, 79);
            this.checkedListBoxMeasure.TabIndex = 19;
            this.checkedListBoxMeasure.Visible = false;
            // 
            // checkBoxAllCounter
            // 
            this.checkBoxAllCounter.AutoSize = true;
            this.checkBoxAllCounter.Location = new System.Drawing.Point(210, 111);
            this.checkBoxAllCounter.Name = "checkBoxAllCounter";
            this.checkBoxAllCounter.Size = new System.Drawing.Size(91, 17);
            this.checkBoxAllCounter.TabIndex = 18;
            this.checkBoxAllCounter.Text = "Выбрать все";
            this.checkBoxAllCounter.UseVisualStyleBackColor = true;
            this.checkBoxAllCounter.Visible = false;
            this.checkBoxAllCounter.CheckStateChanged += new System.EventHandler(this.checkBoxAllCounter_CheckStateChanged);
            // 
            // labelChangeCounter
            // 
            this.labelChangeCounter.AutoSize = true;
            this.labelChangeCounter.Location = new System.Drawing.Point(207, 9);
            this.labelChangeCounter.Name = "labelChangeCounter";
            this.labelChangeCounter.Size = new System.Drawing.Size(94, 13);
            this.labelChangeCounter.TabIndex = 17;
            this.labelChangeCounter.Text = "Выбор счетчиков";
            this.labelChangeCounter.Visible = false;
            // 
            // checkedListBoxCounter
            // 
            this.checkedListBoxCounter.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxCounter.CheckOnClick = true;
            this.checkedListBoxCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBoxCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxCounter.FormattingEnabled = true;
            this.checkedListBoxCounter.Location = new System.Drawing.Point(210, 25);
            this.checkedListBoxCounter.Name = "checkedListBoxCounter";
            this.checkedListBoxCounter.Size = new System.Drawing.Size(146, 79);
            this.checkedListBoxCounter.TabIndex = 16;
            this.checkedListBoxCounter.Visible = false;
            // 
            // labelChangeIntervalScada
            // 
            this.labelChangeIntervalScada.AutoSize = true;
            this.labelChangeIntervalScada.Location = new System.Drawing.Point(541, 9);
            this.labelChangeIntervalScada.Name = "labelChangeIntervalScada";
            this.labelChangeIntervalScada.Size = new System.Drawing.Size(68, 13);
            this.labelChangeIntervalScada.TabIndex = 15;
            this.labelChangeIntervalScada.Text = "Выбор даты";
            this.labelChangeIntervalScada.Visible = false;
            // 
            // dateTimePickerScadaEnd
            // 
            this.dateTimePickerScadaEnd.Checked = false;
            this.dateTimePickerScadaEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerScadaEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerScadaEnd.Location = new System.Drawing.Point(545, 56);
            this.dateTimePickerScadaEnd.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerScadaEnd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerScadaEnd.Name = "dateTimePickerScadaEnd";
            this.dateTimePickerScadaEnd.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerScadaEnd.TabIndex = 14;
            this.dateTimePickerScadaEnd.Visible = false;
            // 
            // dateTimePickerScadaBegin
            // 
            this.dateTimePickerScadaBegin.Checked = false;
            this.dateTimePickerScadaBegin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePickerScadaBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerScadaBegin.Location = new System.Drawing.Point(544, 25);
            this.dateTimePickerScadaBegin.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerScadaBegin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerScadaBegin.Name = "dateTimePickerScadaBegin";
            this.dateTimePickerScadaBegin.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerScadaBegin.TabIndex = 13;
            this.dateTimePickerScadaBegin.Visible = false;
            // 
            // buttonQueryScada
            // 
            this.buttonQueryScada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQueryScada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQueryScada.ForeColor = System.Drawing.Color.Black;
            this.buttonQueryScada.Location = new System.Drawing.Point(37, 125);
            this.buttonQueryScada.Name = "buttonQueryScada";
            this.buttonQueryScada.Size = new System.Drawing.Size(100, 23);
            this.buttonQueryScada.TabIndex = 12;
            this.buttonQueryScada.Text = "Запросить";
            this.buttonQueryScada.UseVisualStyleBackColor = true;
            this.buttonQueryScada.Click += new System.EventHandler(this.buttonQueryScada_Click);
            // 
            // comboboxChannelScada
            // 
            this.comboboxChannelScada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxChannelScada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxChannelScada.FormattingEnabled = true;
            this.comboboxChannelScada.Location = new System.Drawing.Point(13, 74);
            this.comboboxChannelScada.Name = "comboboxChannelScada";
            this.comboboxChannelScada.Size = new System.Drawing.Size(165, 21);
            this.comboboxChannelScada.TabIndex = 11;
            this.comboboxChannelScada.DropDown += new System.EventHandler(this.comboboxChannelScada_DropDown);
            this.comboboxChannelScada.SelectedIndexChanged += new System.EventHandler(this.comboboxChannelScada_SelectedIndexChanged);
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(11, 56);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(79, 13);
            this.labelChannel.TabIndex = 10;
            this.labelChannel.Text = "Выбор канала";
            // 
            // labelQueryScada
            // 
            this.labelQueryScada.AutoSize = true;
            this.labelQueryScada.Location = new System.Drawing.Point(10, 9);
            this.labelQueryScada.Name = "labelQueryScada";
            this.labelQueryScada.Size = new System.Drawing.Size(91, 13);
            this.labelQueryScada.TabIndex = 9;
            this.labelQueryScada.Text = "Выбор проверки";
            // 
            // comboxQueryScada
            // 
            this.comboxQueryScada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboxQueryScada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxQueryScada.FormattingEnabled = true;
            this.comboxQueryScada.Items.AddRange(new object[] {
            "Запрос измерений",
            "Запрос уникальных счетчиков",
            "Количество событий"});
            this.comboxQueryScada.Location = new System.Drawing.Point(12, 25);
            this.comboxQueryScada.Name = "comboxQueryScada";
            this.comboxQueryScada.Size = new System.Drawing.Size(165, 21);
            this.comboxQueryScada.TabIndex = 8;
            this.comboxQueryScada.SelectedIndexChanged += new System.EventHandler(this.comboxQueryScada_SelectedIndexChanged);
            // 
            // comboBoxDB
            // 
            this.comboBoxDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDB.FormattingEnabled = true;
            this.comboBoxDB.Location = new System.Drawing.Point(327, 3);
            this.comboBoxDB.Name = "comboBoxDB";
            this.comboBoxDB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDB.TabIndex = 7;
            this.comboBoxDB.DropDown += new System.EventHandler(this.comboBoxDB_DropDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSql.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(302, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureDB
            // 
            this.pictureDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDB.Image = global::AppSql.Properties.Resources.sql;
            this.pictureDB.Location = new System.Drawing.Point(157, 1);
            this.pictureDB.Name = "pictureDB";
            this.pictureDB.Size = new System.Drawing.Size(22, 28);
            this.pictureDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDB.TabIndex = 4;
            this.pictureDB.TabStop = false;
            this.pictureDB.Click += new System.EventHandler(this.pictureDB_Click);
            // 
            // labelSQl
            // 
            this.labelSQl.AutoSize = true;
            this.labelSQl.Location = new System.Drawing.Point(188, 10);
            this.labelSQl.Name = "labelSQl";
            this.labelSQl.Size = new System.Drawing.Size(0, 13);
            this.labelSQl.TabIndex = 5;
            // 
            // checkBoxCustomDate
            // 
            this.checkBoxCustomDate.AutoSize = true;
            this.checkBoxCustomDate.Location = new System.Drawing.Point(545, 87);
            this.checkBoxCustomDate.Name = "checkBoxCustomDate";
            this.checkBoxCustomDate.Size = new System.Drawing.Size(75, 17);
            this.checkBoxCustomDate.TabIndex = 21;
            this.checkBoxCustomDate.Text = "Интервал";
            this.checkBoxCustomDate.UseVisualStyleBackColor = true;
            this.checkBoxCustomDate.Visible = false;
            this.checkBoxCustomDate.CheckedChanged += new System.EventHandler(this.checkBoxCustomDate_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(675, 687);
            this.Controls.Add(this.comboBoxDB);
            this.Controls.Add(this.labelSQl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureDB);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализатор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnegryRes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScada)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridEnegryRes;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox comboBoxDB;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox comboxQuery;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.Button buttonQuery;
        public System.Windows.Forms.ComboBox comboboxDevice;
        private System.Windows.Forms.Label labelChangeInterval;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelChangeIntervalScada;
        private System.Windows.Forms.DateTimePicker dateTimePickerScadaEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerScadaBegin;
        private System.Windows.Forms.Button buttonQueryScada;
        public System.Windows.Forms.ComboBox comboboxChannelScada;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelQueryScada;
        public System.Windows.Forms.ComboBox comboxQueryScada;
        private System.Windows.Forms.PictureBox pictureDB;
        public System.Windows.Forms.Label labelSQl;
        private System.Windows.Forms.CheckedListBox checkedListBoxCounter;
        private System.Windows.Forms.CheckBox checkBoxAllCounter;
        private System.Windows.Forms.Label labelChangeCounter;
        private System.Windows.Forms.DataGridView dataGridScada;
        private System.Windows.Forms.Label labelChangeMeasure;
        private System.Windows.Forms.CheckedListBox checkedListBoxMeasure;
        private System.Windows.Forms.CheckBox checkBoxCustomDate;
    }
}

