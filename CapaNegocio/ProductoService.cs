using CapaDatos;
using CapaPresentacion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CapaNegocio
{
    public class ProductoService
    {
        private readonly AppDbContext _context;

        public ProductoService(AppDbContext context)
        {
            _context = context;
        }

        // Método para obtener todos los productos
        public List<Producto1> ObtenerProductos()
        {
            return _context.Producto1.ToList();
        }

        // Método para agregar un nuevo producto
        public void AgregarProducto(Producto1 producto)
        {
            _context.Producto1.Add(producto);
            _context.SaveChanges();
        }

        // Método para actualizar un producto
        public void ActualizarProducto(Producto1 producto)
        {
            
            var productoExistente = _context.Producto1
                .FirstOrDefault(p => p.Id == producto.Id);

            if (productoExistente != null)
            {
                _context.Entry(productoExistente).State = EntityState.Detached; 
            }

            // Actualizamos el producto
            _context.Producto1.Update(producto);
            _context.SaveChanges();
        }

        // Método para eliminar un producto
        public void EliminarProducto(int id)
        {
            var producto = _context.Producto1.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                _context.Producto1.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}
