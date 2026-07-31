using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Usuario;
// Datos necesarios para registrar un nuevo medico en el sistema
public class RegistrarUsuarioDto
{
    // nombre del medico
    public string Nombre { get; set; } = string.Empty;
    // apellido del medico
    public string Apellido { get; set; } = string.Empty;
    // correo electronico del medico
    public string Email { get; set; } = string.Empty;
    // contraseña del medico no es necesario que sea encriptada ya que se encriptara en el backend
    public string Password { get; set; } = string.Empty;
    //telefono del medico
    public string Telefono { get; set; } = string.Empty;
}
