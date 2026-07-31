using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Paciente
{
    //recibir datos de un paciente para mostrar en el sistema
    public class PacienteDto
    {// id del paciente
        public int Id { get; set; } // Cédula o identificador
        // nombre del paciente
        public string Nombre { get; set; } = string.Empty;
        // apellido del paciente
        public string Apellido { get; set; } = string.Empty;
        //fecha de nacimiento del paciente
        public DateTime FechaNacimiento { get; set; }
        // sexo del paciente
        public string Genero { get; set; } = string.Empty;
        // telefono del paciente
        public string Telefono { get; set; } = string.Empty;
        // direccion del paciente
        public string Direccion { get; set; } = string.Empty;
        // correo del paciente
        public string Correo { get; set; } = string.Empty;
    }
}
