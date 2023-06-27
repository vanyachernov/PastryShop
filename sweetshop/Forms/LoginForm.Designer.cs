
namespace sweetshop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logPanel = new System.Windows.Forms.Panel();
            this.authLabel = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.logElement3 = new System.Windows.Forms.Panel();
            this.logPict3 = new System.Windows.Forms.PictureBox();
            this.logElement2 = new System.Windows.Forms.Panel();
            this.logPict2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Label();
            this.clearFields = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logPict3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPict2)).BeginInit();
            this.SuspendLayout();
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.logPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logPanel.BackgroundImage")));
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logPanel.Location = new System.Drawing.Point(0, 0);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(300, 98);
            this.logPanel.TabIndex = 0;
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.BackColor = System.Drawing.Color.White;
            this.authLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.authLabel.Location = new System.Drawing.Point(88, 127);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(123, 25);
            this.authLabel.TabIndex = 0;
            this.authLabel.Text = "Авторизація";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(59, 239);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsername.Location = new System.Drawing.Point(60, 186);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // logElement3
            // 
            this.logElement3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.logElement3.Location = new System.Drawing.Point(33, 262);
            this.logElement3.Name = "logElement3";
            this.logElement3.Size = new System.Drawing.Size(230, 1);
            this.logElement3.TabIndex = 0;
            // 
            // logPict3
            // 
            this.logPict3.Image = ((System.Drawing.Image)(resources.GetObject("logPict3.Image")));
            this.logPict3.Location = new System.Drawing.Point(33, 235);
            this.logPict3.Name = "logPict3";
            this.logPict3.Size = new System.Drawing.Size(20, 24);
            this.logPict3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logPict3.TabIndex = 15;
            this.logPict3.TabStop = false;
            // 
            // logElement2
            // 
            this.logElement2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.logElement2.Location = new System.Drawing.Point(33, 208);
            this.logElement2.Name = "logElement2";
            this.logElement2.Size = new System.Drawing.Size(230, 1);
            this.logElement2.TabIndex = 0;
            // 
            // logPict2
            // 
            this.logPict2.Image = ((System.Drawing.Image)(resources.GetObject("logPict2.Image")));
            this.logPict2.Location = new System.Drawing.Point(33, 181);
            this.logPict2.Name = "logPict2";
            this.logPict2.Size = new System.Drawing.Size(20, 24);
            this.logPict2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logPict2.TabIndex = 13;
            this.logPict2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(127, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 13);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Вийти";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // clearFields
            // 
            this.clearFields.AutoSize = true;
            this.clearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFields.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFields.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.clearFields.Location = new System.Drawing.Point(208, 285);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(57, 13);
            this.clearFields.TabIndex = 0;
            this.clearFields.Text = "Очистити";
            this.clearFields.Click += new System.EventHandler(this.clearFields_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.btnLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLog.BackgroundImage")));
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(33, 304);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(230, 42);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Вхід";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 394);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.clearFields);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.logElement3);
            this.Controls.Add(this.logPict3);
            this.Controls.Add(this.logElement2);
            this.Controls.Add(this.logPict2);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.logPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кондитерська";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logPict3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPict2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel logElement3;
        private System.Windows.Forms.PictureBox logPict3;
        private System.Windows.Forms.Panel logElement2;
        private System.Windows.Forms.PictureBox logPict2;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label clearFields;
        private System.Windows.Forms.Button btnLog;
    }
}