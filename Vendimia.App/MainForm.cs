using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tsFecha.Text = $"Fecha: {DateTime.Now.Date: dd/MM/yyyy}";
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ClientesForm());
        }

    }
}
