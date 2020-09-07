namespace Vendimia.App
{
    partial class VentasForm
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
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.FolioVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveCte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVentasActivas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaVenta.Location = new System.Drawing.Point(649, 12);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(139, 41);
            this.btnNuevaVenta.TabIndex = 0;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            // 
            // gridVentas
            // 
            this.gridVentas.AllowUserToAddRows = false;
            this.gridVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolioVta,
            this.ClaveCte,
            this.Nombre,
            this.Total,
            this.FechaVta,
            this.Estatus});
            this.gridVentas.Location = new System.Drawing.Point(27, 124);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.Size = new System.Drawing.Size(744, 289);
            this.gridVentas.TabIndex = 1;
            // 
            // FolioVta
            // 
            this.FolioVta.FillWeight = 72.75321F;
            this.FolioVta.HeaderText = "Folio Venta";
            this.FolioVta.Name = "FolioVta";
            // 
            // ClaveCte
            // 
            this.ClaveCte.FillWeight = 104.562F;
            this.ClaveCte.HeaderText = "Clave Cliente";
            this.ClaveCte.Name = "ClaveCte";
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 91.31642F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Total
            // 
            this.Total.FillWeight = 86.98965F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // FechaVta
            // 
            this.FechaVta.FillWeight = 110.9502F;
            this.FechaVta.HeaderText = "Fecha";
            this.FechaVta.Name = "FechaVta";
            // 
            // Estatus
            // 
            this.Estatus.FillWeight = 133.4286F;
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            // 
            // lblVentasActivas
            // 
            this.lblVentasActivas.AutoSize = true;
            this.lblVentasActivas.Location = new System.Drawing.Point(27, 90);
            this.lblVentasActivas.Name = "lblVentasActivas";
            this.lblVentasActivas.Size = new System.Drawing.Size(78, 13);
            this.lblVentasActivas.TabIndex = 2;
            this.lblVentasActivas.Text = "Ventas Activas";
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVentasActivas);
            this.Controls.Add(this.gridVentas);
            this.Controls.Add(this.btnNuevaVenta);
            this.Name = "VentasForm";
            this.Text = "VentasForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolioVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveCte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.Label lblVentasActivas;
    }
}