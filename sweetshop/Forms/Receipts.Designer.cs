
namespace sweetshop
{
    partial class Receipts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipts));
            this.mainPnl = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPdv = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDateSup = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.employee = new System.Windows.Forms.Label();
            this.pdv = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblSignature2 = new System.Windows.Forms.Label();
            this.lblSignature1 = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.White;
            this.mainPnl.Controls.Add(this.dataGridView);
            this.mainPnl.Controls.Add(this.lblNum);
            this.mainPnl.Controls.Add(this.lblTitle);
            this.mainPnl.Controls.Add(this.lblPdv);
            this.mainPnl.Controls.Add(this.lblTotal);
            this.mainPnl.Controls.Add(this.lblDateSup);
            this.mainPnl.Controls.Add(this.lblPhone);
            this.mainPnl.Controls.Add(this.lblEmployee);
            this.mainPnl.Controls.Add(this.label1);
            this.mainPnl.Controls.Add(this.number);
            this.mainPnl.Controls.Add(this.employee);
            this.mainPnl.Controls.Add(this.pdv);
            this.mainPnl.Controls.Add(this.total);
            this.mainPnl.Controls.Add(this.lblSupplier);
            this.mainPnl.Controls.Add(this.lblSignature2);
            this.mainPnl.Controls.Add(this.lblSignature1);
            this.mainPnl.Controls.Add(this.supplier);
            this.mainPnl.Controls.Add(this.lblDate);
            this.mainPnl.Controls.Add(this.line);
            this.mainPnl.Controls.Add(this.pictureBox);
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPnl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPnl.Location = new System.Drawing.Point(0, 27);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(813, 707);
            this.mainPnl.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(63, 367);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(679, 264);
            this.dataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер постачання";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Повна назва товару";
            this.Column2.HeaderText = "Назва товару";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Вимір";
            this.Column3.HeaderText = "Вимір";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Кількість продукту";
            this.Column4.HeaderText = "Кількість продукту";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Ціна за одиницю";
            this.Column5.HeaderText = "Ціна за одиницю";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Всього";
            this.Column6.HeaderText = "Всього";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.lblNum.Location = new System.Drawing.Point(485, 182);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(17, 21);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "?";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.lblTitle.Location = new System.Drawing.Point(275, 182);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Накладна до замовлення";
            // 
            // lblPdv
            // 
            this.lblPdv.AutoSize = true;
            this.lblPdv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPdv.Location = new System.Drawing.Point(181, 672);
            this.lblPdv.Name = "lblPdv";
            this.lblPdv.Size = new System.Drawing.Size(12, 15);
            this.lblPdv.TabIndex = 0;
            this.lblPdv.Text = "?";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(112, 647);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(12, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "?";
            // 
            // lblDateSup
            // 
            this.lblDateSup.AutoSize = true;
            this.lblDateSup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateSup.Location = new System.Drawing.Point(170, 307);
            this.lblDateSup.Name = "lblDateSup";
            this.lblDateSup.Size = new System.Drawing.Size(12, 15);
            this.lblDateSup.TabIndex = 0;
            this.lblDateSup.Text = "?";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(128, 280);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(12, 15);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "?";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployee.Location = new System.Drawing.Point(166, 336);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(12, 15);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата постачання:";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(61, 280);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(59, 15);
            this.number.TabIndex = 0;
            this.number.Text = "Телефон:";
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employee.Location = new System.Drawing.Point(61, 336);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(96, 15);
            this.employee.TabIndex = 0;
            this.employee.Text = "Товарознавець:";
            // 
            // pdv
            // 
            this.pdv.AutoSize = true;
            this.pdv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pdv.Location = new System.Drawing.Point(61, 672);
            this.pdv.Name = "pdv";
            this.pdv.Size = new System.Drawing.Size(111, 15);
            this.pdv.TabIndex = 0;
            this.pdv.Text = "В тому числі ПДВ:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total.Location = new System.Drawing.Point(61, 647);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(45, 15);
            this.total.TabIndex = 0;
            this.total.Text = "Разом:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplier.Location = new System.Drawing.Point(159, 252);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(12, 15);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "?";
            // 
            // lblSignature2
            // 
            this.lblSignature2.AutoSize = true;
            this.lblSignature2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSignature2.Location = new System.Drawing.Point(610, 672);
            this.lblSignature2.Name = "lblSignature2";
            this.lblSignature2.Size = new System.Drawing.Size(132, 15);
            this.lblSignature2.TabIndex = 0;
            this.lblSignature2.Text = "_________________________";
            // 
            // lblSignature1
            // 
            this.lblSignature1.AutoSize = true;
            this.lblSignature1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSignature1.Location = new System.Drawing.Point(610, 647);
            this.lblSignature1.Name = "lblSignature1";
            this.lblSignature1.Size = new System.Drawing.Size(47, 15);
            this.lblSignature1.TabIndex = 0;
            this.lblSignature1.Text = "Підпис";
            // 
            // supplier
            // 
            this.supplier.AutoSize = true;
            this.supplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplier.Location = new System.Drawing.Point(61, 252);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(89, 15);
            this.supplier.TabIndex = 0;
            this.supplier.Text = "Постачальник:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(60, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(12, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "?";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.line.Location = new System.Drawing.Point(64, 214);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(678, 1);
            this.line.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(353, 70);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(95, 96);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolTip,
            this.exitToolTip});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // printToolTip
            // 
            this.printToolTip.Name = "printToolTip";
            this.printToolTip.Size = new System.Drawing.Size(119, 22);
            this.printToolTip.Text = "Печатка";
            this.printToolTip.Click += new System.EventHandler(this.printToolTip_Click);
            // 
            // exitToolTip
            // 
            this.exitToolTip.Name = "exitToolTip";
            this.exitToolTip.Size = new System.Drawing.Size(119, 22);
            this.exitToolTip.Text = "Вихід";
            // 
            // Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 734);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Receipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накладна";
            this.Load += new System.EventHandler(this.Receipts_Load);
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPnl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label supplier;
        private System.Windows.Forms.Label lblSignature2;
        private System.Windows.Forms.Label lblSignature1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblPdv;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label pdv;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label lblDateSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolTip;
        private System.Windows.Forms.ToolStripMenuItem exitToolTip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}