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
            this.CantidadEscaneados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuditor = new System.Windows.Forms.Label();
            this.lblPicker = new System.Windows.Forms.Label();
            this.lblAuditor1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscaneos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(2, 57);
            this.lblTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(151, 23);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Escanear Ticket";
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(175, 59);
            this.txtTicket.Margin = new System.Windows.Forms.Padding(2);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(299, 30);
            this.txtTicket.TabIndex = 1;
            this.txtTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTicket_KeyPress);
            // 
            // dgvEscaneos
            // 
            this.dgvEscaneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscaneos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.Cantidad,
            this.CantidadEscaneados});
            this.dgvEscaneos.Location = new System.Drawing.Point(12, 138);
            this.dgvEscaneos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEscaneos.Name = "dgvEscaneos";
            this.dgvEscaneos.RowHeadersWidth = 51;
            this.dgvEscaneos.RowTemplate.Height = 24;
            this.dgvEscaneos.Size = new System.Drawing.Size(567, 597);
            this.dgvEscaneos.TabIndex = 4;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            this.SKU.Width = 165;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 165;
            // 
            // CantidadEscaneados
            // 
            this.CantidadEscaneados.DataPropertyName = "CantidadSKUS";
            this.CantidadEscaneados.HeaderText = "Cantidad Escaneados";
            this.CantidadEscaneados.MinimumWidth = 6;
            this.CantidadEscaneados.Name = "CantidadEscaneados";
            this.CantidadEscaneados.Width = 170;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(175, 93);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(299, 30);
            this.txtProducto.TabIndex = 2;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProducto_KeyPress);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(2, 91);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(99, 31);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Escanear Producto";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(494, 12);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 122);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar Orden";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.32076F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.67924F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProducto, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAuditor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProducto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAuditor1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTicket, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTicket, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 122);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Picker";
            // 
            // lblAuditor
            // 
            this.lblAuditor.AutoSize = true;
            this.lblAuditor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditor.Location = new System.Drawing.Point(176, 0);
            this.lblAuditor.Name = "lblAuditor";
            this.lblAuditor.Size = new System.Drawing.Size(62, 23);
            this.lblAuditor.TabIndex = 11;
            this.lblAuditor.Text = "label2";
            // 
            // lblPicker
            // 
            this.lblPicker.AutoSize = true;
            this.lblPicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicker.Location = new System.Drawing.Point(176, 28);
            this.lblPicker.Name = "lblPicker";
            this.lblPicker.Size = new System.Drawing.Size(65, 23);
            this.lblPicker.TabIndex = 11;
            this.lblPicker.Text = "Picker";
            // 
            // lblAuditor1
            // 
            this.lblAuditor1.AutoSize = true;
            this.lblAuditor1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditor1.Location = new System.Drawing.Point(3, 0);
            this.lblAuditor1.Name = "lblAuditor1";
            this.lblAuditor1.Size = new System.Drawing.Size(72, 23);
            this.lblAuditor1.TabIndex = 10;
            this.lblAuditor1.Text = "Auditor";
            // 
            // frmEscaneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 740);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvEscaneos);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEscaneados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPicker;
        private System.Windows.Forms.Label lblAuditor1;
        private System.Windows.Forms.Label lblAuditor;
    }
}