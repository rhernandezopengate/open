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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.lblQR = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(266, 31);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(110, 17);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Escanear Ticket";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(192, 51);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(245, 22);
            this.txtTicket.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 374);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(192, 113);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(245, 22);
            this.txtProducto.TabIndex = 4;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(256, 93);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(129, 17);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Escanear Producto";
            // 
            // txtQR
            // 
            this.txtQR.Location = new System.Drawing.Point(192, 184);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(245, 22);
            this.txtQR.TabIndex = 6;
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Location = new System.Drawing.Point(242, 154);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(143, 17);
            this.lblQR.TabIndex = 5;
            this.lblQR.Text = "Codigo Bidimensional";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(477, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Orden Abierta";
            // 
            // frmEscaneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 669);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.lblQR);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.lblTicket);
            this.Name = "frmEscaneos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEscaneos";
            this.Load += new System.EventHandler(this.FrmEscaneos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.Label lblQR;
        private System.Windows.Forms.Label lblStatus;
    }
}