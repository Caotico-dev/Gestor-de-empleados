using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace Gestion_de_empleados_.Models;

public partial class Empleado
{
    public int EmpleadoId { get; set; }

    public DateOnly? FechaDeIngreso { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Direccion { get; set; } = null!;

    public string? Email { get; set; }
    public string? Activo { get; set; } 
    public decimal? Sueldo {  get; set; }

    public virtual ObservableCollectionListSource<Departamento>? Departamentos { get; set; } 
}
