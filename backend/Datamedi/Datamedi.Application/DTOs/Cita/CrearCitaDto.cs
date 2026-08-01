using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Cita
{
    // Datos necesarios para crear una cita en el sistema
    public class CrearCitaDto
    {
        // id del paciente al que se le asignara la cita
        public int PacienteId { get; set; }
        // fecha en la que se realizara la cita
        public DateTime Fecha { get; set; }
        // hora en la que se realizara la cita
        public TimeSpan Hora { get; set; }
        // motivo de la cita
        public string Motivo { get; set; } = string.Empty;
        // estado de la cita (pendiente, confirmada, cancelada, etc.)
        public string Estado { get; set; } = string.Empty;
    }
}