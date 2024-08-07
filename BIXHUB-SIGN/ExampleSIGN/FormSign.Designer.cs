﻿namespace ExampleSIGN
{
    partial class FormSign
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtSignUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._btnSaveSettings = new System.Windows.Forms.Button();
            this._txtClientGuid = new System.Windows.Forms.TextBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this._txtAuthUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtClientSecret = new System.Windows.Forms.TextBox();
            this._txtClientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtLog = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cbAddApprover = new System.Windows.Forms.CheckBox();
            this._btnCreaSessioneFEA = new System.Windows.Forms.Button();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._txtTaxCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtExternalID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._txtReturnUrl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._btnCreaSessioneFES = new System.Windows.Forms.Button();
            this._txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._btnGetSessionStatus = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this._txtSessionID = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sessionData = new System.Windows.Forms.DataGridView();
            this._txtIdeUrl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._txtIdeUrl);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this._txtSignUrl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this._btnSaveSettings);
            this.groupBox1.Controls.Add(this._txtClientGuid);
            this.groupBox1.Controls.Add(this._btnLogin);
            this.groupBox1.Controls.Add(this._txtAuthUrl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtClientSecret);
            this.groupBox1.Controls.Add(this._txtClientId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connessione Web Api";
            // 
            // _txtSignUrl
            // 
            this._txtSignUrl.Location = new System.Drawing.Point(413, 20);
            this._txtSignUrl.Name = "_txtSignUrl";
            this._txtSignUrl.Size = new System.Drawing.Size(258, 20);
            this._txtSignUrl.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sign Web Api";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Client GUID";
            // 
            // _btnSaveSettings
            // 
            this._btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSaveSettings.Location = new System.Drawing.Point(689, 99);
            this._btnSaveSettings.Margin = new System.Windows.Forms.Padding(2);
            this._btnSaveSettings.Name = "_btnSaveSettings";
            this._btnSaveSettings.Size = new System.Drawing.Size(106, 25);
            this._btnSaveSettings.TabIndex = 7;
            this._btnSaveSettings.Text = "Salva dati usati";
            this._btnSaveSettings.UseVisualStyleBackColor = true;
            this._btnSaveSettings.Click += new System.EventHandler(this._btnSaveSettings_Click);
            // 
            // _txtClientGuid
            // 
            this._txtClientGuid.Location = new System.Drawing.Point(76, 78);
            this._txtClientGuid.Name = "_txtClientGuid";
            this._txtClientGuid.Size = new System.Drawing.Size(480, 20);
            this._txtClientGuid.TabIndex = 3;
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(582, 99);
            this._btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(105, 25);
            this._btnLogin.TabIndex = 6;
            this._btnLogin.Text = "Login";
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // _txtAuthUrl
            // 
            this._txtAuthUrl.Location = new System.Drawing.Point(75, 18);
            this._txtAuthUrl.Name = "_txtAuthUrl";
            this._txtAuthUrl.Size = new System.Drawing.Size(258, 20);
            this._txtAuthUrl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client Secret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client ID";
            // 
            // _txtClientSecret
            // 
            this._txtClientSecret.Location = new System.Drawing.Point(332, 104);
            this._txtClientSecret.Name = "_txtClientSecret";
            this._txtClientSecret.PasswordChar = '*';
            this._txtClientSecret.Size = new System.Drawing.Size(223, 20);
            this._txtClientSecret.TabIndex = 5;
            // 
            // _txtClientId
            // 
            this._txtClientId.Location = new System.Drawing.Point(75, 104);
            this._txtClientId.Name = "_txtClientId";
            this._txtClientId.Size = new System.Drawing.Size(159, 20);
            this._txtClientId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auth Web Api";
            // 
            // _txtLog
            // 
            this._txtLog.AcceptsReturn = true;
            this._txtLog.AcceptsTab = true;
            this._txtLog.AllowDrop = true;
            this._txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtLog.Location = new System.Drawing.Point(3, 3);
            this._txtLog.Margin = new System.Windows.Forms.Padding(2);
            this._txtLog.Multiline = true;
            this._txtLog.Name = "_txtLog";
            this._txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtLog.Size = new System.Drawing.Size(789, 211);
            this._txtLog.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._cbAddApprover);
            this.groupBox3.Controls.Add(this._btnCreaSessioneFEA);
            this.groupBox3.Controls.Add(this._txtDescription);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this._txtTaxCode);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this._txtExternalID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this._txtReturnUrl);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this._txtPhoneNumber);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this._btnCreaSessioneFES);
            this.groupBox3.Controls.Add(this._txtMail);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 140);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Creazione nuova sessione di firma FES";
            // 
            // _cbAddApprover
            // 
            this._cbAddApprover.AutoSize = true;
            this._cbAddApprover.Location = new System.Drawing.Point(413, 99);
            this._cbAddApprover.Name = "_cbAddApprover";
            this._cbAddApprover.Size = new System.Drawing.Size(124, 17);
            this._cbAddApprover.TabIndex = 30;
            this._cbAddApprover.Text = "Inserisci approvatore";
            this._cbAddApprover.UseVisualStyleBackColor = true;
            // 
            // _btnCreaSessioneFEA
            // 
            this._btnCreaSessioneFEA.Location = new System.Drawing.Point(684, 94);
            this._btnCreaSessioneFEA.Margin = new System.Windows.Forms.Padding(2);
            this._btnCreaSessioneFEA.Name = "_btnCreaSessioneFEA";
            this._btnCreaSessioneFEA.Size = new System.Drawing.Size(112, 25);
            this._btnCreaSessioneFEA.TabIndex = 29;
            this._btnCreaSessioneFEA.Text = "Crea Sessione FEA";
            this._btnCreaSessioneFEA.UseVisualStyleBackColor = true;
            this._btnCreaSessioneFEA.Click += new System.EventHandler(this._btnCreaSessioneFEA_Click);
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(494, 43);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(302, 20);
            this._txtDescription.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Description";
            // 
            // _txtTaxCode
            // 
            this._txtTaxCode.Location = new System.Drawing.Point(75, 44);
            this._txtTaxCode.Name = "_txtTaxCode";
            this._txtTaxCode.Size = new System.Drawing.Size(257, 20);
            this._txtTaxCode.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "TaxCode";
            // 
            // _txtExternalID
            // 
            this._txtExternalID.Location = new System.Drawing.Point(495, 69);
            this._txtExternalID.Name = "_txtExternalID";
            this._txtExternalID.Size = new System.Drawing.Size(302, 20);
            this._txtExternalID.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "ExternalID";
            // 
            // _txtReturnUrl
            // 
            this._txtReturnUrl.Location = new System.Drawing.Point(76, 70);
            this._txtReturnUrl.Name = "_txtReturnUrl";
            this._txtReturnUrl.Size = new System.Drawing.Size(257, 20);
            this._txtReturnUrl.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Return Url";
            // 
            // _txtPhoneNumber
            // 
            this._txtPhoneNumber.Location = new System.Drawing.Point(494, 17);
            this._txtPhoneNumber.Name = "_txtPhoneNumber";
            this._txtPhoneNumber.Size = new System.Drawing.Size(302, 20);
            this._txtPhoneNumber.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number";
            // 
            // _btnCreaSessioneFES
            // 
            this._btnCreaSessioneFES.Location = new System.Drawing.Point(559, 94);
            this._btnCreaSessioneFES.Margin = new System.Windows.Forms.Padding(2);
            this._btnCreaSessioneFES.Name = "_btnCreaSessioneFES";
            this._btnCreaSessioneFES.Size = new System.Drawing.Size(112, 25);
            this._btnCreaSessioneFES.TabIndex = 10;
            this._btnCreaSessioneFES.Text = "Crea Sessione FES";
            this._btnCreaSessioneFES.UseVisualStyleBackColor = true;
            this._btnCreaSessioneFES.Click += new System.EventHandler(this._btnCreaSessioneFES_Click);
            // 
            // _txtMail
            // 
            this._txtMail.Location = new System.Drawing.Point(75, 18);
            this._txtMail.Name = "_txtMail";
            this._txtMail.Size = new System.Drawing.Size(257, 20);
            this._txtMail.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mail";
            // 
            // _btnGetSessionStatus
            // 
            this._btnGetSessionStatus.Location = new System.Drawing.Point(10, 29);
            this._btnGetSessionStatus.Margin = new System.Windows.Forms.Padding(2);
            this._btnGetSessionStatus.Name = "_btnGetSessionStatus";
            this._btnGetSessionStatus.Size = new System.Drawing.Size(149, 25);
            this._btnGetSessionStatus.TabIndex = 12;
            this._btnGetSessionStatus.Text = "Reperimento elenco";
            this._btnGetSessionStatus.UseVisualStyleBackColor = true;
            this._btnGetSessionStatus.Click += new System.EventHandler(this._btnGetSessionStatus_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this._txtSessionID);
            this.groupBox4.Controls.Add(this._btnGetSessionStatus);
            this.groupBox4.Location = new System.Drawing.Point(12, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(804, 69);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lettura sessioni di firma";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 28);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 25);
            this.button3.TabIndex = 17;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 25);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancella sessione";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Lettura info sessione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Session ID";
            // 
            // _txtSessionID
            // 
            this._txtSessionID.Location = new System.Drawing.Point(318, 32);
            this._txtSessionID.Name = "_txtSessionID";
            this._txtSessionID.Size = new System.Drawing.Size(159, 20);
            this._txtSessionID.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 374);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 243);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._txtLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sessionData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sessioni";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sessionData
            // 
            this.sessionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionData.Location = new System.Drawing.Point(3, 3);
            this.sessionData.Name = "sessionData";
            this.sessionData.Size = new System.Drawing.Size(789, 245);
            this.sessionData.TabIndex = 0;
            this.sessionData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sessionData_CellContentClick);
            // 
            // _txtIdeUrl
            // 
            this._txtIdeUrl.Location = new System.Drawing.Point(413, 46);
            this._txtIdeUrl.Name = "_txtIdeUrl";
            this._txtIdeUrl.Size = new System.Drawing.Size(258, 20);
            this._txtIdeUrl.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Ide Web Api";
            // 
            // FormSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 629);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(650, 39);
            this.Name = "FormSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign example";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnLogin;
        private System.Windows.Forms.TextBox _txtAuthUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtClientSecret;
        private System.Windows.Forms.TextBox _txtClientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button _btnCreaSessioneFES;
        private System.Windows.Forms.TextBox _txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _btnSaveSettings;
        private System.Windows.Forms.TextBox _txtExternalID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtReturnUrl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _txtClientGuid;
        private System.Windows.Forms.TextBox _txtTaxCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnGetSessionStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _txtSessionID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView sessionData;
        private System.Windows.Forms.TextBox _txtSignUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button _btnCreaSessioneFEA;
        private System.Windows.Forms.CheckBox _cbAddApprover;
        private System.Windows.Forms.TextBox _txtIdeUrl;
        private System.Windows.Forms.Label label13;
    }
}

