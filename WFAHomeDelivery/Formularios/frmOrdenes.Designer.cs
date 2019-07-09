namespace WFAHomeDelivery.Formularios
{
    partial class frmOrdenes
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
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orden,
            this.User,
            this.Descripcion,
            this.TxnNumber,
            this.TxnDate});
            this.dgvOrdenes.Location = new System.Drawing.Point(12, 61);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(590, 377);
            this.dgvOrdenes.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(194, 35);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(248, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyUp);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(260, 7);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(107, 13);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "Busqueda No. Orden";
            // 
            // Orden
            // 
            this.Orden.DataPropertyName = "Orden";
            this.Orden.HeaderText = "Orden";
            this.Orden.Name = "Orden";
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // TxnNumber
            // 
            this.TxnNumber.DataPropertyName = "TxnNumber";
            this.TxnNumber.HeaderText = "TxnNumber";
            this.TxnNumber.Name = "TxnNumber";
            // 
            // TxnDate
            // 
            this.TxnDate.DataPropertyName = "TxnDate";
            this.TxnDate.HeaderText = "TxnDate";
            this.TxnDate.Name = "TxnDate";
            this.TxnDate.Width = 130;
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvOrdenes);
            this.Name = "frmOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdenes";
            this.Load += new System.EventHandler(this.FrmOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxnDate;
    }
}