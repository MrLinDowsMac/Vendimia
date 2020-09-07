using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Vendimia.App.Models;

namespace Vendimia.App
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
            InicializarGrid();

        }

        private void InicializarGrid()
        {
            DataGridViewLinkColumn linkLabel = new DataGridViewLinkColumn();
            linkLabel.Text = "Editar";
            linkLabel.HeaderText = "Editar";

            gridClientes.Columns.Add("IdCliente", "Clave Cliente");
            gridClientes.Columns.Add("Nombre", "Nombre");
            gridClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridClientes.Columns.Add(linkLabel);

            this.gridClientes.CellContentClick += new DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ClienteAgregarForm agregarForm = new ClienteAgregarForm();
            agregarForm.FormClosed += AgregarForm_FormClosed;
            agregarForm.ShowDialog();
        }

        private void AgregarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarClientes();
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) //Si es presiona editar
            {
                int idCliente = (int)gridClientes.Rows[e.RowIndex].Cells[0].Value;
                //MessageBox.Show(vendorName);
                ClienteAgregarForm agregarForm = new ClienteAgregarForm(idCliente);
                agregarForm.Text = "Consultar/Editar Cliente";
                agregarForm.FormClosed += AgregarForm_FormClosed;
                agregarForm.ShowDialog();
            }
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            //var clientes = null;
            CargarClientes();   
        }

        private void CargarClientes()
        {
            gridClientes.Rows.Clear();
            using (var context = new ApplicationDbContext())
            {
                var clientes = context.Clientes.Select(c => new
                {
                    IdCliente = c.IdCliente,
                    Nombre = c.NombreCte + " " + c.ApellidoPaterno + " " + c.ApellidoMaterno
                }).ToList();

                //gridClientes.DataSource = clientes;

                foreach (var cliente in clientes)
                {
                    gridClientes.Rows.Add(cliente.IdCliente, cliente.Nombre, "Editar");
                }
            }
        }

    }
}
