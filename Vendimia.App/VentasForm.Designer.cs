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
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // gridVentas
            // 
            this.gridVentas.AllowUserToAddRows = false;
            this.gridVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Location = new System.Drawing.Point(27, 124);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.Size = new System.Drawing.Size(744, 289);
            this.gridVentas.TabIndex = 1;
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
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.Label lblVentasActivas;
    }
}