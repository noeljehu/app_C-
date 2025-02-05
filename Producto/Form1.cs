using System;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Modelos;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private readonly ProductoService _productoService;

        public Form1()
        {
            InitializeComponent();
            _productoService = new ProductoService(new AppDbContext());
            CargarProductos();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
        }

        private void CargarProductos()
        {
            try
            {
                var productos = _productoService.ObtenerProductos();
                dataGridView1.DataSource = productos;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar productos: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].DataBoundItem is Producto1 producto)
            {
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = producto.Precio.ToString("N2");
                txtStock.Text = producto.Stock.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var nuevoProducto = new Producto1
                {
                    Nombre = txtNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                _productoService.AgregarProducto(nuevoProducto);
                MostrarExito("Producto agregado correctamente");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MostrarError($"Error al agregar producto: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos() || !ValidarSeleccion()) return;

            try
            {
                var productoSeleccionado = (Producto1)dataGridView1.SelectedRows[0].DataBoundItem;

                var productoActualizado = new Producto1
                {
                    Id = productoSeleccionado.Id,
                    Nombre = txtNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                _productoService.ActualizarProducto(productoActualizado);
                MostrarExito("Producto actualizado correctamente");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MostrarError($"Error al actualizar producto: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;

            try
            {
                var id = ((Producto1)dataGridView1.SelectedRows[0].DataBoundItem).Id;
                _productoService.EliminarProducto(id);
                MostrarExito("Producto eliminado correctamente");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MostrarError($"Error al eliminar producto: {ex.Message}");
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MostrarAdvertencia("Todos los campos son obligatorios");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MostrarAdvertencia("El precio debe ser un valor numérico válido");
                return false;
            }

            if (!int.TryParse(txtStock.Text, out _))
            {
                MostrarAdvertencia("El stock debe ser un valor entero válido");
                return false;
            }

            return true;
        }

        private bool ValidarSeleccion()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MostrarAdvertencia("Por favor seleccione un producto");
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MostrarExito(string mensaje)
        {
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}