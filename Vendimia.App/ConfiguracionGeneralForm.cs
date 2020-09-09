using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class ConfiguracionGeneralForm : Form
    {
        public ConfiguracionGeneralForm()
        {
            InitializeComponent();
        }

        private Configuracion conf = new Configuracion();

        public bool ValidarCampos()
        {
            //TODO: Agregar Validacion
            conf.Enganche = Convert.ToDecimal(txtEnganche.Text);
            conf.TasaFinanciamiento = Convert.ToDecimal(txtFinanciamiento.Text);
            conf.PlazoMaximo = Convert.ToInt32(txtPlazoMaximo.Text);
            conf.PrimerConfiguracion = false;
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                try
                {
                    using (var context = new ApplicationDbContext())
                    {
                        context.Configuracion.Update(conf);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Bien Hecho.La configuración ha sido registrada","Guardar Configuración");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un problema al guardar la configuración", "Error");
                }
            }
        }

        private void ConfiguracionGeneralForm_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                conf = context.Configuracion.First();

                txtEnganche.Text = conf.Enganche.ToString();
                txtFinanciamiento.Text = conf.TasaFinanciamiento.ToString();
                txtPlazoMaximo.Text = conf.PlazoMaximo.ToString();
            }
        }
    }
}
