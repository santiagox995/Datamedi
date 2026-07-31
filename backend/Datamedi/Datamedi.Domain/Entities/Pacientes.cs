using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Domain.Entities;

public class Paciente // Esta clase representa al paciente que es atendido por el doctor.
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Documento { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; }
    public string Sexo { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string Alergias { get; set; } = string.Empty;
    public string TipoSangre { get; set; } = string.Empty;
    public DateTime FechaRegistro { get; set; }
}
