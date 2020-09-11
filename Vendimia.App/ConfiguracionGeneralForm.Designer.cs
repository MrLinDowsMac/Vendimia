namespace Vendimia.App
{
    partial class ConfiguracionGeneralForm
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
            this.txtFinanciamiento = new System.Windows.Forms.TextBox();
            this.txtPlazoMaximo = new System.Windows.Forms.TextBox();
            this.txtEnganche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFinanciamiento
            // 
            this.txtFinanciamiento.Location = new System.Drawing.Point(184, 62);
            this.txtFinanciamiento.MaxLength = 6;
            this.txtFinanciamiento.Name = "txtFinanciamiento";
            this.txtFinanciamiento.Size = new System.Drawing.Size(54, 20);
            this.txtFinanciamiento.TabIndex = 0;
            this.txtFinanciamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinanciamiento_KeyPress);
            // 
            // txtPlazoMaximo
            // 
            this.txtPlazoMaximo.Location = new System.Drawing.Point(184, 114);
            this.txtPlazoMaximo.MaxLength = 5;
            this.txtPlazoMaximo.Name = "txtPlazoMaximo";
            this.txtPlazoMaximo.Size = new System.Drawing.Size(44, 20);
            this.txtPlazoMaximo.TabIndex = 2;
            this.txtPlazoMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlazoMaximo_KeyPress);
            // 
            // txtEnganche
            // 
            this.txtEnganche.Location = new System.Drawing.Point(184, 88);
            this.txtEnganche.MaxLength = 6;
            this.txtEnganche.Name = "txtEnganche";
            this.txtEnganche.Size = new System.Drawing.Size(54, 20);
            this.txtEnganche.TabIndex = 1;
            this.txtEnganche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnganche_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tasa Financiamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "% Enganche:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plazo Máximo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(285, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(366, 177);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 35);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "meses";
            // 
            // ConfiguracionGeneralForm
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(453, 224);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnganche);
            this.Controls.Add(this.txtPlazoMaximo);
            this.Controls.Add(this.txtFinanciamiento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguracionGeneralForm";
            this.Text = "Configuración General";
            this.Load += new System.EventHandler(this.ConfiguracionGeneralForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFinanciamiento;
        private System.Windows.Forms.TextBox txtPlazoMaximo;
        private System.Windows.Forms.TextBox txtEnganche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
    }
}