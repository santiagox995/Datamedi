using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Consulta
{
    //mostrar la informacion de una consulta medica realizada por un doctor a un paciente
    public class ConsultaDto
    {
        // id de la consulta
        public int Id { get; set; }
        // id del paciente al que se le realizo la consulta
        public int PacienteId { get; set; }
        // fecha en la que se realizo la consulta
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