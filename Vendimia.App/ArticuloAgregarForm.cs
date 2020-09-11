using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Vendimia.App.Models;

namespace Vendimia.App
{
    public partial class ArticuloAgregarForm : Form
    {
        public ArticuloAgregarForm()
        {
            InitializeComponent();
        }

        public ArticuloAgregarForm(int articuloId)
        {
            InitializeComponent();
            CargarArticulo(articuloId);
        }

        private void CargarArticulo(int articuloId)
        {
            using (var context = new ApplicationDbContext())
            {
                articulo = context.Articulos.First(c => c.IdArticulo == articuloId);
            }
            txtDescripcion.Text = articulo.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString("0.00");
            txtModelo.Text = articulo.Modelo;
            txtExistencia.Text = articulo.Existencia.ToString();
            lblClaveArticulo.Text = $"Clave: {String.Format("{0:0000}", articulo.IdArticulo)}";
        }

        private Articulo articulo = new Articulo();

        private void GuardarArticulo()
        {
            if (ValidarArticulo())
            {
                string message = "";
                try
                {
                    using (var context = new ApplicationDbContext())
                    {
                        if (articulo.IdArticulo == 0)
                        {
                            context.Articulos.Add(articulo);
                            context.SaveChanges();
                        }
                        else
                        {
                            context.Articulos.Update(articulo);
                            context.SaveChanges();
                        }
                    }
                    message = "Bien Hecho. El artículo ha sido registrado correctamente";
                    string caption = "Guardar Artículo";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    LimpiarCampos();
                    this.Close();
                }
                catch (Exception ex)
                {
                    message = "Hubo un error";
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private bool ValidarArticulo()
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtModelo.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtPrecio.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtExistencia.Text)) return false;

            articulo.Descripcion = txtDescripcion.Text;
            articulo.Modelo = txtModelo.Text;
            articulo.Precio = Convert.ToDouble(txtPrecio.Text);
            articulo.Existencia = Convert.ToInt32(txtExistencia.Text);
            return true;
        }

        private void LimpiarCampos()
        {
            articulo = new Articulo();
            txtDescripcion.Text = "";
            txtModelo.Text = "";
            txtPrecio.Text = "";
            txtExistencia.Text = "";
            lblClaveArticulo.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarArticulo();
            //this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
