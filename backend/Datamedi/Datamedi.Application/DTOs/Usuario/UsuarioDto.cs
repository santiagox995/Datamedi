using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Usuario;
// Datos necesarios para mostrar la informacion de un medico en el sistema
public class UsuarioDto
{
    // id del medico
    public int Id { get; set; }
    // nombre del medico
    public string Nombre { get; set; } = string.Empty;
    // apellido del medico
    public string Apellido { get; set; } = string.Empty;
    // correo electronico del medico
    public string Email { get; set; } = string.Empty;
    // telefono del medico
    public string Telefono { get; set; } = string.Empty;
    // fecha de registro del medico
    public DateTime FechaRegistro { get; set; }
}