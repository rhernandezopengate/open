﻿namespace WFAHomeDelivery
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
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEscaneados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscaneos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(2, 0);
            this.lblTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(85, 13);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Escanear Ticket";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(118, 2);
            this.txtTicket.Margin = new System.Windows.Forms.Padding(2);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(185, 20);
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
            this.dgvEscaneos.Location = new System.Drawing.Point(9, 131);
            this.dgvEscaneos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEscaneos.Name = "dgvEscaneos";
            this.dgvEscaneos.RowHeadersWidth = 51;
            this.dgvEscaneos.RowTemplate.Height = 24;
            this.dgvEscaneos.Size = new System.Drawing.Size(400, 393);
            this.dgvEscaneos.TabIndex = 2;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(118, 59);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(185, 20);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProducto_KeyPress);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(2, 57);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(98, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Escanear Producto";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(334, 14);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 112);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar Orden";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.32076F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.67924F));
            this.tableLayoutPanel1.Controls.Add(this.lblTicket, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTicket, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProducto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProducto, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 112);
            this.tableLayoutPanel1.TabIndex = 9;
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
            // CantidadEscaneados
            // 
            this.CantidadEscaneados.DataPropertyName = "CantidadSKUS";
            this.CantidadEscaneados.HeaderText = "Cantidad Escaneados";
            this.CantidadEscaneados.MinimumWidth = 6;
            this.CantidadEscaneados.Name = "CantidadEscaneados";
            this.CantidadEscaneados.Width = 200;
            // 
            // frmEscaneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvEscaneos);
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
    }
}