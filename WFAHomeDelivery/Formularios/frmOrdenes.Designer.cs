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
            this.components = new System.ComponentModel.Container();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBA3F19COGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A3F19C_OGDataSet = new WFAHomeDelivery.DB_A3F19C_OGDataSet();
            this.dataTable1TableAdapter = new WFAHomeDelivery.DB_A3F19C_OGDataSetTableAdapters.DataTable1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusOrdenImpresaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusOrdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA3F19COGDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A3F19C_OGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(306, 35);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(248, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyUp);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(372, 7);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(107, 13);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "Busqueda No. Orden";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dBA3F19COGDataSetBindingSource;
            // 
            // dBA3F19COGDataSetBindingSource
            // 
            this.dBA3F19COGDataSetBindingSource.DataSource = this.dB_A3F19C_OGDataSet;
            this.dBA3F19COGDataSetBindingSource.Position = 0;
            // 
            // dB_A3F19C_OGDataSet
            // 
            this.dB_A3F19C_OGDataSet.DataSetName = "DB_A3F19C_OGDataSet";
            this.dB_A3F19C_OGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordenDataGridViewTextBoxColumn,
            this.txnDateDataGridViewTextBoxColumn,
            this.txnNumberDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.statusOrdenImpresaIdDataGridViewTextBoxColumn,
            this.pickerDataGridViewTextBoxColumn,
            this.statusOrdenDataGridViewTextBoxColumn,
            this.guiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 377);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dBA3F19COGDataSetBindingSource;
            // 
            // ordenDataGridViewTextBoxColumn
            // 
            this.ordenDataGridViewTextBoxColumn.DataPropertyName = "Orden";
            this.ordenDataGridViewTextBoxColumn.HeaderText = "Orden";
            this.ordenDataGridViewTextBoxColumn.Name = "ordenDataGridViewTextBoxColumn";
            // 
            // txnDateDataGridViewTextBoxColumn
            // 
            this.txnDateDataGridViewTextBoxColumn.DataPropertyName = "TxnDate";
            this.txnDateDataGridViewTextBoxColumn.HeaderText = "TxnDate";
            this.txnDateDataGridViewTextBoxColumn.Name = "txnDateDataGridViewTextBoxColumn";
            // 
            // txnNumberDataGridViewTextBoxColumn
            // 
            this.txnNumberDataGridViewTextBoxColumn.DataPropertyName = "TxnNumber";
            this.txnNumberDataGridViewTextBoxColumn.HeaderText = "TxnNumber";
            this.txnNumberDataGridViewTextBoxColumn.Name = "txnNumberDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // statusOrdenImpresaIdDataGridViewTextBoxColumn
            // 
            this.statusOrdenImpresaIdDataGridViewTextBoxColumn.DataPropertyName = "StatusOrdenImpresa_Id";
            this.statusOrdenImpresaIdDataGridViewTextBoxColumn.HeaderText = "StatusOrdenImpresa_Id";
            this.statusOrdenImpresaIdDataGridViewTextBoxColumn.Name = "statusOrdenImpresaIdDataGridViewTextBoxColumn";
            // 
            // pickerDataGridViewTextBoxColumn
            // 
            this.pickerDataGridViewTextBoxColumn.DataPropertyName = "Picker";
            this.pickerDataGridViewTextBoxColumn.HeaderText = "Picker";
            this.pickerDataGridViewTextBoxColumn.Name = "pickerDataGridViewTextBoxColumn";
            // 
            // statusOrdenDataGridViewTextBoxColumn
            // 
            this.statusOrdenDataGridViewTextBoxColumn.DataPropertyName = "StatusOrden";
            this.statusOrdenDataGridViewTextBoxColumn.HeaderText = "StatusOrden";
            this.statusOrdenDataGridViewTextBoxColumn.Name = "statusOrdenDataGridViewTextBoxColumn";
            // 
            // guiaDataGridViewTextBoxColumn
            // 
            this.guiaDataGridViewTextBoxColumn.DataPropertyName = "Guia";
            this.guiaDataGridViewTextBoxColumn.HeaderText = "Guia";
            this.guiaDataGridViewTextBoxColumn.Name = "guiaDataGridViewTextBoxColumn";
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Name = "frmOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdenes";
            this.Load += new System.EventHandler(this.FrmOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA3F19COGDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A3F19C_OGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.BindingSource dBA3F19COGDataSetBindingSource;
        private DB_A3F19C_OGDataSet dB_A3F19C_OGDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DB_A3F19C_OGDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusOrdenImpresaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusOrdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
    }
}