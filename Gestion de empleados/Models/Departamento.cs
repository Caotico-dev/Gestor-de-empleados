using System;
using System.Collections.Generic;

namespace Gestion_de_empleados_.Models;

public partial class Departamento
{
    public int DepartamentoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Funcion { get; set; } = null!;

    public int? EmpleadoId { get; set; }

    public int? ProyectoId { get; set; }

    public virtual Empleado? Empleado { get; set; }

    public virtual Proyecto? Proyecto { get; set; }
}
