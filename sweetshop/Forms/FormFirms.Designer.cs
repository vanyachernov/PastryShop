
namespace sweetshop
{
    partial class FormFirms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFirm = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.clearFields = new System.Windows.Forms.Label();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFirm = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFirmToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblFirms = new System.Windows.Forms.Label();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Controls.Add(this.txtCity);
            this.pnl2.Controls.Add(this.txtFirm);
            this.pnl2.Controls.Add(this.btnEdit);
            this.pnl2.Controls.Add(this.clearFields);
            this.pnl2.Controls.Add(this.pnl4);
            this.pnl2.Controls.Add(this.pnl3);
            this.pnl2.Controls.Add(this.lblCity);
            this.pnl2.Controls.Add(this.lblFirm);
            this.pnl2.Controls.Add(this.dataGridView);
            this.pnl2.Controls.Add(this.btnNew);
            this.pnl2.Location = new System.Drawing.Point(38, 149);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(524, 232);
            this.pnl2.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCity.Location = new System.Drawing.Point(313, 101);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(193, 16);
            this.txtCity.TabIndex = 22;
            // 
            // txtFirm
            // 
            this.txtFirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirm.Location = new System.Drawing.Point(313, 44);
            this.txtFirm.Name = "txtFirm";
            this.txtFirm.Size = new System.Drawing.Size(193, 16);
            this.txtFirm.TabIndex = 22;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(314, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(192, 27);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Змінити";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // clearFields
            // 
            this.clearFields.AutoSize = true;
            this.clearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFields.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFields.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.clearFields.Location = new System.Drawing.Point(448, 141);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(57, 13);
            this.clearFields.TabIndex = 21;
            this.clearFields.Text = "Очистити";
            this.clearFields.Click += new System.EventHandler(this.clearFields_Click);
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl4.Location = new System.Drawing.Point(313, 120);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(192, 2);
            this.pnl4.TabIndex = 0;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl3.Location = new System.Drawing.Point(313, 63);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(192, 2);
            this.pnl3.TabIndex = 0;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(310, 78);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(126, 15);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Місце розташування:";
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirm.Location = new System.Drawing.Point(310, 21);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(82, 15);
            this.lblFirm.TabIndex = 0;
            this.lblFirm.Text = "Назва фірми:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(26, 21);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(269, 195);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id_firm";
            this.Column3.HeaderText = "#";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "firm_name";
            this.Column1.HeaderText = "Назва фірми";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "firm_city";
            this.Column2.HeaderText = "Місце розміщення";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFirmToolTip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 26);
            // 
            // deleteFirmToolTip
            // 
            this.deleteFirmToolTip.Name = "deleteFirmToolTip";
            this.deleteFirmToolTip.Size = new System.Drawing.Size(163, 22);
            this.deleteFirmToolTip.Text = "Видалити фірму";
            this.deleteFirmToolTip.Click += new System.EventHandler(this.deleteFirmToolTip_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(314, 159);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(192, 27);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Створити";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl1.Controls.Add(this.lblFirms);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(602, 117);
            this.pnl1.TabIndex = 23;
            // 
            // lblFirms
            // 
            this.lblFirms.AutoSize = true;
            this.lblFirms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFirms.ForeColor = System.Drawing.Color.White;
            this.lblFirms.Location = new System.Drawing.Point(44, 47);
            this.lblFirms.Name = "lblFirms";
            this.lblFirms.Size = new System.Drawing.Size(140, 21);
            this.lblFirms.TabIndex = 0;
            this.lblFirms.Text = "Фірми-виробники";
            // 
            // FormFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 408);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormFirms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фірми-виробники";
            this.Shown += new System.EventHandler(this.FormFirms_Shown);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.TextBox txtFirm;
        private System.Windows.Forms.Label clearFields;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Label lblFirm;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblFirms;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteFirmToolTip;
    }
}