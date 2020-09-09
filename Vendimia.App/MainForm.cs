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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new VentasForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Cargar Fecha
            tsFecha.Text = $"Fecha: {DateTime.Now.Date: dd/MM/yyyy}";

            Configuracion configuracion;
            //Cargar Configuración
            using (var context = new ApplicationDbContext())
            {
                //context.Database.EnsureCreated();
                //if (!context.Configuracion.Any())
                //{
                //    configuracion = new Configuracion { PrimerConfiguracion = true, Enganche = 0.00M, PlazoMaximo = 0, TasaFinanciamiento = 0.00M };
                //    context.Configuracion.Add(configuracion);
                //    context.SaveChanges();
                //    openChildForm(new ConfiguracionGeneralForm());
                //}
                //else
                //{
                    configuracion = context.Configuracion.First();
                    if (configuracion.PrimerConfiguracion == true)
                    {
                        openChildForm(new ConfiguracionGeneralForm());
                    }
                //}
            }
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ClientesForm());
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ArticulosForm());
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ConfiguracionGeneralForm());
        }
    }
}
