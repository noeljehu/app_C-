using System;
using System.Collections.Generic;

namespace CapaPresentacion.Modelos
{
    public class Producto1
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
