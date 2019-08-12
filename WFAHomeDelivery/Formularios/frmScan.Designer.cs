namespace WFAHomeDelivery.Formularios
{
    partial class frmScan
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
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.lblOrden = new System.Windows.Forms.Label();
            this.lblPicker = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEscaneos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrdenId = new System.Windows.Forms.Label();
            this.lblPK = new System.Windows.Forms.Label();
            this.btnBackOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAD = new System.Windows.Forms.Label();
            this.lblAuditor = new System.Windows.Forms.Label();
            this.btnFaltantes = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(136, 36);
            this.txtOrden.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(325, 30);
            this.txtOrden.TabIndex = 0;
            this.txtOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOrden_KeyPress);
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(4, 32);
            this.lblOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(80, 23);
            this.lblOrden.TabIndex = 1;
            this.lblOrden.Text = "ORDEN";
            // 
            // lblPicker
            // 
            this.lblPicker.AutoSize = true;
            this.lblPicker.Location = new System.Drawing.Point(145, 126);
            this.lblPicker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPicker.Name = "lblPicker";
            this.lblPicker.Size = new System.Drawing.Size(83, 23);
            this.lblPicker.TabIndex = 2;
            this.lblPicker.Text = "PICKER";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(4, 70);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(122, 23);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "PRODUCTO";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(136, 74);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(325, 30);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProducto_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.cantidad,
            this.CantidadEscaneos});
            this.dataGridView1.Location = new System.Drawing.Point(13, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 687);
            this.dataGridView1.TabIndex = 6;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 200;
            // 
            // CantidadEscaneos
            // 
            this.CantidadEscaneos.DataPropertyName = "CantidadEscaneos";
            this.CantidadEscaneos.HeaderText = "Escaneados";
            this.CantidadEscaneos.MinimumWidth = 6;
            this.CantidadEscaneos.Name = "CantidadEscaneos";
            this.CantidadEscaneos.ReadOnly = true;
            this.CantidadEscaneos.Width = 200;
            // 
            // lblOrdenId
            // 
            this.lblOrdenId.AutoSize = true;
            this.lblOrdenId.Location = new System.Drawing.Point(392, 126);
            this.lblOrdenId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdenId.Name = "lblOrdenId";
            this.lblOrdenId.Size = new System.Drawing.Size(82, 23);
            this.lblOrdenId.TabIndex = 7;
            this.lblOrdenId.Text = "IdOrden";
            this.lblOrdenId.Visible = false;
            // 
            // lblPK
            // 
            this.lblPK.AutoSize = true;
            this.lblPK.Location = new System.Drawing.Point(17, 126);
            this.lblPK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPK.Name = "lblPK";
            this.lblPK.Size = new System.Drawing.Size(83, 23);
            this.lblPK.TabIndex = 8;
            this.lblPK.Text = "PICKER";
            // 
            // btnBackOrder
            // 
            this.btnBackOrder.Location = new System.Drawing.Point(486, 12);
            this.btnBackOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackOrder.Name = "btnBackOrder";
            this.btnBackOrder.Size = new System.Drawing.Size(168, 42);
            this.btnBackOrder.TabIndex = 9;
            this.btnBackOrder.Text = "Back Order";
            this.btnBackOrder.UseVisualStyleBackColor = true;
            this.btnBackOrder.Click += new System.EventHandler(this.BtnBackOrder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.60215F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.39785F));
            this.tableLayoutPanel1.Controls.Add(this.lblProducto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtProducto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtOrden, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOrden, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAD, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAuditor, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 109);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(4, 0);
            this.lblAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(98, 23);
            this.lblAD.TabIndex = 9;
            this.lblAD.Text = "AUDITOR";
            // 
            // lblAuditor
            // 
            this.lblAuditor.AutoSize = true;
            this.lblAuditor.Location = new System.Drawing.Point(135, 0);
            this.lblAuditor.Name = "lblAuditor";
            this.lblAuditor.Size = new System.Drawing.Size(72, 23);
            this.lblAuditor.TabIndex = 10;
            this.lblAuditor.Text = "Auditor";
            // 
            // btnFaltantes
            // 
            this.btnFaltantes.Location = new System.Drawing.Point(486, 62);
            this.btnFaltantes.Margin = new System.Windows.Forms.Padding(4);
            this.btnFaltantes.Name = "btnFaltantes";
            this.btnFaltantes.Size = new System.Drawing.Size(168, 39);
            this.btnFaltantes.TabIndex = 11;
            this.btnFaltantes.Text = "Faltantes";
            this.btnFaltantes.UseVisualStyleBackColor = true;
            this.btnFaltantes.Click += new System.EventHandler(this.BtnFaltantes_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(486, 108);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 39);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // frmScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 859);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFaltantes);
            this.Controls.Add(this.lblPK);
            this.Controls.Add(this.lblPicker);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnBackOrder);
            this.Controls.Add(this.lblOrdenId);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmScan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label lblPicker;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOrdenId;
        private System.Windows.Forms.Label lblPK;
        private System.Windows.Forms.Button btnBackOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Button btnFaltantes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblAuditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEscaneos;
    }
}