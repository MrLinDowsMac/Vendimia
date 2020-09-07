namespace Vendimia.App
{
    partial class ArticulosForm
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
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.gridArticulos = new System.Windows.Forms.DataGridView();
            this.lblArticulosRegistrados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoArticulo.Location = new System.Drawing.Point(649, 12);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(139, 41);
            this.btnNuevoArticulo.TabIndex = 0;
            this.btnNuevoArticulo.Text = "Nuevo Artículo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // gridArticulos
            // 
            this.gridArticulos.AllowUserToAddRows = false;
            this.gridArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticulos.Location = new System.Drawing.Point(27, 124);
            this.gridArticulos.Name = "gridArticulos";
            this.gridArticulos.Size = new System.Drawing.Size(744, 289);
            this.gridArticulos.TabIndex = 1;
            // 
            // lblArticulosRegistrados
            // 
            this.lblArticulosRegistrados.AutoSize = true;
            this.lblArticulosRegistrados.Location = new System.Drawing.Point(27, 90);
            this.lblArticulosRegistrados.Name = "lblArticulosRegistrados";
            this.lblArticulosRegistrados.Size = new System.Drawing.Size(108, 13);
            this.lblArticulosRegistrados.TabIndex = 2;
            this.lblArticulosRegistrados.Text = "Artículos Registrados";
            // 
            // ArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArticulosRegistrados);
            this.Controls.Add(this.gridArticulos);
            this.Controls.Add(this.btnNuevoArticulo);
            this.Name = "ArticulosForm";
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.ArticulosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.DataGridView gridArticulos;
        private System.Windows.Forms.Label lblArticulosRegistrados;
    }
}