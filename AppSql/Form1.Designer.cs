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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.comboBoxDB = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passDB = new System.Windows.Forms.TextBox();
            this.userDB = new System.Windows.Forms.TextBox();
            this.labelConnDB = new System.Windows.Forms.Label();
            this.dataGridEnegryRes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboxQuery = new System.Windows.Forms.ComboBox();
            this.labelQuery = new System.Windows.Forms.Label();
            this.labelChannel = new System.Windows.Forms.Label();
            this.comboboxChannel = new System.Windows.Forms.ComboBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnegryRes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
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
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 663);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MintCream;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scada";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridEnegryRes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EnergyRes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.comboBoxDB);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBoxServer);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.passDB);
            this.panel1.Controls.Add(this.userDB);
            this.panel1.Controls.Add(this.labelConnDB);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 160);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AppSql.Properties.Resources.sql;
            this.pictureBox4.Location = new System.Drawing.Point(5, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // comboBoxDB
            // 
            this.comboBoxDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDB.FormattingEnabled = true;
            this.comboBoxDB.Location = new System.Drawing.Point(36, 96);
            this.comboBoxDB.Name = "comboBoxDB";
            this.comboBoxDB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDB.TabIndex = 7;
            this.comboBoxDB.DropDown += new System.EventHandler(this.comboBoxDB_DropDown);
            this.comboBoxDB.SelectedIndexChanged += new System.EventHandler(this.comboBoxDB_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSql.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(9, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(36, 20);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServer.TabIndex = 2;
            this.comboBoxServer.DropDown += new System.EventHandler(this.comboBoxServer_DropDown);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(43, 125);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Подключиться";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppSql.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(8, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppSql.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(8, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // passDB
            // 
            this.passDB.Location = new System.Drawing.Point(36, 70);
            this.passDB.Name = "passDB";
            this.passDB.Size = new System.Drawing.Size(121, 20);
            this.passDB.TabIndex = 3;
            this.passDB.UseSystemPasswordChar = true;
            // 
            // userDB
            // 
            this.userDB.Location = new System.Drawing.Point(36, 45);
            this.userDB.Name = "userDB";
            this.userDB.Size = new System.Drawing.Size(121, 20);
            this.userDB.TabIndex = 2;
            // 
            // labelConnDB
            // 
            this.labelConnDB.AutoSize = true;
            this.labelConnDB.Location = new System.Drawing.Point(34, 4);
            this.labelConnDB.Name = "labelConnDB";
            this.labelConnDB.Size = new System.Drawing.Size(104, 13);
            this.labelConnDB.TabIndex = 1;
            this.labelConnDB.Text = "Подключение к БД";
            // 
            // dataGridEnegryRes
            // 
            this.dataGridEnegryRes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridEnegryRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridEnegryRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEnegryRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridEnegryRes.Location = new System.Drawing.Point(3, 175);
            this.dataGridEnegryRes.Name = "dataGridEnegryRes";
            this.dataGridEnegryRes.Size = new System.Drawing.Size(786, 459);
            this.dataGridEnegryRes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonQuery);
            this.panel2.Controls.Add(this.comboboxChannel);
            this.panel2.Controls.Add(this.labelChannel);
            this.panel2.Controls.Add(this.labelQuery);
            this.panel2.Controls.Add(this.comboxQuery);
            this.panel2.Location = new System.Drawing.Point(224, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 160);
            this.panel2.TabIndex = 2;
            // 
            // comboxQuery
            // 
            this.comboxQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxQuery.FormattingEnabled = true;
            this.comboxQuery.Items.AddRange(new object[] {
            "Кол-во сч-ков (дни и время вставки)"});
            this.comboxQuery.Location = new System.Drawing.Point(17, 25);
            this.comboxQuery.Name = "comboxQuery";
            this.comboxQuery.Size = new System.Drawing.Size(250, 21);
            this.comboxQuery.TabIndex = 8;
            // 
            // labelQuery
            // 
            this.labelQuery.AutoSize = true;
            this.labelQuery.Location = new System.Drawing.Point(14, 9);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new System.Drawing.Size(91, 13);
            this.labelQuery.TabIndex = 9;
            this.labelQuery.Text = "Выбор проверки";
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(14, 56);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(79, 13);
            this.labelChannel.TabIndex = 10;
            this.labelChannel.Text = "Выбор канала";
            // 
            // comboboxChannel
            // 
            this.comboboxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxChannel.FormattingEnabled = true;
            this.comboboxChannel.Location = new System.Drawing.Point(17, 74);
            this.comboboxChannel.Name = "comboboxChannel";
            this.comboboxChannel.Size = new System.Drawing.Size(165, 21);
            this.comboboxChannel.TabIndex = 11;
            this.comboboxChannel.DropDown += new System.EventHandler(this.comboboxChannel_DropDown);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuery.ForeColor = System.Drawing.Color.Black;
            this.buttonQuery.Location = new System.Drawing.Point(82, 125);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(100, 23);
            this.buttonQuery.TabIndex = 12;
            this.buttonQuery.Text = "Запросить";
            this.buttonQuery.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Анализатор";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnegryRes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox passDB;
        public System.Windows.Forms.TextBox userDB;
        private System.Windows.Forms.Label labelConnDB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.ComboBox comboBoxDB;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox comboxQuery;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.Button buttonQuery;
        public System.Windows.Forms.ComboBox comboboxChannel;
    }
}

