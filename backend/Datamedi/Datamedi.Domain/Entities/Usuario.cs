using System;
using System.Collections.Generic;
using System.Text;

namespace Datamedi.Domain.Entities
{
    public class Usuario // Esta clase representa al usuario el cual seria el doctor que atiende al paciente.
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public string Telefono { get; set; } = string.Empty;
    }
}
