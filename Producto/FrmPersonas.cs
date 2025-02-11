using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Modelos;

namespace CapaPresentacion
{
    public partial class FrmPersonas : Form
    {
        private readonly PersonaService _personaService;

        public FrmPersonas()
        {
            InitializeComponent();
            _personaService = new PersonaService(new AppDbContext());
            CargarPersonas();
        }

        private void CargarPersonas()
        {
            dgvPersonas.DataSource = _personaService.ObtenerPersonas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var persona = new Persona
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = int.TryParse(txtEdad.Text, out int edad) ? edad : (int?)null,
                CorreoElectronico = txtCorreo.Text
            };

            _personaService.AgregarPersona(persona);
            CargarPersonas();
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0 && int.TryParse(txtId.Text, out int id))
            {
                var persona = new Persona
                {
                    Id = id,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Edad = int.TryParse(txtEdad.Text, out int edad) ? edad : (int?)null,
                    CorreoElectronico = txtCorreo.Text
                };

                _personaService.ActualizarPersona(persona);
                CargarPersonas();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione una persona válida para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0 && int.TryParse(txtId.Text, out int id))
            {
                _personaService.EliminarPersona(id);
                CargarPersonas();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione una persona válida para eliminar.");
            }
        }

        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPersonas.SelectedRows[0];

                txtId.Text = row.Cells["Id"].Value?.ToString() ?? "";
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                txtApellido.Text = row.Cells["Apellido"].Value?.ToString() ?? "";
                txtEdad.Text = row.Cells["Edad"].Value?.ToString() ?? "";
                txtCorreo.Text = row.Cells["CorreoElectronico"].Value?.ToString() ?? "";
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
        }
    }
}
