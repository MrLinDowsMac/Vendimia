namespace Vendimia.App
{
    partial class NuevaVentaForm
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFolioVenta = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.gridArticulosVtas = new System.Windows.Forms.DataGridView();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblClaveCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosVtas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(607, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 33);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(526, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblFolioVenta
            // 
            this.lblFolioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolioVenta.AutoSize = true;
            this.lblFolioVenta.Location = new System.Drawing.Point(616, 9);
            this.lblFolioVenta.Name = "lblFolioVenta";
            this.lblFolioVenta.Size = new System.Drawing.Size(10, 13);
            this.lblFolioVenta.TabIndex = 12;
            this.lblFolioVenta.Text = ".";
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(121, 34);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(200, 21);
            this.cmbCliente.TabIndex = 13;
            this.cmbCliente.Text = "Buscar Cliente...";
            this.cmbCliente.TextUpdate += new System.EventHandler(this.cmbCliente_TextUpdate);
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectedValueChanged);
            this.cmbCliente.Enter += new System.EventHandler(this.cmbCliente_Enter);
            this.cmbCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCliente_KeyDown);
            this.cmbCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbCliente_KeyUp);
            this.cmbCliente.Leave += new System.EventHandler(this.cmbCliente_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Artículo:";
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(94, 76);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(227, 21);
            this.cmbArticulo.TabIndex = 15;
            this.cmbArticulo.Text = "Buscar Artículo...";
            this.cmbArticulo.TextUpdate += new System.EventHandler(this.cmbArticulo_TextUpdate);
            this.cmbArticulo.SelectedValueChanged += new System.EventHandler(this.cmbArticulo_SelectedValueChanged);
            this.cmbArticulo.Enter += new System.EventHandler(this.cmbArticulo_Enter);
            this.cmbArticulo.Leave += new System.EventHandler(this.cmbArticulo_Leave);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(330, 75);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(21, 21);
            this.btnAgregarArticulo.TabIndex = 17;
            this.btnAgregarArticulo.Text = "+";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // gridArticulosVtas
            // 
            this.gridArticulosVtas.AllowUserToAddRows = false;
            this.gridArticulosVtas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticulosVtas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticulosVtas.Location = new System.Drawing.Point(12, 127);
            this.gridArticulosVtas.Name = "gridArticulosVtas";
            this.gridArticulosVtas.Size = new System.Drawing.Size(670, 262);
            this.gridArticulosVtas.TabIndex = 18;
            this.gridArticulosVtas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArticulosVtas_CellValueChanged);
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(327, 42);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(10, 13);
            this.lblRFC.TabIndex = 19;
            this.lblRFC.Text = ".";
            // 
            // lblClaveCliente
            // 
            this.lblClaveCliente.AutoSize = true;
            this.lblClaveCliente.Location = new System.Drawing.Point(89, 37);
            this.lblClaveCliente.Name = "lblClaveCliente";
            this.lblClaveCliente.Size = new System.Drawing.Size(10, 13);
            this.lblClaveCliente.TabIndex = 20;
            this.lblClaveCliente.Text = ".";
            this.lblClaveCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NuevaVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.lblClaveCliente);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.gridArticulosVtas);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblFolioVenta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "NuevaVentaForm";
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.NuevaVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosVtas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFolioVenta;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.DataGridView gridArticulosVtas;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label lblClaveCliente;
    }
}