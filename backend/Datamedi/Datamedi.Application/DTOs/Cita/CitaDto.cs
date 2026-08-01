using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Cita
{
    //mostrar informacion de una cita en el sistema
    public class CitaDto
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        public string Motivo { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;
    }
}
