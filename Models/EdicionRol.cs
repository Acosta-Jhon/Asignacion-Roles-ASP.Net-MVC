using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Ejercicio.Web.Models
{
    public class EdicionRol
    {
        public IdentityRole Rol { get; set; }
        public IEnumerable<IdentityUser> miembros { get; set; }
        public IEnumerable<IdentityUser> noMiembros { get; set; }
    }
}