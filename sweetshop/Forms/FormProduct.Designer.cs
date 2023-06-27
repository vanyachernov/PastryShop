
namespace sweetshop
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.mainPnl = new System.Windows.Forms.Panel();
            this.lblNewProd = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.cmbProdFirm = new System.Windows.Forms.ComboBox();
            this.cmbProdCat = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFirm = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProdWeight = new System.Windows.Forms.TextBox();
            this.txtProdDescirbe = new System.Windows.Forms.TextBox();
            this.lblProdWeight = new System.Windows.Forms.Label();
            this.lblProdDescribe = new System.Windows.Forms.Label();
            this.lblProdQuantity = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.mainPnl.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.mainPnl.Controls.Add(this.lblNewProd);
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPnl.Location = new System.Drawing.Point(0, 0);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(498, 117);
            this.mainPnl.TabIndex = 0;
            // 
            // lblNewProd
            // 
            this.lblNewProd.AutoSize = true;
            this.lblNewProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNewProd.ForeColor = System.Drawing.Color.White;
            this.lblNewProd.Location = new System.Drawing.Point(33, 47);
            this.lblNewProd.Name = "lblNewProd";
            this.lblNewProd.Size = new System.Drawing.Size(119, 21);
            this.lblNewProd.TabIndex = 0;
            this.lblNewProd.Text = "Новий продукт";
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.Controls.Add(this.cmbProdFirm);
            this.pnl1.Controls.Add(this.cmbProdCat);
            this.pnl1.Controls.Add(this.panel3);
            this.pnl1.Controls.Add(this.panel4);
            this.pnl1.Controls.Add(this.panel5);
            this.pnl1.Controls.Add(this.panel2);
            this.pnl1.Controls.Add(this.panel1);
            this.pnl1.Controls.Add(this.pnl4);
            this.pnl1.Controls.Add(this.btnSave);
            this.pnl1.Controls.Add(this.lblFirm);
            this.pnl1.Controls.Add(this.txtProdPrice);
            this.pnl1.Controls.Add(this.lblPrice);
            this.pnl1.Controls.Add(this.txtProdWeight);
            this.pnl1.Controls.Add(this.txtProdDescirbe);
            this.pnl1.Controls.Add(this.lblProdWeight);
            this.pnl1.Controls.Add(this.lblProdDescribe);
            this.pnl1.Controls.Add(this.lblProdQuantity);
            this.pnl1.Controls.Add(this.txtProdName);
            this.pnl1.Controls.Add(this.lblProdName);
            this.pnl1.Location = new System.Drawing.Point(45, 151);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(411, 474);
            this.pnl1.TabIndex = 0;
            // 
            // cmbProdFirm
            // 
            this.cmbProdFirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdFirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProdFirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbProdFirm.FormattingEnabled = true;
            this.cmbProdFirm.Items.AddRange(new object[] {
            "-"});
            this.cmbProdFirm.Location = new System.Drawing.Point(51, 311);
            this.cmbProdFirm.Name = "cmbProdFirm";
            this.cmbProdFirm.Size = new System.Drawing.Size(306, 23);
            this.cmbProdFirm.TabIndex = 5;
            // 
            // cmbProdCat
            // 
            this.cmbProdCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProdCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbProdCat.FormattingEnabled = true;
            this.cmbProdCat.Items.AddRange(new object[] {
            "-"});
            this.cmbProdCat.Location = new System.Drawing.Point(51, 128);
            this.cmbProdCat.Name = "cmbProdCat";
            this.cmbProdCat.Size = new System.Drawing.Size(306, 23);
            this.cmbProdCat.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel3.Location = new System.Drawing.Point(51, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 2);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel4.Location = new System.Drawing.Point(51, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 2);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel5.Location = new System.Drawing.Point(51, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 2);
            this.panel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(51, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 2);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel1.Location = new System.Drawing.Point(51, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 2);
            this.panel1.TabIndex = 0;
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.pnl4.Location = new System.Drawing.Point(51, 88);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(306, 2);
            this.pnl4.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(51, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirm.Location = new System.Drawing.Point(48, 290);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(103, 15);
            this.lblFirm.TabIndex = 0;
            this.lblFirm.Text = "Фірма-виробник:";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProdPrice.Location = new System.Drawing.Point(51, 376);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(306, 16);
            this.txtProdPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(48, 352);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 15);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Бажана ціна:";
            // 
            // txtProdWeight
            // 
            this.txtProdWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProdWeight.Location = new System.Drawing.Point(51, 190);
            this.txtProdWeight.Name = "txtProdWeight";
            this.txtProdWeight.Size = new System.Drawing.Size(306, 16);
            this.txtProdWeight.TabIndex = 3;
            // 
            // txtProdDescirbe
            // 
            this.txtProdDescirbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdDescirbe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProdDescirbe.Location = new System.Drawing.Point(51, 252);
            this.txtProdDescirbe.Name = "txtProdDescirbe";
            this.txtProdDescirbe.Size = new System.Drawing.Size(306, 16);
            this.txtProdDescirbe.TabIndex = 4;
            // 
            // lblProdWeight
            // 
            this.lblProdWeight.AutoSize = true;
            this.lblProdWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProdWeight.Location = new System.Drawing.Point(48, 166);
            this.lblProdWeight.Name = "lblProdWeight";
            this.lblProdWeight.Size = new System.Drawing.Size(87, 15);
            this.lblProdWeight.TabIndex = 0;
            this.lblProdWeight.Text = "Вага продукту:";
            // 
            // lblProdDescribe
            // 
            this.lblProdDescribe.AutoSize = true;
            this.lblProdDescribe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProdDescribe.Location = new System.Drawing.Point(48, 228);
            this.lblProdDescribe.Name = "lblProdDescribe";
            this.lblProdDescribe.Size = new System.Drawing.Size(92, 15);
            this.lblProdDescribe.TabIndex = 0;
            this.lblProdDescribe.Text = "Опис продукту:";
            // 
            // lblProdQuantity
            // 
            this.lblProdQuantity.AutoSize = true;
            this.lblProdQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProdQuantity.Location = new System.Drawing.Point(48, 107);
            this.lblProdQuantity.Name = "lblProdQuantity";
            this.lblProdQuantity.Size = new System.Drawing.Size(115, 15);
            this.lblProdQuantity.TabIndex = 0;
            this.lblProdQuantity.Text = "Категорія продукту:";
            // 
            // txtProdName
            // 
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProdName.Location = new System.Drawing.Point(51, 69);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(306, 16);
            this.txtProdName.TabIndex = 1;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProdName.Location = new System.Drawing.Point(48, 43);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(95, 15);
            this.lblProdName.TabIndex = 0;
            this.lblProdName.Text = "Назва продукту:";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 669);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.mainPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новий продукт";
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Label lblNewProd;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFirm;
        private System.Windows.Forms.TextBox txtProdDescirbe;
        private System.Windows.Forms.Label lblProdDescribe;
        private System.Windows.Forms.Label lblProdQuantity;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.ComboBox cmbProdFirm;
        private System.Windows.Forms.ComboBox cmbProdCat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtProdWeight;
        private System.Windows.Forms.Label lblProdWeight;
    }
}