
namespace sweetshop
{
    partial class Supplies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplies));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlOrd1 = new System.Windows.Forms.Panel();
            this.lblSupplies = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOrd2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCommonPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSub = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supplierBox1 = new System.Windows.Forms.ComboBox();
            this.productBox1 = new System.Windows.Forms.ComboBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToSupToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.makeConsignment = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOrd1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlOrd2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrd1
            // 
            this.pnlOrd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnlOrd1.Controls.Add(this.lblSupplies);
            this.pnlOrd1.Controls.Add(this.menuStrip1);
            this.pnlOrd1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrd1.Location = new System.Drawing.Point(0, 0);
            this.pnlOrd1.Name = "pnlOrd1";
            this.pnlOrd1.Size = new System.Drawing.Size(731, 135);
            this.pnlOrd1.TabIndex = 0;
            // 
            // lblSupplies
            // 
            this.lblSupplies.AutoSize = true;
            this.lblSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSupplies.ForeColor = System.Drawing.Color.White;
            this.lblSupplies.Location = new System.Drawing.Point(42, 67);
            this.lblSupplies.Name = "lblSupplies";
            this.lblSupplies.Size = new System.Drawing.Size(95, 21);
            this.lblSupplies.TabIndex = 0;
            this.lblSupplies.Text = "Постачання";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolTip,
            this.адмініструванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolTip
            // 
            this.fileToolTip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolTip});
            this.fileToolTip.Name = "fileToolTip";
            this.fileToolTip.Size = new System.Drawing.Size(48, 20);
            this.fileToolTip.Text = "Файл";
            // 
            // exitToolTip
            // 
            this.exitToolTip.Name = "exitToolTip";
            this.exitToolTip.Size = new System.Drawing.Size(102, 22);
            this.exitToolTip.Text = "Вихід";
            this.exitToolTip.Click += new System.EventHandler(this.exitToolTip_Click);
            // 
            // адмініструванняToolStripMenuItem
            // 
            this.адмініструванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersToolTip});
            this.адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            this.адмініструванняToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // suppliersToolTip
            // 
            this.suppliersToolTip.Name = "suppliersToolTip";
            this.suppliersToolTip.Size = new System.Drawing.Size(160, 22);
            this.suppliersToolTip.Text = "Постачальники";
            this.suppliersToolTip.Click += new System.EventHandler(this.suppliersToolTip_Click);
            // 
            // pnlOrd2
            // 
            this.pnlOrd2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrd2.BackColor = System.Drawing.Color.White;
            this.pnlOrd2.Controls.Add(this.lblTotal);
            this.pnlOrd2.Controls.Add(this.total);
            this.pnlOrd2.Controls.Add(this.groupBox1);
            this.pnlOrd2.Controls.Add(this.groupBox2);
            this.pnlOrd2.Controls.Add(this.dataGridView);
            this.pnlOrd2.Location = new System.Drawing.Point(46, 163);
            this.pnlOrd2.Name = "pnlOrd2";
            this.pnlOrd2.Size = new System.Drawing.Size(641, 508);
            this.pnlOrd2.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(124, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 15);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0 грн";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total.Location = new System.Drawing.Point(19, 16);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(107, 15);
            this.total.TabIndex = 2;
            this.total.Text = "Всього товарів на:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCommonPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.dgvSub);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(267, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список постачань";
            // 
            // txtCommonPrice
            // 
            this.txtCommonPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommonPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommonPrice.Enabled = false;
            this.txtCommonPrice.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCommonPrice.ForeColor = System.Drawing.Color.Black;
            this.txtCommonPrice.Location = new System.Drawing.Point(194, 155);
            this.txtCommonPrice.Multiline = true;
            this.txtCommonPrice.Name = "txtCommonPrice";
            this.txtCommonPrice.Size = new System.Drawing.Size(153, 23);
            this.txtCommonPrice.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(126, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Підсумок:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel4.Location = new System.Drawing.Point(194, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 2);
            this.panel4.TabIndex = 0;
            // 
            // dgvSub
            // 
            this.dgvSub.AllowUserToAddRows = false;
            this.dgvSub.AllowUserToDeleteRows = false;
            this.dgvSub.AllowUserToResizeColumns = false;
            this.dgvSub.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSub.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSub.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column7,
            this.Column8,
            this.Column11});
            this.dgvSub.EnableHeadersVisualStyles = false;
            this.dgvSub.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSub.Location = new System.Drawing.Point(6, 19);
            this.dgvSub.MultiSelect = false;
            this.dgvSub.Name = "dgvSub";
            this.dgvSub.ReadOnly = true;
            this.dgvSub.RowHeadersVisible = false;
            this.dgvSub.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSub.Size = new System.Drawing.Size(341, 132);
            this.dgvSub.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Номер замовлення";
            this.Column9.HeaderText = "Номер замовлення";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Назва продукту";
            this.Column7.HeaderText = "Назва продукту";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Кількість продукту";
            this.Column8.HeaderText = "Кількість продукту";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Ціна";
            this.Column11.HeaderText = "Ціна";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.supplierBox1);
            this.groupBox2.Controls.Add(this.productBox1);
            this.groupBox2.Controls.Add(this.txtQuant);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.pnl7);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.lblSupplier);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(22, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 188);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Керування постачаннями";
            // 
            // supplierBox1
            // 
            this.supplierBox1.BackColor = System.Drawing.Color.White;
            this.supplierBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierBox1.ForeColor = System.Drawing.Color.Black;
            this.supplierBox1.FormattingEnabled = true;
            this.supplierBox1.Items.AddRange(new object[] {
            ""});
            this.supplierBox1.Location = new System.Drawing.Point(125, 26);
            this.supplierBox1.Name = "supplierBox1";
            this.supplierBox1.Size = new System.Drawing.Size(100, 21);
            this.supplierBox1.TabIndex = 2;
            // 
            // productBox1
            // 
            this.productBox1.BackColor = System.Drawing.Color.White;
            this.productBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productBox1.ForeColor = System.Drawing.Color.Black;
            this.productBox1.FormattingEnabled = true;
            this.productBox1.Items.AddRange(new object[] {
            ""});
            this.productBox1.Location = new System.Drawing.Point(125, 63);
            this.productBox1.Name = "productBox1";
            this.productBox1.Size = new System.Drawing.Size(100, 21);
            this.productBox1.TabIndex = 2;
            // 
            // txtQuant
            // 
            this.txtQuant.BackColor = System.Drawing.Color.White;
            this.txtQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuant.ForeColor = System.Drawing.Color.Black;
            this.txtQuant.Location = new System.Drawing.Point(125, 103);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(100, 16);
            this.txtQuant.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel1.Location = new System.Drawing.Point(125, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 2);
            this.panel1.TabIndex = 0;
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl7.Location = new System.Drawing.Point(125, 48);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(100, 2);
            this.pnl7.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Location = new System.Drawing.Point(11, 68);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(83, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Назва виробу:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(125, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 2);
            this.panel2.TabIndex = 0;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.Location = new System.Drawing.Point(11, 106);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(98, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Кількість виробу:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplier.Location = new System.Drawing.Point(11, 30);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(86, 13);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Постачальник:";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(14, 142);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(211, 33);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Нове постачання";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(22, 44);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(598, 243);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_sup";
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Постачальник";
            this.Column2.HeaderText = "Постачальник";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Працівник";
            this.Column3.HeaderText = "Товарознавець";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Дата постачання";
            this.Column4.HeaderText = "Дата постачання";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Підсумок";
            this.Column5.HeaderText = "Підсумок";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToSupToolTip,
            this.makeConsignment});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addToSupToolTip
            // 
            this.addToSupToolTip.Name = "addToSupToolTip";
            this.addToSupToolTip.Size = new System.Drawing.Size(198, 22);
            this.addToSupToolTip.Text = "Додати до постачання";
            this.addToSupToolTip.Click += new System.EventHandler(this.addToSupToolTip_Click);
            // 
            // makeConsignment
            // 
            this.makeConsignment.Name = "makeConsignment";
            this.makeConsignment.Size = new System.Drawing.Size(198, 22);
            this.makeConsignment.Text = "Сформувати накладну";
            this.makeConsignment.Click += new System.EventHandler(this.makeConsignment_Click);
            // 
            // Supplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 696);
            this.Controls.Add(this.pnlOrd2);
            this.Controls.Add(this.pnlOrd1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Supplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Постачання";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Supplies_FormClosed);
            this.Load += new System.EventHandler(this.Supplies_Load);
            this.Shown += new System.EventHandler(this.Supplies_Shown);
            this.pnlOrd1.ResumeLayout(false);
            this.pnlOrd1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlOrd2.ResumeLayout(false);
            this.pnlOrd2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrd1;
        private System.Windows.Forms.Label lblSupplies;
        private System.Windows.Forms.Panel pnlOrd2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox productBox1;
        private System.Windows.Forms.TextBox txtCommonPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToSupToolTip;
        private System.Windows.Forms.ComboBox supplierBox1;
        private System.Windows.Forms.ToolStripMenuItem makeConsignment;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolTip;
        private System.Windows.Forms.ToolStripMenuItem exitToolTip;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label total;
    }
}