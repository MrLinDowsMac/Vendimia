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
    public partial class ArticulosForm : Form
    {
        public ArticulosForm()
        {
            InitializeComponent();
            InicializarGrid();
        }

        private void InicializarGrid()
        {
            DataGridViewLinkColumn linkLabel = new DataGridViewLinkColumn();
            linkLabel.Text = "Editar";
            linkLabel.HeaderText = "Editar";

            gridArticulos.Columns.Add("IdCliente", "Clave Artículo");
            gridArticulos.Columns.Add("Descripcion", "Descripcion");
            gridArticulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridArticulos.Columns.Add(linkLabel);

            this.gridArticulos.CellContentClick += new DataGridViewCellEventHandler(this.gridArticulos_CellContentClick);
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            ArticuloAgregarForm agregarForm = new ArticuloAgregarForm();
            agregarForm.FormClosed += AgregarForm_FormClosed;
            agregarForm.ShowDialog();
        }

        private void gridArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) //Si es presiona editar
            {
                int idArticulo = (int)gridArticulos.Rows[e.RowIndex].Cells[0].Value;
                //MessageBox.Show(vendorName);
                ArticuloAgregarForm agregarForm = new ArticuloAgregarForm(idArticulo);
                agregarForm.Text = "Consultar/Editar Artículo";
                agregarForm.FormClosed += AgregarForm_FormClosed;
                agregarForm.ShowDialog();
            }
        }

        private void ArticulosForm_Load(object sender, EventArgs e)
        {
            //var clientes = null;
            CargarArticulos();
        }

        private void AgregarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            gridArticulos.Rows.Clear();
            using (var context = new ApplicationDbContext())
            {
                var articulos = context.Articulos.Select(a => new
                {
                    IdArticulo = a.IdArticulo,
                    Descripcion = a.Descripcion
                }).ToList();


                foreach (var articulo in articulos)
                {
                    gridArticulos.Rows.Add(articulo.IdArticulo, articulo.Descripcion, "Editar");
                }
            }
        }
    }
}
