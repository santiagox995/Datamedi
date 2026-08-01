using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Consulta
{
    // Datos necesarios para crear una nueva consulta medica en el sistema
    public class CrearConsultaDto
    {
        // id del paciente al que se le realizara la consulta
        public int PacienteId { get; set; }
        // fecha en la que se realizara la consulta
        public DateTime FechaConsulta { get; set; }
        // motivo de la consulta
        public string Motivo { get; set; } = string.Empty;
        // diagnostico realizado por el doctor al paciente
        public string Diagnostico { get; set; } = string.Empty;
        // medicamentos recetados por el doctor al paciente
        public string Medicamentos { get; set; } = string.Empty;
        // tratamiento recomendado por el doctor al paciente
        public string Tratamiento { get; set; } = string.Empty;
        // observaciones adicionales realizadas por el doctor al paciente
        public string Observaciones { get; set; } = string.Empty;
    }
}