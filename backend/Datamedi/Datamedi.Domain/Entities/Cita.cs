using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Domain.Entities;

public class Cita // Esta clase representa la cita que el paciente tiene con el doctor.
{
    public int Id { get; set; }
    public int PacienteId { get; set; }
    public DateTime Fecha { get; set; }
    public TimeSpan Hora { get; set; }
    public string Motivo { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
}
