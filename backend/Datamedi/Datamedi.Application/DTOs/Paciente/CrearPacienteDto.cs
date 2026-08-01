using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Paciente;
// Datos necesarios para crear un paciente en el sistema
public class CrearPacienteDto
{
    // nombre del paciente
    public string Nombre { get; set; } = string.Empty;
    // apellido del paciente
    public string Apellido { get; set; } = string.Empty;
    // documento del paciente
    public string Documento { get; set; } = string.Empty;
    // fecha de nacimiento del paciente
    public DateTime FechaNacimiento { get; set; }
    // sexo del paciente
    public string Sexo { get; set; } = string.Empty;
    // telefono del paciente
    public string Telefono { get; set; } = string.Empty;
    // direccion del paciente
    public string Direccion { get; set; } = string.Empty;
    // correo del paciente
    public string Correo { get; set; } = string.Empty;
    // alergias del paciente
    public string Alergias { get; set; } = string.Empty;
    // tipo de sangre del paciente
    public string TipoSangre { get; set; } = string.Empty;
}