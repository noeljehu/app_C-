using System;
using System.Collections.Generic;

namespace CapaPresentacion.Modelos;

public partial class Persona
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Edad { get; set; }

    public string? CorreoElectronico { get; set; }
}
