using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
            InicializarGrid();
        }

        private void InicializarGrid()
        {
            gridVentas.Columns.Add("FolioVta", "Folio Venta");
            gridVentas.Columns.Add("IdCliente", "Clave Cliente");
            gridVentas.Columns.Add("Nombre", "Nombre");
            gridVentas.Columns.Add("Total", "Total");
            gridVentas.Columns.Add("Fecha", "Fecha");
            gridVentas.Columns.Add("Estatus", "Estatus");

            gridVentas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {

                NuevaVentaForm nuevaVentaForm = new NuevaVentaForm();
                nuevaVentaForm.FormClosed += VentaNuevaForm_FormClosed;
                nuevaVentaForm.ShowDialog();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }


        private void VentaNuevaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas()
        {
            gridVentas.Rows.Clear();
            using (var context = new ApplicationDbContext())
            {
                var ventas = context.Ventas
                    .Include(x => x.Cliente)
                    .Select(a => new {  
                        a.FolioVta,
                        a.IdCliente,
                        a.Cliente.NombreCompleto,
                        a.Total,
                        a.Fecha,
                        a.Estatus
                    });


                foreach (var venta in ventas)
                {
                    gridVentas.Rows.Add(venta.FolioVta, 
                        venta.IdCliente, venta.NombreCompleto, 
                        venta.Total, venta.Fecha, venta.Estatus );
                }
            }
        }

        private void gridVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

        }
    }
}
