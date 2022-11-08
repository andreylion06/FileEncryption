﻿namespace FileEncryptionFormsApp
{
    partial class EncryptionForm
    {
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
            this.button_Browse = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label_FilePath = new System.Windows.Forms.Label();
            this.radioButton_Encrypt = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox_ProcessInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Progress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox_ProcessInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Browse
            // 
            this.button_Browse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Browse.Location = new System.Drawing.Point(450, 30);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(98, 33);
            this.button_Browse.TabIndex = 5;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Enabled = false;
            this.textBox_FilePath.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_FilePath.Location = new System.Drawing.Point(14, 30);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(430, 33);
            this.textBox_FilePath.TabIndex = 4;
            // 
            // label_FilePath
            // 
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_FilePath.Location = new System.Drawing.Point(14, 10);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(60, 17);
            this.label_FilePath.TabIndex = 3;
            this.label_FilePath.Text = "File path:";
            // 
            // radioButton_Encrypt
            // 
            this.radioButton_Encrypt.AutoSize = true;
            this.radioButton_Encrypt.Checked = true;
            this.radioButton_Encrypt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Encrypt.Location = new System.Drawing.Point(12, 69);
            this.radioButton_Encrypt.Name = "radioButton_Encrypt";
            this.radioButton_Encrypt.Size = new System.Drawing.Size(90, 29);
            this.radioButton_Encrypt.TabIndex = 6;
            this.radioButton_Encrypt.TabStop = true;
            this.radioButton_Encrypt.Text = "Encrypt";
            this.radioButton_Encrypt.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(126, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 29);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "Decrypt";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Password.Location = new System.Drawing.Point(14, 107);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(95, 25);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Password.Location = new System.Drawing.Point(115, 104);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(206, 33);
            this.textBox_Password.TabIndex = 9;
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Start.Location = new System.Drawing.Point(340, 81);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(208, 56);
            this.button_Start.TabIndex = 10;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // groupBox_ProcessInfo
            // 
            this.groupBox_ProcessInfo.Controls.Add(this.label1);
            this.groupBox_ProcessInfo.Controls.Add(this.label_Progress);
            this.groupBox_ProcessInfo.Controls.Add(this.progressBar);
            this.groupBox_ProcessInfo.Location = new System.Drawing.Point(14, 154);
            this.groupBox_ProcessInfo.Name = "groupBox_ProcessInfo";
            this.groupBox_ProcessInfo.Size = new System.Drawing.Size(534, 75);
            this.groupBox_ProcessInfo.TabIndex = 11;
            this.groupBox_ProcessInfo.TabStop = false;
            this.groupBox_ProcessInfo.Text = "Process Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(370, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Appr. time:";
            // 
            // label_Progress
            // 
            this.label_Progress.AutoSize = true;
            this.label_Progress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Progress.Location = new System.Drawing.Point(379, 22);
            this.label_Progress.Name = "label_Progress";
            this.label_Progress.Size = new System.Drawing.Size(63, 17);
            this.label_Progress.TabIndex = 12;
            this.label_Progress.Text = "Progress:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 22);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(339, 38);
            this.progressBar.TabIndex = 0;
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 243);
            this.Controls.Add(this.groupBox_ProcessInfo);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton_Encrypt);
            this.Controls.Add(this.button_Browse);
            this.Controls.Add(this.textBox_FilePath);
            this.Controls.Add(this.label_FilePath);
            this.Name = "EncryptionForm";
            this.Text = "Form1";
            this.groupBox_ProcessInfo.ResumeLayout(false);
            this.groupBox_ProcessInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Browse;
        private TextBox textBox_FilePath;
        private Label label_FilePath;
        private RadioButton radioButton_Encrypt;
        private RadioButton radioButton1;
        private Label label_Password;
        private TextBox textBox_Password;
        private Button button_Start;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private GroupBox groupBox_ProcessInfo;
        private Label label1;
        private Label label_Progress;
        private ProgressBar progressBar;
    }
}