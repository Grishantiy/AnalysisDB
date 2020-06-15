namespace AppSql
{
    partial class Sign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelConnState = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passDB = new System.Windows.Forms.TextBox();
            this.userDB = new System.Windows.Forms.TextBox();
            this.labelConnDB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelConnState);
            this.panel1.Controls.Add(this.labelExit);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.comboBoxServer);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.passDB);
            this.panel1.Controls.Add(this.userDB);
            this.panel1.Controls.Add(this.labelConnDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 162);
            this.panel1.TabIndex = 2;
            // 
            // labelConnState
            // 
            this.labelConnState.AutoSize = true;
            this.labelConnState.Location = new System.Drawing.Point(39, 146);
            this.labelConnState.Name = "labelConnState";
            this.labelConnState.Size = new System.Drawing.Size(0, 13);
            this.labelConnState.TabIndex = 10;
            this.labelConnState.Visible = false;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Location = new System.Drawing.Point(168, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(12, 13);
            this.labelExit.TabIndex = 9;
            this.labelExit.Text = "х";
            this.labelExit.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AppSql.Properties.Resources.sql;
            this.pictureBox4.Location = new System.Drawing.Point(5, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(36, 26);
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
            this.buttonLogin.Location = new System.Drawing.Point(43, 120);
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
            this.pictureBox3.Location = new System.Drawing.Point(8, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppSql.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(8, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // passDB
            // 
            this.passDB.Location = new System.Drawing.Point(36, 85);
            this.passDB.Name = "passDB";
            this.passDB.Size = new System.Drawing.Size(121, 20);
            this.passDB.TabIndex = 3;
            this.passDB.UseSystemPasswordChar = true;
            // 
            // userDB
            // 
            this.userDB.Location = new System.Drawing.Point(36, 54);
            this.userDB.Name = "userDB";
            this.userDB.Size = new System.Drawing.Size(121, 20);
            this.userDB.TabIndex = 2;
            // 
            // labelConnDB
            // 
            this.labelConnDB.AutoSize = true;
            this.labelConnDB.Location = new System.Drawing.Point(39, 6);
            this.labelConnDB.Name = "labelConnDB";
            this.labelConnDB.Size = new System.Drawing.Size(109, 13);
            this.labelConnDB.TabIndex = 1;
            this.labelConnDB.Text = "Подключение к SQL";
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 162);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox passDB;
        public System.Windows.Forms.TextBox userDB;
        private System.Windows.Forms.Label labelConnDB;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelConnState;
    }
}