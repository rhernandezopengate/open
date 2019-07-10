namespace WFAHomeDelivery.Formularios
{
    partial class frmSKU
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.txtUOM = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvSKUS = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbQTYNo = new System.Windows.Forms.RadioButton();
            this.rbQTYSi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigobarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigobidimensional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtymanual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKUS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.76821F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.23179F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSKU, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUOM, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigoBarras, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 58);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo Barras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "UOM";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(111, 2);
            this.txtSKU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(197, 22);
            this.txtSKU.TabIndex = 3;
            // 
            // txtUOM
            // 
            this.txtUOM.Location = new System.Drawing.Point(111, 80);
            this.txtUOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUOM.Name = "txtUOM";
            this.txtUOM.Size = new System.Drawing.Size(197, 22);
            this.txtUOM.TabIndex = 5;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(111, 117);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoBarras.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(111, 40);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 22);
            this.txtDescripcion.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 362);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 64);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(132, 362);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 64);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // dgvSKUS
            // 
            this.dgvSKUS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSKUS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Sku,
            this.Descripcion,
            this.uom,
            this.codigobarras,
            this.codigobidimensional,
            this.qtymanual});
            this.dgvSKUS.Location = new System.Drawing.Point(337, 58);
            this.dgvSKUS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSKUS.Name = "dgvSKUS";
            this.dgvSKUS.RowHeadersWidth = 51;
            this.dgvSKUS.RowTemplate.Height = 24;
            this.dgvSKUS.Size = new System.Drawing.Size(1145, 638);
            this.dgvSKUS.TabIndex = 4;
            this.dgvSKUS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSKUS_CellClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(151, 425);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(247, 362);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 64);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(667, 30);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(315, 22);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar SKU";
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(22, 22);
            this.rbSi.Margin = new System.Windows.Forms.Padding(4);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(41, 21);
            this.rbSi.TabIndex = 9;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(88, 22);
            this.rbNo.Margin = new System.Windows.Forms.Padding(4);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(47, 21);
            this.rbNo.TabIndex = 10;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbQTYNo
            // 
            this.rbQTYNo.AutoSize = true;
            this.rbQTYNo.Checked = true;
            this.rbQTYNo.Location = new System.Drawing.Point(88, 22);
            this.rbQTYNo.Margin = new System.Windows.Forms.Padding(4);
            this.rbQTYNo.Name = "rbQTYNo";
            this.rbQTYNo.Size = new System.Drawing.Size(47, 21);
            this.rbQTYNo.TabIndex = 13;
            this.rbQTYNo.TabStop = true;
            this.rbQTYNo.Text = "No";
            this.rbQTYNo.UseVisualStyleBackColor = true;
            // 
            // rbQTYSi
            // 
            this.rbQTYSi.AutoSize = true;
            this.rbQTYSi.Location = new System.Drawing.Point(15, 22);
            this.rbQTYSi.Margin = new System.Windows.Forms.Padding(4);
            this.rbQTYSi.Name = "rbQTYSi";
            this.rbQTYSi.Size = new System.Drawing.Size(41, 21);
            this.rbQTYSi.TabIndex = 12;
            this.rbQTYSi.Text = "Si";
            this.rbQTYSi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSi);
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 52);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo Bidimensional";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbQTYNo);
            this.groupBox2.Controls.Add(this.rbQTYSi);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 52);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QTY Manual";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Sku
            // 
            this.Sku.DataPropertyName = "Sku";
            this.Sku.HeaderText = "SKU";
            this.Sku.MinimumWidth = 6;
            this.Sku.Name = "Sku";
            this.Sku.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 290;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.HeaderText = "UOM";
            this.uom.MinimumWidth = 6;
            this.uom.Name = "uom";
            this.uom.Width = 50;
            // 
            // codigobarras
            // 
            this.codigobarras.DataPropertyName = "codigobarras";
            this.codigobarras.HeaderText = "Codigo Barras";
            this.codigobarras.MinimumWidth = 6;
            this.codigobarras.Name = "codigobarras";
            this.codigobarras.Width = 125;
            // 
            // codigobidimensional
            // 
            this.codigobidimensional.DataPropertyName = "codigobidimensional";
            this.codigobidimensional.HeaderText = "Codigo QR";
            this.codigobidimensional.MinimumWidth = 6;
            this.codigobidimensional.Name = "codigobidimensional";
            // 
            // qtymanual
            // 
            this.qtymanual.DataPropertyName = "qtymanual";
            this.qtymanual.HeaderText = "QTY Manual";
            this.qtymanual.MinimumWidth = 6;
            this.qtymanual.Name = "qtymanual";
            // 
            // frmSKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvSKUS);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSKU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSKU";
            this.Load += new System.EventHandler(this.FrmSKU_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKUS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUOM;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvSKUS;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbQTYNo;
        private System.Windows.Forms.RadioButton rbQTYSi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigobarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigobidimensional;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtymanual;
    }
}