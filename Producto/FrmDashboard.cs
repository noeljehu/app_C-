using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            OpenForm(new FrmPersonas()); // Cargar un formulario por defecto
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPersonas());
        }

        private void btnOtroFormulario_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void OpenForm(Form form)
        {
            panelContainer.Controls.Clear(); // Limpiar panel

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            form.Dock = DockStyle.Fill; // Ajustar tamaño al panel
            panelContainer.Controls.Add(form);
            form.Show();
        }
    }
}
