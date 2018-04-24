using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DATOS
{
    public class Paquete
    {
        public int idPaquete { get; set; }
        public string nombre { get; set; }
        public string incluye { get; set; }
        public string checkin { get; set; }
        public string checkout { get; set; }
        public int cantidadPersonas { get; set; }
        public Decimal precio { get; set; }
        public Decimal personaExtra { get; set; }
    }
}
