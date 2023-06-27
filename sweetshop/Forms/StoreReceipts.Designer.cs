
namespace sweetshop
{
    partial class StoreReceipts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreReceipts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRec = new System.Windows.Forms.Label();
            this.totalSum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.Label();
            this.checkOut = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.employee = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.mainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRec.Location = new System.Drawing.Point(97, 77);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(81, 13);
            this.lblRec.TabIndex = 0;
            this.lblRec.Text = "КАСОВИЙ ЧЕК";
            // 
            // totalSum
            // 
            this.totalSum.AutoSize = true;
            this.totalSum.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.totalSum.Location = new System.Drawing.Point(12, 98);
            this.totalSum.Name = "totalSum";
            this.totalSum.Size = new System.Drawing.Size(123, 13);
            this.totalSum.TabIndex = 0;
            this.totalSum.Text = "Проміжний підсумок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "-------------------------------------------------------------------";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(123, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(32, 31);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.lblTitle.Location = new System.Drawing.Point(100, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sweet Shop";
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.White;
            this.mainPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPnl.Controls.Add(this.lblTotal);
            this.mainPnl.Controls.Add(this.total);
            this.mainPnl.Controls.Add(this.dataGridView);
            this.mainPnl.Controls.Add(this.pictureBox);
            this.mainPnl.Controls.Add(this.lblRec);
            this.mainPnl.Controls.Add(this.time);
            this.mainPnl.Controls.Add(this.checkOut);
            this.mainPnl.Controls.Add(this.date);
            this.mainPnl.Controls.Add(this.lblTime);
            this.mainPnl.Controls.Add(this.lblCheckOut);
            this.mainPnl.Controls.Add(this.order);
            this.mainPnl.Controls.Add(this.lblDate);
            this.mainPnl.Controls.Add(this.employee);
            this.mainPnl.Controls.Add(this.label10);
            this.mainPnl.Controls.Add(this.lblOrder);
            this.mainPnl.Controls.Add(this.lblEmployee);
            this.mainPnl.Controls.Add(this.lblTotalSum);
            this.mainPnl.Controls.Add(this.totalSum);
            this.mainPnl.Controls.Add(this.lblTitle);
            this.mainPnl.Controls.Add(this.label7);
            this.mainPnl.Controls.Add(this.label3);
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPnl.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.mainPnl.Location = new System.Drawing.Point(0, 24);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(283, 377);
            this.mainPnl.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(58, 315);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(12, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "?";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total.Location = new System.Drawing.Point(12, 315);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(45, 15);
            this.total.TabIndex = 0;
            this.total.Text = "Разом:";
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
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(14, 170);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(257, 136);
            this.dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Повна назва товару";
            this.Column2.FillWeight = 151.0827F;
            this.Column2.HeaderText = "Назва продукту";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Кількість продукту";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.FillWeight = 88.00354F;
            this.Column3.HeaderText = "Кількість";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Всього";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.FillWeight = 60.9137F;
            this.Column4.HeaderText = "Ціна";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.time.Location = new System.Drawing.Point(120, 335);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(25, 13);
            this.time.TabIndex = 0;
            this.time.Text = "Час";
            // 
            // checkOut
            // 
            this.checkOut.AutoSize = true;
            this.checkOut.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.checkOut.Location = new System.Drawing.Point(11, 355);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(45, 13);
            this.checkOut.TabIndex = 0;
            this.checkOut.Text = "Каса №";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.date.Location = new System.Drawing.Point(11, 335);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(32, 13);
            this.date.TabIndex = 0;
            this.date.Text = "Дата";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.lblTime.Location = new System.Drawing.Point(149, 335);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(12, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "?";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.lblCheckOut.Location = new System.Drawing.Point(58, 355);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(12, 13);
            this.lblCheckOut.TabIndex = 0;
            this.lblCheckOut.Text = "?";
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.order.Location = new System.Drawing.Point(12, 137);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(87, 13);
            this.order.TabIndex = 0;
            this.order.Text = "Замовлення №";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.lblDate.Location = new System.Drawing.Point(44, 335);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(12, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "?";
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.employee.Location = new System.Drawing.Point(12, 118);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(41, 13);
            this.employee.TabIndex = 0;
            this.employee.Text = "Касир:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.label10.Location = new System.Drawing.Point(92, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "?";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.lblOrder.Location = new System.Drawing.Point(100, 137);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(12, 13);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "?";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.lblEmployee.Location = new System.Drawing.Point(53, 118);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(12, 13);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "?";
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Font = new System.Drawing.Font("Segoe UI", 7.6F);
            this.lblTotalSum.Location = new System.Drawing.Point(135, 98);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(12, 13);
            this.lblTotalSum.TabIndex = 0;
            this.lblTotalSum.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "-------------------------------------------------------------------";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.printToolTip.Size = new System.Drawing.Size(102, 22);
            this.printToolTip.Text = "Друк";
            this.printToolTip.Click += new System.EventHandler(this.printToolTip_Click);
            // 
            // exitToolTip
            // 
            this.exitToolTip.Name = "exitToolTip";
            this.exitToolTip.Size = new System.Drawing.Size(102, 22);
            this.exitToolTip.Text = "Вихід";
            this.exitToolTip.Click += new System.EventHandler(this.exitToolTip_Click);
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
            // StoreReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 401);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StoreReceipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чек до замовлення";
            this.Shown += new System.EventHandler(this.StoreReceipts_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.Label totalSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label checkOut;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolTip;
        private System.Windows.Forms.ToolStripMenuItem exitToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}