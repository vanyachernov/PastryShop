
namespace sweetshop
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.mainPnl = new System.Windows.Forms.Panel();
            this.lblNewEmpl = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.mainPnl.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.mainPnl.Controls.Add(this.lblNewEmpl);
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPnl.Location = new System.Drawing.Point(0, 0);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(498, 117);
            this.mainPnl.TabIndex = 1;
            // 
            // lblNewEmpl
            // 
            this.lblNewEmpl.AutoSize = true;
            this.lblNewEmpl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNewEmpl.ForeColor = System.Drawing.Color.White;
            this.lblNewEmpl.Location = new System.Drawing.Point(33, 47);
            this.lblNewEmpl.Name = "lblNewEmpl";
            this.lblNewEmpl.Size = new System.Drawing.Size(134, 21);
            this.lblNewEmpl.TabIndex = 0;
            this.lblNewEmpl.Text = "Новий працівник";
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.Controls.Add(this.cmbPost);
            this.pnl.Controls.Add(this.panel3);
            this.pnl.Controls.Add(this.lblBirthDate);
            this.pnl.Controls.Add(this.panel2);
            this.pnl.Controls.Add(this.panel4);
            this.pnl.Controls.Add(this.panel5);
            this.pnl.Controls.Add(this.panel1);
            this.pnl.Controls.Add(this.pnl4);
            this.pnl.Controls.Add(this.txtPhone);
            this.pnl.Controls.Add(this.txtAddress);
            this.pnl.Controls.Add(this.birthDate);
            this.pnl.Controls.Add(this.txtSurname);
            this.pnl.Controls.Add(this.txtName);
            this.pnl.Controls.Add(this.btnSave);
            this.pnl.Controls.Add(this.lblPost);
            this.pnl.Controls.Add(this.lblName);
            this.pnl.Location = new System.Drawing.Point(45, 154);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(411, 476);
            this.pnl.TabIndex = 0;
            // 
            // cmbPost
            // 
            this.cmbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Items.AddRange(new object[] {
            "",
            "Продавець-консультант",
            "Адміністратор"});
            this.cmbPost.Location = new System.Drawing.Point(51, 246);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(306, 23);
            this.cmbPost.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel3.Location = new System.Drawing.Point(51, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 2);
            this.panel3.TabIndex = 16;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.White;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthDate.Location = new System.Drawing.Point(48, 161);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(106, 15);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Дата народження:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(51, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 2);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel4.Location = new System.Drawing.Point(51, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 2);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel5.Location = new System.Drawing.Point(51, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 2);
            this.panel5.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel1.Location = new System.Drawing.Point(51, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 2);
            this.panel1.TabIndex = 16;
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl4.Location = new System.Drawing.Point(51, 83);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(306, 2);
            this.pnl4.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(51, 312);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(306, 16);
            this.txtPhone.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Location = new System.Drawing.Point(51, 378);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(306, 16);
            this.txtAddress.TabIndex = 15;
            // 
            // birthDate
            // 
            this.birthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birthDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDate.Location = new System.Drawing.Point(51, 190);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(306, 16);
            this.birthDate.TabIndex = 15;
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.Location = new System.Drawing.Point(51, 125);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(306, 16);
            this.txtSurname.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(51, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(306, 16);
            this.txtName.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(51, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.BackColor = System.Drawing.Color.White;
            this.lblPost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPost.Location = new System.Drawing.Point(48, 223);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(50, 15);
            this.lblPost.TabIndex = 7;
            this.lblPost.Text = "Посада:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(48, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Ім\'я:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(93, 502);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Адреса:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.White;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(93, 440);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 15);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Телефон:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.White;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(93, 253);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 15);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Прізвище:";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 665);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.mainPnl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Працівник";
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Label lblNewEmpl;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox birthDate;
    }
}