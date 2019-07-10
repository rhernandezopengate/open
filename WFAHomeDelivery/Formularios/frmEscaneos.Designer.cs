namespace WFAHomeDelivery
{
    partial class frmEscaneos
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
            this.lblTicket = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.dgvEscaneos = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.lblQR = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscaneos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(3, 0);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(110, 17);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Escanear Ticket";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(157, 2);
            this.txtTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(245, 22);
            this.txtTicket.TabIndex = 1;
            this.txtTicket.TextChanged += new System.EventHandler(this.TxtTicket_TextChanged);
            // 
            // dgvEscaneos
            // 
            this.dgvEscaneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscaneos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.Cantidad});
            this.dgvEscaneos.Location = new System.Drawing.Point(12, 175);
            this.dgvEscaneos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEscaneos.Name = "dgvEscaneos";
            this.dgvEscaneos.RowHeadersWidth = 51;
            this.dgvEscaneos.RowTemplate.Height = 24;
            this.dgvEscaneos.Size = new System.Drawing.Size(455, 484);
            this.dgvEscaneos.TabIndex = 2;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            this.SKU.Width = 90;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(157, 39);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(245, 22);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.TextChanged += new System.EventHandler(this.TxtProducto_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(3, 37);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(129, 17);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Escanear Producto";
            // 
            // txtQR
            // 
            this.txtQR.Enabled = false;
            this.txtQR.Location = new System.Drawing.Point(157, 74);
            this.txtQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(245, 22);
            this.txtQR.TabIndex = 6;
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Location = new System.Drawing.Point(3, 72);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(143, 17);
            this.lblQR.TabIndex = 5;
            this.lblQR.Text = "Codigo Bidimensional";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 138);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar Orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.32076F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.67924F));
            this.tableLayoutPanel1.Controls.Add(this.lblTicket, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTicket, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProducto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtQR, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtProducto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQR, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 138);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad Manual";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(157, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(474, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 484);
            this.listBox1.TabIndex = 10;
            // 
            // frmEscaneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 670);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEscaneos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEscaneos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escaneo de Ordenes";
            this.Load += new System.EventHandler(this.FrmEscaneos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscaneos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.DataGridView dgvEscaneos;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.Label lblQR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ListBox listBox1;
    }
}