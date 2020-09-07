using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendimia.App.Models;

namespace Vendimia.App
{
    public partial class NuevaVentaForm : Form
    {
        //private List<Cliente> _clientes;
        //private List<>

        public NuevaVentaForm()
        {
            InitializeComponent();
        }

        private void NuevaVentaForm_Load(object sender, EventArgs e)
        {
            InicializarGrid();
            //cmbCliente.DataSource = _clientes;
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "IdCliente";

            cmbArticulo.DisplayMember = "Descripcion";
            cmbArticulo.ValueMember = "IdArticulo";
        }

        private void InicializarGrid()
        {
            DataGridViewLinkColumn linkLabel = new DataGridViewLinkColumn();
            //linkLabel.Text = "❌";
            linkLabel.HeaderText = "";
            linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;

            gridArticulosVtas.Columns.Add("Descripcion", "Descripcion Artículo");
            gridArticulosVtas.Columns.Add("Modelo", "Modelo");
            gridArticulosVtas.Columns.Add("Cantidad", "Cantidad");
            gridArticulosVtas.Columns.Add("Precio", "Precio");
            gridArticulosVtas.Columns.Add("Importe", "Importe");
            gridArticulosVtas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridArticulosVtas.Columns.Add(linkLabel);

            this.gridArticulosVtas.CellContentClick += new DataGridViewCellEventHandler(this.gridArticulosVtas_CellContentClick);
        }

        private void gridArticulosVtas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) //Si presiona eliminar
            {
                gridArticulosVtas.Rows.RemoveAt(e.RowIndex);
                //gridArticulosVtas.Rows[e.RowIndex].Cells.Remove(e);
                //e.RowIndex
                
            }
        }


        private void cmbCliente_TextUpdate(object sender, EventArgs e)
        {
            if (cmbCliente.Text.Length == 3)
            {
                string currentText = cmbCliente.Text;
                cmbCliente.SelectedValueChanged -= cmbCliente_SelectedValueChanged;
                BusquedaClientes(currentText);
                cmbCliente.Text = currentText;
                cmbCliente.SelectionStart = cmbCliente.Text.Length;
                cmbCliente.SelectedValueChanged += cmbCliente_SelectedValueChanged;
            }
        }

        private void cmbCliente_Enter(object sender, EventArgs e)
        {
            cmbCliente.Text = "";
            cmbCliente.Font = new Font(cmbCliente.Font, FontStyle.Regular);
        }

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cmbCliente.Text))
            {
                cmbCliente.Text = "Buscar Cliente";
                cmbCliente.Font = new Font(cmbCliente.Font, FontStyle.Italic);
            }
        }

        private void cmbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            //if (cmbCliente.Text.Length == 3)
            //    e.SuppressKeyPress = true;
            //    BusquedaClientes(cmbCliente.Text);
        }

        private void BusquedaClientes(string busqueda)
        {
            //gridArticulosVtas.Rows.Clear();
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var clientes = context.Clientes
                    .Where(x => x.NombreCte.StartsWith(busqueda))
                    .ToList();

                    cmbCliente.DataSource = clientes;
                    cmbCliente.AutoCompleteMode = AutoCompleteMode.Suggest;

                    //_clientes = clientes;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al intentar realizar busqueda");
            }
        }

        private void cmbCliente_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Back)
            //    cmbCliente.ResetText();
        }

        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem != null)
            {
                Cliente selectedCliente = cmbCliente.SelectedItem as Cliente;
                lblRFC.Text = $"RFC: {selectedCliente.RFC}";
                lblClaveCliente.Text = $"{String.Format("{0:0000}", selectedCliente.IdCliente)}";
            }
            else
            {
                lblRFC.Text = "";
            }
        }

        private void BusquedaArticulo(string busqueda)
        {
            //gridArticulosVtas.Rows.Clear();
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var articulos = context.Articulos
                    .Where(x => x.Descripcion.StartsWith(busqueda))
                    .ToList();

                    cmbArticulo.DataSource = articulos;
                    cmbArticulo.AutoCompleteMode = AutoCompleteMode.Suggest;

                    //_clientes = clientes;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al intentar realizar busqueda");
            }
        }

        private void cmbArticulo_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cmbArticulo.SelectedItem != null)
            //{
            //    Articulo selectedArticulo = cmbArticulo.SelectedItem as Articulo;
            //    //lblRFC.Text = $"RFC: {selectedArticulo.RFC}";
            //    //lblClaveCliente.Text = $"{String.Format("{0:0000}", selectedArticulo.IdCliente)}";
            //}
            //else
            //{
            //    lblRFC.Text = "";
            //}
        }

        private void cmbArticulo_TextUpdate(object sender, EventArgs e)
        {
            if (cmbArticulo.Text.Length == 3)
            {
                string currentText = cmbArticulo.Text;
                //cmbArticulo.SelectedValueChanged -= cmbArticulo_SelectedValueChanged;
                BusquedaArticulo(currentText);
                cmbArticulo.Text = currentText;
                cmbArticulo.SelectionStart = cmbArticulo.Text.Length;
                //cmbArticulo.SelectedValueChanged += cmbArticulo_SelectedValueChanged;
            }
        }

        private void cmbArticulo_Enter(object sender, EventArgs e)
        {
            cmbArticulo.Text = "";
            cmbArticulo.Font = new Font(cmbArticulo.Font, FontStyle.Regular);
        }

        private void cmbArticulo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cmbArticulo.Text))
            {
                cmbArticulo.Text = "Buscar Artículo";
                cmbArticulo.Font = new Font(cmbArticulo.Font, FontStyle.Italic);
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            if (ValidarExistencia()) {
                Articulo selectedArticulo = cmbArticulo.SelectedItem as Articulo;
                gridArticulosVtas.Rows.Add(selectedArticulo.Descripcion,
                    selectedArticulo.Modelo,
                    1, 
                    selectedArticulo.Precio,
                    selectedArticulo.Precio,
                   "❌");
            }
            else
            {
                MessageBox.Show("El artículo seleccionado no cuenta con existencia, favor de verificar");
            }
        }

        private bool ValidarExistencia()
        {
            return true;
        }

        private void gridArticulosVtas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: Validar que solo se pueda editar en una celda
           //Multiplica Cantidad * Precio
            int fila = gridArticulosVtas.CurrentRow.Index;
            int cantidad = Convert.ToInt32( gridArticulosVtas.CurrentCell.Value);
            //Point current = gridArticulosVtas.CurrentCellAddress;
            gridArticulosVtas.Rows[fila].Cells[4].Value = cantidad * (double)gridArticulosVtas.Rows[fila].Cells[3].Value;
            //gridArticulosVtas.Rows[current.X].SetValues()
        }
    }
}
