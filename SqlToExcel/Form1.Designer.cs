﻿namespace SqlToExcel
{
    partial class Form1
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
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblSorgu = new System.Windows.Forms.Label();
            this.txtSorgu = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.rndbtnXLSX = new System.Windows.Forms.RadioButton();
            this.rndbtnXLT = new System.Windows.Forms.RadioButton();
            this.rndbtnXLS = new System.Windows.Forms.RadioButton();
            this.rndbtnCSV = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServerName.Location = new System.Drawing.Point(13, 13);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(133, 25);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.Location = new System.Drawing.Point(13, 53);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(66, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.Location = new System.Drawing.Point(13, 99);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(104, 25);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password:";
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtServerName.Location = new System.Drawing.Point(162, 10);
            this.txtServerName.Multiline = true;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(317, 31);
            this.txtServerName.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogin.Location = new System.Drawing.Point(162, 50);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(317, 31);
            this.txtLogin.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(162, 96);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(317, 31);
            this.txtPass.TabIndex = 5;
            // 
            // lblSorgu
            // 
            this.lblSorgu.AutoSize = true;
            this.lblSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSorgu.Location = new System.Drawing.Point(13, 215);
            this.lblSorgu.Name = "lblSorgu";
            this.lblSorgu.Size = new System.Drawing.Size(71, 25);
            this.lblSorgu.TabIndex = 6;
            this.lblSorgu.Text = "Sorgu:";
            // 
            // txtSorgu
            // 
            this.txtSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorgu.Location = new System.Drawing.Point(101, 212);
            this.txtSorgu.Multiline = true;
            this.txtSorgu.Name = "txtSorgu";
            this.txtSorgu.Size = new System.Drawing.Size(535, 147);
            this.txtSorgu.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(497, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 117);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Connect";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDatabase.Location = new System.Drawing.Point(13, 157);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(102, 25);
            this.lblDatabase.TabIndex = 9;
            this.lblDatabase.Text = "Database:";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(162, 154);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(317, 33);
            this.cmbDatabase.TabIndex = 10;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // rndbtnXLSX
            // 
            this.rndbtnXLSX.AutoSize = true;
            this.rndbtnXLSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rndbtnXLSX.Location = new System.Drawing.Point(101, 383);
            this.rndbtnXLSX.Name = "rndbtnXLSX";
            this.rndbtnXLSX.Size = new System.Drawing.Size(90, 29);
            this.rndbtnXLSX.TabIndex = 11;
            this.rndbtnXLSX.TabStop = true;
            this.rndbtnXLSX.Text = "XLSX";
            this.rndbtnXLSX.UseVisualStyleBackColor = true;
            // 
            // rndbtnXLT
            // 
            this.rndbtnXLT.AutoSize = true;
            this.rndbtnXLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rndbtnXLT.Location = new System.Drawing.Point(260, 383);
            this.rndbtnXLT.Name = "rndbtnXLT";
            this.rndbtnXLT.Size = new System.Drawing.Size(74, 29);
            this.rndbtnXLT.TabIndex = 12;
            this.rndbtnXLT.TabStop = true;
            this.rndbtnXLT.Text = "XLT";
            this.rndbtnXLT.UseVisualStyleBackColor = true;
            // 
            // rndbtnXLS
            // 
            this.rndbtnXLS.AutoSize = true;
            this.rndbtnXLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rndbtnXLS.Location = new System.Drawing.Point(415, 383);
            this.rndbtnXLS.Name = "rndbtnXLS";
            this.rndbtnXLS.Size = new System.Drawing.Size(75, 29);
            this.rndbtnXLS.TabIndex = 13;
            this.rndbtnXLS.TabStop = true;
            this.rndbtnXLS.Text = "XLS";
            this.rndbtnXLS.UseVisualStyleBackColor = true;
            // 
            // rndbtnCSV
            // 
            this.rndbtnCSV.AutoSize = true;
            this.rndbtnCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rndbtnCSV.Location = new System.Drawing.Point(557, 383);
            this.rndbtnCSV.Name = "rndbtnCSV";
            this.rndbtnCSV.Size = new System.Drawing.Size(79, 29);
            this.rndbtnCSV.TabIndex = 14;
            this.rndbtnCSV.TabStop = true;
            this.rndbtnCSV.Text = "CSV";
            this.rndbtnCSV.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExport.Location = new System.Drawing.Point(497, 429);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(139, 69);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 515);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.rndbtnCSV);
            this.Controls.Add(this.rndbtnXLS);
            this.Controls.Add(this.rndbtnXLT);
            this.Controls.Add(this.rndbtnXLSX);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSorgu);
            this.Controls.Add(this.lblSorgu);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblServerName);
            this.Name = "Form1";
            this.Text = "SQL TO EXCEL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblSorgu;
        private System.Windows.Forms.TextBox txtSorgu;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.RadioButton rndbtnXLSX;
        private System.Windows.Forms.RadioButton rndbtnXLT;
        private System.Windows.Forms.RadioButton rndbtnXLS;
        private System.Windows.Forms.RadioButton rndbtnCSV;
        private System.Windows.Forms.Button btnExport;
    }
}

