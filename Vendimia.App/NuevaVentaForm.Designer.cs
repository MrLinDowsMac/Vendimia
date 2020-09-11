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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEnganche = new System.Windows.Forms.Label();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hiddenPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.gridAbonos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosVtas)).BeginInit();
            this.panel2.SuspendLayout();
            this.hiddenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAbonos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(559, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 36);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblFolioVenta
            // 
            this.lblFolioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolioVenta.AutoSize = true;
            this.lblFolioVenta.Location = new System.Drawing.Point(680, 9);
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
            this.cmbCliente.Location = new System.Drawing.Point(92, 13);
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
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
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
            this.cmbArticulo.Location = new System.Drawing.Point(65, 55);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(227, 21);
            this.cmbArticulo.TabIndex = 15;
            this.cmbArticulo.Text = "Buscar Artículo...";
            this.cmbArticulo.TextUpdate += new System.EventHandler(this.cmbArticulo_TextUpdate);
            this.cmbArticulo.Enter += new System.EventHandler(this.cmbArticulo_Enter);
            this.cmbArticulo.Leave += new System.EventHandler(this.cmbArticulo_Leave);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(301, 54);
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
            this.gridArticulosVtas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticulosVtas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticulosVtas.Location = new System.Drawing.Point(15, 82);
            this.gridArticulosVtas.Name = "gridArticulosVtas";
            this.gridArticulosVtas.Size = new System.Drawing.Size(726, 207);
            this.gridArticulosVtas.TabIndex = 18;
            this.gridArticulosVtas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArticulosVtas_CellValueChanged);
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(298, 21);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(10, 13);
            this.lblRFC.TabIndex = 19;
            this.lblRFC.Text = ".";
            // 
            // lblClaveCliente
            // 
            this.lblClaveCliente.AutoSize = true;
            this.lblClaveCliente.Location = new System.Drawing.Point(60, 16);
            this.lblClaveCliente.Name = "lblClaveCliente";
            this.lblClaveCliente.Size = new System.Drawing.Size(10, 13);
            this.lblClaveCliente.TabIndex = 20;
            this.lblClaveCliente.Text = ".";
            this.lblClaveCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Enganche:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Bonificación Enganche:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total:";
            // 
            // lblEnganche
            // 
            this.lblEnganche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnganche.AutoSize = true;
            this.lblEnganche.Location = new System.Drawing.Point(661, 308);
            this.lblEnganche.Name = "lblEnganche";
            this.lblEnganche.Size = new System.Drawing.Size(10, 13);
            this.lblEnganche.TabIndex = 24;
            this.lblEnganche.Text = ".";
            this.lblEnganche.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Location = new System.Drawing.Point(661, 332);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(10, 13);
            this.lblBonificacion.TabIndex = 25;
            this.lblBonificacion.Text = ".";
            this.lblBonificacion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(661, 354);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(10, 13);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = ".";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hiddenPanel);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.cmbCliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.cmbArticulo);
            this.panel2.Controls.Add(this.lblBonificacion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblEnganche);
            this.panel2.Controls.Add(this.btnAgregarArticulo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblRFC);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblClaveCliente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.gridArticulosVtas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 592);
            this.panel2.TabIndex = 28;
            // 
            // hiddenPanel
            // 
            this.hiddenPanel.Controls.Add(this.label6);
            this.hiddenPanel.Controls.Add(this.gridAbonos);
            this.hiddenPanel.Controls.Add(this.btnGuardar);
            this.hiddenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hiddenPanel.Location = new System.Drawing.Point(0, 432);
            this.hiddenPanel.Name = "hiddenPanel";
            this.hiddenPanel.Size = new System.Drawing.Size(761, 160);
            this.hiddenPanel.TabIndex = 27;
            this.hiddenPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Abonos Mensuales";
            // 
            // gridAbonos
            // 
            this.gridAbonos.AllowUserToAddRows = false;
            this.gridAbonos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAbonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAbonos.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridAbonos.Location = new System.Drawing.Point(15, 35);
            this.gridAbonos.MultiSelect = false;
            this.gridAbonos.Name = "gridAbonos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAbonos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridAbonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAbonos.Size = new System.Drawing.Size(651, 113);
            this.gridAbonos.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(672, 112);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 36);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Location = new System.Drawing.Point(647, 381);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(94, 36);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // NuevaVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(761, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblFolioVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaVentaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.NuevaVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosVtas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.hiddenPanel.ResumeLayout(false);
            this.hiddenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAbonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEnganche;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel hiddenPanel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView gridAbonos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn radioColumn;
        private System.Windows.Forms.Label label6;
    }
}