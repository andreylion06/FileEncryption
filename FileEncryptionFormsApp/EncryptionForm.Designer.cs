namespace FileEncryptionFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.button_Browse = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label_FilePath = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox_ProcessInfo = new System.Windows.Forms.GroupBox();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Progress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Password.Location = new System.Drawing.Point(11, 72);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(95, 25);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Enabled = false;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Password.Location = new System.Drawing.Point(112, 69);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(222, 33);
            this.textBox_Password.TabIndex = 9;
            this.textBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Password_KeyPress);
            // 
            // button_Start
            // 
            this.button_Start.Enabled = false;
            this.button_Start.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Start.Location = new System.Drawing.Point(340, 69);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(208, 33);
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
            this.groupBox_ProcessInfo.Controls.Add(this.label_Time);
            this.groupBox_ProcessInfo.Controls.Add(this.label_Progress);
            this.groupBox_ProcessInfo.Controls.Add(this.progressBar);
            this.groupBox_ProcessInfo.Location = new System.Drawing.Point(14, 108);
            this.groupBox_ProcessInfo.Name = "groupBox_ProcessInfo";
            this.groupBox_ProcessInfo.Size = new System.Drawing.Size(534, 75);
            this.groupBox_ProcessInfo.TabIndex = 11;
            this.groupBox_ProcessInfo.TabStop = false;
            this.groupBox_ProcessInfo.Text = "Process Info";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Time.Location = new System.Drawing.Point(403, 43);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(66, 17);
            this.label_Time.TabIndex = 13;
            this.label_Time.Text = "Time: 0.0s";
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 193);
            this.Controls.Add(this.groupBox_ProcessInfo);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
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
        private Label label_Password;
        private TextBox textBox_Password;
        private Button button_Start;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private GroupBox groupBox_ProcessInfo;
        private Label label_Time;
        private Label label_Progress;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}