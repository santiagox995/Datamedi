using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Application.DTOs.Usuario;
// Datos necesarios para iniciar sesion en el sistema
public class LoginDto
{
    //email del medico
    public string Email { get; set; } = string.Empty;
    //contraseña escogida por el medico para iniciar sesion en el sistema
    public string Password { get; set; } = string.Empty;
}