
namespace sweetshop
{
    partial class FormConfectionery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfectionery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConf = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewCat = new System.Windows.Forms.Button();
            this.btnNewFirm = new System.Windows.Forms.Button();
            this.btnNewProd = new System.Windows.Forms.Button();
            this.gBTwo = new System.Windows.Forms.GroupBox();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.txtDescribeProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.lblNameProd = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editProductToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.gBOne = new System.Windows.Forms.GroupBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.buttClear = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblMaxVal = new System.Windows.Forms.Label();
            this.lblMinVal = new System.Windows.Forms.Label();
            this.lblSearchData = new System.Windows.Forms.Label();
            this.txtSearchByValues = new System.Windows.Forms.TextBox();
            this.txtValueMax = new System.Windows.Forms.TextBox();
            this.txtValueMin = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panelConf.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.gBOne.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Асортимент товару";
            // 
            // panelConf
            // 
            this.panelConf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConf.BackColor = System.Drawing.Color.White;
            this.panelConf.Controls.Add(this.groupBox1);
            this.panelConf.Controls.Add(this.gBTwo);
            this.panelConf.Controls.Add(this.dataGridView);
            this.panelConf.Controls.Add(this.gBOne);
            this.panelConf.Location = new System.Drawing.Point(45, 163);
            this.panelConf.Name = "panelConf";
            this.panelConf.Size = new System.Drawing.Size(888, 530);
            this.panelConf.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnNewCat);
            this.groupBox1.Controls.Add(this.btnNewFirm);
            this.groupBox1.Controls.Add(this.btnNewProd);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(672, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 191);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Керування виробом";
            // 
            // btnNewCat
            // 
            this.btnNewCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnNewCat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewCat.BackgroundImage")));
            this.btnNewCat.FlatAppearance.BorderSize = 0;
            this.btnNewCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewCat.ForeColor = System.Drawing.Color.White;
            this.btnNewCat.Location = new System.Drawing.Point(18, 80);
            this.btnNewCat.Name = "btnNewCat";
            this.btnNewCat.Size = new System.Drawing.Size(151, 40);
            this.btnNewCat.TabIndex = 6;
            this.btnNewCat.Text = "Категорії виробів";
            this.btnNewCat.UseVisualStyleBackColor = false;
            this.btnNewCat.Click += new System.EventHandler(this.btnNewCat_Click);
            // 
            // btnNewFirm
            // 
            this.btnNewFirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnNewFirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewFirm.BackgroundImage")));
            this.btnNewFirm.FlatAppearance.BorderSize = 0;
            this.btnNewFirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewFirm.ForeColor = System.Drawing.Color.White;
            this.btnNewFirm.Location = new System.Drawing.Point(18, 132);
            this.btnNewFirm.Name = "btnNewFirm";
            this.btnNewFirm.Size = new System.Drawing.Size(151, 40);
            this.btnNewFirm.TabIndex = 6;
            this.btnNewFirm.Text = "Фірми";
            this.btnNewFirm.UseVisualStyleBackColor = false;
            this.btnNewFirm.Click += new System.EventHandler(this.btnNewFirm_Click);
            // 
            // btnNewProd
            // 
            this.btnNewProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnNewProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewProd.BackgroundImage")));
            this.btnNewProd.FlatAppearance.BorderSize = 0;
            this.btnNewProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewProd.ForeColor = System.Drawing.Color.White;
            this.btnNewProd.Location = new System.Drawing.Point(18, 28);
            this.btnNewProd.Name = "btnNewProd";
            this.btnNewProd.Size = new System.Drawing.Size(151, 40);
            this.btnNewProd.TabIndex = 6;
            this.btnNewProd.Text = "Новий виріб";
            this.btnNewProd.UseVisualStyleBackColor = false;
            this.btnNewProd.Click += new System.EventHandler(this.btnNewProd_Click);
            // 
            // gBTwo
            // 
            this.gBTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBTwo.Controls.Add(this.pnl5);
            this.gBTwo.Controls.Add(this.pnl4);
            this.gBTwo.Controls.Add(this.txtDescribeProduct);
            this.gBTwo.Controls.Add(this.txtNameProduct);
            this.gBTwo.Controls.Add(this.lblDescProd);
            this.gBTwo.Controls.Add(this.lblNameProd);
            this.gBTwo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBTwo.Location = new System.Drawing.Point(377, 314);
            this.gBTwo.Name = "gBTwo";
            this.gBTwo.Size = new System.Drawing.Size(286, 191);
            this.gBTwo.TabIndex = 0;
            this.gBTwo.TabStop = false;
            this.gBTwo.Text = "Інформаційне табло";
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl5.Location = new System.Drawing.Point(19, 170);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(246, 2);
            this.pnl5.TabIndex = 6;
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl4.Location = new System.Drawing.Point(19, 66);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(246, 2);
            this.pnl4.TabIndex = 0;
            // 
            // txtDescribeProduct
            // 
            this.txtDescribeProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescribeProduct.Enabled = false;
            this.txtDescribeProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescribeProduct.Location = new System.Drawing.Point(19, 97);
            this.txtDescribeProduct.Multiline = true;
            this.txtDescribeProduct.Name = "txtDescribeProduct";
            this.txtDescribeProduct.ReadOnly = true;
            this.txtDescribeProduct.Size = new System.Drawing.Size(246, 72);
            this.txtDescribeProduct.TabIndex = 0;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameProduct.Enabled = false;
            this.txtNameProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNameProduct.Location = new System.Drawing.Point(19, 48);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(246, 16);
            this.txtNameProduct.TabIndex = 0;
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescProd.Location = new System.Drawing.Point(16, 78);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(86, 13);
            this.lblDescProd.TabIndex = 0;
            this.lblDescProd.Text = "Опис продукту";
            // 
            // lblNameProd
            // 
            this.lblNameProd.AutoSize = true;
            this.lblNameProd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameProd.Location = new System.Drawing.Point(16, 28);
            this.lblNameProd.Name = "lblNameProd";
            this.lblNameProd.Size = new System.Drawing.Size(89, 13);
            this.lblNameProd.TabIndex = 0;
            this.lblNameProd.Text = "Назва продукту";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView.ContextMenuStrip = this.menuStrip2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(50, 26);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(808, 272);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "#";
            this.Column1.FillWeight = 71.06599F;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Назва";
            this.Column2.FillWeight = 121.4F;
            this.Column2.HeaderText = "Назва";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Опис";
            this.Column3.FillWeight = 98.95696F;
            this.Column3.HeaderText = "Опис";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Вага";
            this.Column4.FillWeight = 74.83828F;
            this.Column4.HeaderText = "Вага";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Ціна";
            this.Column5.FillWeight = 68.05455F;
            this.Column5.HeaderText = "Ціна";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Категорія";
            this.Column6.FillWeight = 134.8743F;
            this.Column6.HeaderText = "Категорія";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Фірма-виробник";
            this.Column7.FillWeight = 134.8743F;
            this.Column7.HeaderText = "Фірма-виробник";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Поточна кількість";
            this.Column8.FillWeight = 95.93559F;
            this.Column8.HeaderText = "Поточна кількість";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProductToolTip,
            this.deleteProductToolTip});
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(168, 48);
            this.menuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.menuStrip2_Opening);
            // 
            // editProductToolTip
            // 
            this.editProductToolTip.Name = "editProductToolTip";
            this.editProductToolTip.Size = new System.Drawing.Size(167, 22);
            this.editProductToolTip.Text = "Редагувати виріб";
            this.editProductToolTip.Click += new System.EventHandler(this.editProductToolTip_Click);
            // 
            // deleteProductToolTip
            // 
            this.deleteProductToolTip.Name = "deleteProductToolTip";
            this.deleteProductToolTip.Size = new System.Drawing.Size(167, 22);
            this.deleteProductToolTip.Text = "Видалити виріб";
            this.deleteProductToolTip.Click += new System.EventHandler(this.deleteProductToolTip_Click);
            // 
            // gBOne
            // 
            this.gBOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gBOne.Controls.Add(this.pnl3);
            this.gBOne.Controls.Add(this.pnl2);
            this.gBOne.Controls.Add(this.pnl1);
            this.gBOne.Controls.Add(this.buttClear);
            this.gBOne.Controls.Add(this.btnNew);
            this.gBOne.Controls.Add(this.lblMaxVal);
            this.gBOne.Controls.Add(this.lblMinVal);
            this.gBOne.Controls.Add(this.lblSearchData);
            this.gBOne.Controls.Add(this.txtSearchByValues);
            this.gBOne.Controls.Add(this.txtValueMax);
            this.gBOne.Controls.Add(this.txtValueMin);
            this.gBOne.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBOne.Location = new System.Drawing.Point(50, 314);
            this.gBOne.Name = "gBOne";
            this.gBOne.Size = new System.Drawing.Size(319, 191);
            this.gBOne.TabIndex = 0;
            this.gBOne.TabStop = false;
            this.gBOne.Text = "Пошук";
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl3.Location = new System.Drawing.Point(24, 170);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(139, 2);
            this.pnl3.TabIndex = 0;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl2.Location = new System.Drawing.Point(24, 116);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(139, 2);
            this.pnl2.TabIndex = 0;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl1.Location = new System.Drawing.Point(24, 66);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(269, 2);
            this.pnl1.TabIndex = 0;
            // 
            // buttClear
            // 
            this.buttClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.buttClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttClear.BackgroundImage")));
            this.buttClear.FlatAppearance.BorderSize = 0;
            this.buttClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttClear.ForeColor = System.Drawing.Color.White;
            this.buttClear.Location = new System.Drawing.Point(188, 139);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(105, 33);
            this.buttClear.TabIndex = 5;
            this.buttClear.Text = "Очистити";
            this.buttClear.UseVisualStyleBackColor = false;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(188, 97);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 33);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Пошук";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblMaxVal
            // 
            this.lblMaxVal.AutoSize = true;
            this.lblMaxVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxVal.Location = new System.Drawing.Point(21, 133);
            this.lblMaxVal.Name = "lblMaxVal";
            this.lblMaxVal.Size = new System.Drawing.Size(109, 13);
            this.lblMaxVal.TabIndex = 0;
            this.lblMaxVal.Text = "Максимальна ціна:";
            // 
            // lblMinVal
            // 
            this.lblMinVal.AutoSize = true;
            this.lblMinVal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinVal.Location = new System.Drawing.Point(21, 78);
            this.lblMinVal.Name = "lblMinVal";
            this.lblMinVal.Size = new System.Drawing.Size(98, 13);
            this.lblMinVal.TabIndex = 0;
            this.lblMinVal.Text = "Мінімальна ціна:";
            // 
            // lblSearchData
            // 
            this.lblSearchData.AutoSize = true;
            this.lblSearchData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchData.Location = new System.Drawing.Point(21, 28);
            this.lblSearchData.Name = "lblSearchData";
            this.lblSearchData.Size = new System.Drawing.Size(231, 13);
            this.lblSearchData.TabIndex = 0;
            this.lblSearchData.Text = "Пошук за назвою, виробником, категорії:";
            // 
            // txtSearchByValues
            // 
            this.txtSearchByValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchByValues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchByValues.Location = new System.Drawing.Point(24, 47);
            this.txtSearchByValues.Name = "txtSearchByValues";
            this.txtSearchByValues.Size = new System.Drawing.Size(269, 16);
            this.txtSearchByValues.TabIndex = 1;
            this.txtSearchByValues.TextChanged += new System.EventHandler(this.txtSearchByValues_TextChanged);
            // 
            // txtValueMax
            // 
            this.txtValueMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValueMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtValueMax.Location = new System.Drawing.Point(24, 151);
            this.txtValueMax.Name = "txtValueMax";
            this.txtValueMax.Size = new System.Drawing.Size(139, 16);
            this.txtValueMax.TabIndex = 3;
            // 
            // txtValueMin
            // 
            this.txtValueMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValueMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtValueMin.Location = new System.Drawing.Point(24, 97);
            this.txtValueMin.Name = "txtValueMin";
            this.txtValueMin.Size = new System.Drawing.Size(139, 16);
            this.txtValueMin.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolTip});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.файлToolStripMenuItem.Text = "Головне";
            // 
            // exitToolTip
            // 
            this.exitToolTip.Name = "exitToolTip";
            this.exitToolTip.Size = new System.Drawing.Size(180, 22);
            this.exitToolTip.Text = "Вихід";
            this.exitToolTip.Click += new System.EventHandler(this.exitToolTip_Click);
            // 
            // FormConfectionery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 722);
            this.Controls.Add(this.panelConf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormConfectionery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Асортимент товару";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConfectionery_FormClosed);
            this.Load += new System.EventHandler(this.FormConfectionery_Load);
            this.Shown += new System.EventHandler(this.FormConfectionery_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelConf.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gBTwo.ResumeLayout(false);
            this.gBTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.gBOne.ResumeLayout(false);
            this.gBOne.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConf;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblSearchData;
        private System.Windows.Forms.TextBox txtSearchByValues;
        private System.Windows.Forms.GroupBox gBOne;
        private System.Windows.Forms.TextBox txtValueMax;
        private System.Windows.Forms.TextBox txtValueMin;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Label lblMaxVal;
        private System.Windows.Forms.Label lblMinVal;
        private System.Windows.Forms.GroupBox gBTwo;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label lblNameProd;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.TextBox txtDescribeProduct;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolTip;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNewProd;
        private System.Windows.Forms.Button btnNewCat;
        private System.Windows.Forms.Button btnNewFirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ContextMenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editProductToolTip;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolTip;
    }
}