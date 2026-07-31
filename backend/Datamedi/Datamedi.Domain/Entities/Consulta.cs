using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Domain.Entities
{
    internal class Consulta // Esta clase representa la consulta médica que realiza el doctor al paciente.
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public string Diagnostico { get; set; } = string.Empty;
        public string Medicamentos { get; set; } = string.Empty;
        public string Tratamiento { get; set; } = string.Empty;
        public string Observaciones { get; set; } = string.Empty;
    }
}
