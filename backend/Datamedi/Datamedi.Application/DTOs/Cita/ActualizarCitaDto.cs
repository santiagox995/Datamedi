using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Cita
{
    // Datos necesarios para actualizar la informacion de una cita en el sistema
    public class ActualizarCitaDto
    {
        // nueva fecha de la cita 
        public DateTime Fecha { get; set; }
        //nueva hora de la cita
        public TimeSpan Hora { get; set; }
        // nuevo motivo de la cita
        public string Motivo { get; set; } = string.Empty;
        // nuevo estado de la cita (pendiente, confirmada, cancelada, etc.)
        public string Estado { get; set; } = string.Empty;
    }
}
