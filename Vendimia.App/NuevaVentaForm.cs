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
        
        private BindingList<VentaItem> listaVentaDetalle = new BindingList<VentaItem>();
        //private ListBinder<VentaDetalle> listaVentaDetalle = new ListBinder<VentaDetalle>();

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
            
            //gridArticulosVtas.DataSource = ventaDetalle;
            BindingSource bs = new BindingSource();
            bs.DataSource = listaVentaDetalle;
            gridArticulosVtas.AutoGenerateColumns = false;
            gridArticulosVtas.DataSource = bs;

            DataGridViewColumn col0 = new DataGridViewTextBoxColumn();
            col0.DataPropertyName = "IdArticulo";
            col0.HeaderText = "IdArticulo";
            col0.Visible = false;
            gridArticulosVtas.Columns.Add(col0);

            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "Descripcion";
            col1.HeaderText = "Descripcion";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridArticulosVtas.Columns.Add(col1);

            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "Modelo";
            col2.HeaderText = "Modelo";
            gridArticulosVtas.Columns.Add(col2);

            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "Cantidad";
            col3.HeaderText = "Cantidad";
            gridArticulosVtas.Columns.Add(col3);

            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "Precio";
            col4.HeaderText = "Precio";
            gridArticulosVtas.Columns.Add(col4);

            DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "Importe";
            col5.HeaderText = "Importe";
            gridArticulosVtas.Columns.Add(col5);

            DataGridViewLinkColumn linkLabel = new DataGridViewLinkColumn();
            linkLabel.Text = "❌";
            linkLabel.HeaderText = "";
            linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel.DataPropertyName = "IdArticulo";
            linkLabel.UseColumnTextForLinkValue = true;
            gridArticulosVtas.Columns.Add(linkLabel);

            this.gridArticulosVtas.CellContentClick += new DataGridViewCellEventHandler(this.gridArticulosVtas_CellContentClick);

            //gridArticulosVtas.Columns.Add("Descripcion", "Descripcion Artículo");
            //gridArticulosVtas.Columns.Add("Modelo", "Modelo");
            //gridArticulosVtas.Columns.Add("Cantidad", "Cantidad");
            //gridArticulosVtas.Columns.Add("Precio", "Precio");
            //gridArticulosVtas.Columns.Add("Importe", "Importe");
            //gridArticulosVtas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //gridArticulosVtas.Columns.Add(linkLabel);

            //this.gridArticulosVtas.CellContentClick += new DataGridViewCellEventHandler(this.gridArticulosVtas_CellContentClick);

        }

        private void gridArticulosVtas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == 6) //Si presiona eliminar
            {
                gridArticulosVtas.Rows.RemoveAt(e.RowIndex);
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
            Articulo selectedArticulo = cmbArticulo.SelectedItem as Articulo;
            if (selectedArticulo.Existencia > 1)
            {

                VentaItem seleccionado = listaVentaDetalle.FirstOrDefault(x => x.IdArticulo == selectedArticulo.IdArticulo);
                if (seleccionado == null)
                {
                    VentaItem ventaItem = new VentaItem();
                    ventaItem.IdArticulo = selectedArticulo.IdArticulo;
                    ventaItem.Descripcion = selectedArticulo.Descripcion;
                    ventaItem.Modelo = selectedArticulo.Modelo;
                    ventaItem.Cantidad = 1;
                    ventaItem.Precio = selectedArticulo.Precio;
                    ventaItem.Importe = selectedArticulo.Precio * ventaItem.Cantidad;
                    listaVentaDetalle.Add(ventaItem);

                }
                else
                {
                    if (selectedArticulo.Existencia - seleccionado.Cantidad > 0)
                    {
                        listaVentaDetalle.Remove(seleccionado);
                        seleccionado.Cantidad += 1;
                        seleccionado.Importe = seleccionado.Cantidad * selectedArticulo.Precio;
                        listaVentaDetalle.Add(seleccionado);
                    }
                    else
                    {
                        MessageBox.Show("El artículo seleccionado no puede agregar más debido a la existencia, favor de verificar");
                    }
                }
            }
            else
            {
                MessageBox.Show("El artículo seleccionado no cuenta con existencia, favor de verificar");
            }
            //gridArticulosVtas.Rows.Add(selectedArticulo.Descripcion,
            //        selectedArticulo.Modelo,
            //        1, 
            //        selectedArticulo.Precio,
            //        selectedArticulo.Precio,
            //       "❌");


            //if (ValidarExistencia()) {
            //    Articulo selectedArticulo = cmbArticulo.SelectedItem as Articulo;
            //    gridArticulosVtas.Rows.Add(selectedArticulo.Descripcion,
            //        selectedArticulo.Modelo,
            //        1, 
            //        selectedArticulo.Precio,
            //        selectedArticulo.Precio,
            //       "❌");
            //}
            //else
            //{
            //    MessageBox.Show("El artículo seleccionado no cuenta con existencia, favor de verificar");
            //}
        }

        private bool ValidarExistencia()
        {
            //TODO: Validar Existencia.
            //articulo.Existencia
            return true;
        }

        private void gridArticulosVtas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: Validar existencia al cambiar manualmente la cantidad
            
                //Multiplica Cantidad * Precio
                int fila = gridArticulosVtas.CurrentRow.Index;
                int cantidad =(int)(gridArticulosVtas.CurrentCell.Value);
                int IdArticulo = (int)gridArticulosVtas.Rows[fila].Cells[0].Value;

                Articulo articulo;
                using (var context = new ApplicationDbContext())
                {
                    articulo = context.Articulos
                    .First(x => x.IdArticulo == IdArticulo);
                }
                if (cantidad <= articulo.Existencia)
                {
                    gridArticulosVtas.Rows[fila].Cells[5].Value = cantidad * (double)gridArticulosVtas.Rows[fila].Cells[4].Value;
                }
                else
                { 
                    MessageBox.Show("La cantidad indicada supera la de existencia, favor de verificar");
                    gridArticulosVtas.Rows[fila].Cells[3].Value = 1;
                }

        }

    }
}
