
namespace sweetshop
{
    partial class AddToOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToOrder));
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtQuantity2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNumOrder = new System.Windows.Forms.TextBox();
            this.lblNumOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.btnAddToOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToOrder.BackgroundImage")));
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddToOrder.Location = new System.Drawing.Point(58, 148);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(197, 35);
            this.btnAddToOrder.TabIndex = 23;
            this.btnAddToOrder.Text = "Додати до замовлення";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel6.Location = new System.Drawing.Point(146, 127);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(135, 1);
            this.panel6.TabIndex = 20;
            // 
            // txtQuantity2
            // 
            this.txtQuantity2.BackColor = System.Drawing.Color.White;
            this.txtQuantity2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuantity2.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity2.Location = new System.Drawing.Point(146, 108);
            this.txtQuantity2.Name = "txtQuantity2";
            this.txtQuantity2.Size = new System.Drawing.Size(135, 16);
            this.txtQuantity2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Бажана кількість:";
            // 
            // productBox2
            // 
            this.productBox2.BackColor = System.Drawing.Color.White;
            this.productBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productBox2.ForeColor = System.Drawing.Color.Black;
            this.productBox2.FormattingEnabled = true;
            this.productBox2.Items.AddRange(new object[] {
            ""});
            this.productBox2.Location = new System.Drawing.Point(128, 62);
            this.productBox2.Name = "productBox2";
            this.productBox2.Size = new System.Drawing.Size(153, 21);
            this.productBox2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Назва виробу:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel5.Location = new System.Drawing.Point(127, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(154, 1);
            this.panel5.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.panel4.Location = new System.Drawing.Point(159, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 1);
            this.panel4.TabIndex = 14;
            // 
            // txtNumOrder
            // 
            this.txtNumOrder.BackColor = System.Drawing.Color.White;
            this.txtNumOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumOrder.Enabled = false;
            this.txtNumOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumOrder.ForeColor = System.Drawing.Color.Black;
            this.txtNumOrder.Location = new System.Drawing.Point(159, 20);
            this.txtNumOrder.Name = "txtNumOrder";
            this.txtNumOrder.Size = new System.Drawing.Size(122, 16);
            this.txtNumOrder.TabIndex = 16;
            // 
            // lblNumOrder
            // 
            this.lblNumOrder.AutoSize = true;
            this.lblNumOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumOrder.Location = new System.Drawing.Point(39, 24);
            this.lblNumOrder.Name = "lblNumOrder";
            this.lblNumOrder.Size = new System.Drawing.Size(113, 13);
            this.lblNumOrder.TabIndex = 15;
            this.lblNumOrder.Text = "Номер замовлення:";
            // 
            // AddToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 202);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtQuantity2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtNumOrder);
            this.Controls.Add(this.lblNumOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddToOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати до замовлення";
            this.Load += new System.EventHandler(this.AddToOrder_Load);
            this.Shown += new System.EventHandler(this.AddToOrder_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtQuantity2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox productBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNumOrder;
        private System.Windows.Forms.Label lblNumOrder;
    }
}