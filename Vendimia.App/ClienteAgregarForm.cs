using System;
using System.Linq;
using System.Windows.Forms;
using Vendimia.App.Models;

namespace Vendimia.App
{
    public partial class ClienteAgregarForm : Form
    {
        public ClienteAgregarForm()
        {
            InitializeComponent();
        }

        public ClienteAgregarForm(int clienteId)
        {
            InitializeComponent();
            CargarCliente(clienteId);
        }

        private void CargarCliente(int clienteId)
        {
            using (var context = new ApplicationDbContext())
            {
                cliente = context.Clientes.First(c => c.IdCliente == clienteId);
            }
            txtNombre.Text = cliente.NombreCte;
            txtApellidoMaterno.Text = cliente.ApellidoMaterno;
            txtApellidoPaterno.Text = cliente.ApellidoPaterno;
            txtRFC.Text = cliente.RFC;
            lblClaveCliente.Text = $"Clave: {String.Format("{0:0000}", cliente.IdCliente)}";
        }

        private Cliente cliente = new Cliente();

        private void GuardarCliente()
        {
            if (ValidarCliente())
            {
                string message = "";
                try
                {
                    using (var context = new ApplicationDbContext())
                    {
                        if (cliente.IdCliente == 0)
                        {
                            context.Clientes.Add(cliente);
                            context.SaveChanges();
                        }
                        else
                        {
                            context.Clientes.Update(cliente);
                            context.SaveChanges();
                        }
                    }
                    message = "Bien Hecho. El cliente ha sido registrado correctamente";
                    string caption = "Guardar Cliente";
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
        }

        private bool ValidarCliente()
        {
            cliente.NombreCte = txtNombre.Text;
            cliente.ApellidoPaterno = txtApellidoPaterno.Text;
            cliente.ApellidoMaterno = txtApellidoMaterno.Text;
            cliente.RFC = txtRFC.Text;
            return true;
        }

        private void LimpiarCampos()
        {
            cliente = new Cliente();
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtRFC.Text = "";
            lblClaveCliente.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
            //this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
