using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec05Practica.DATA
{
    public class Usuario
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int IdUsuario { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public int IdTipoUsuario { get; set; }

    }
}
