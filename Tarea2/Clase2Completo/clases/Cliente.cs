using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase2Completo.clases
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Sexo Sexo { get; set; }
        public string telefono { get; set; }
        public string provincia { get; set; }
        public string password { get; set; }
        public int edad { get; set; }
    }
}