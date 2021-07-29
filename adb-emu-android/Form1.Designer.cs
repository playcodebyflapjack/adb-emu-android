
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace adb_emu_android
{
    partial class Form1
    {

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.findFileAdb = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseFileAdb = new System.Windows.Forms.Button();
            this.txtBoxPathADB = new System.Windows.Forms.TextBox();
            this.BtnClickADB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // findFileAdb
            // 
            this.findFileAdb.FileName = "openFileDialog1";
            this.findFileAdb.Filter = "adb.exe|*.exe";
            // 
            // btnBrowseFileAdb
            // 
            this.btnBrowseFileAdb.Location = new System.Drawing.Point(12, 32);
            this.btnBrowseFileAdb.Name = "btnBrowseFileAdb";
            this.btnBrowseFileAdb.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFileAdb.TabIndex = 0;
            this.btnBrowseFileAdb.Text = "Browse";
            this.btnBrowseFileAdb.UseVisualStyleBackColor = true;
            this.btnBrowseFileAdb.Click += new System.EventHandler(this.btnBrowseFileAdb_Click);
            // 
            // txtBoxPathADB
            // 
            this.txtBoxPathADB.BackColor = System.Drawing.Color.White;
            this.txtBoxPathADB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBoxPathADB.Location = new System.Drawing.Point(93, 32);
            this.txtBoxPathADB.Name = "txtBoxPathADB";
            this.txtBoxPathADB.ReadOnly = true;
            this.txtBoxPathADB.Size = new System.Drawing.Size(217, 23);
            this.txtBoxPathADB.TabIndex = 1;
            // 
            // BtnClickADB
            // 
            this.BtnClickADB.Location = new System.Drawing.Point(121, 127);
            this.BtnClickADB.Name = "BtnClickADB";
            this.BtnClickADB.Size = new System.Drawing.Size(75, 23);
            this.BtnClickADB.TabIndex = 2;
            this.BtnClickADB.Text = "Click";
            this.BtnClickADB.UseVisualStyleBackColor = true;
            this.BtnClickADB.Click += new System.EventHandler(this.BtnClickADB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Devices";
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(93, 72);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(217, 23);
            this.comboBoxDevices.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 200);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClickADB);
            this.Controls.Add(this.txtBoxPathADB);
            this.Controls.Add(this.btnBrowseFileAdb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextBoxGotFocus(object sender, EventArgs args)
        {
            HideCaret(this.txtBoxPathADB.Handle);
        }


        #endregion

        private System.Windows.Forms.OpenFileDialog findFileAdb;
        private System.Windows.Forms.Button btnBrowseFileAdb;
        private System.Windows.Forms.TextBox txtBoxPathADB;
        private Button BtnClickADB;
        private Label label1;
        private ComboBox comboBoxDevices;
    }
}

