using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;

namespace Examen2WilberthMolina.Models
{
    public class PaqueteModel
    {
        [DisplayName("Id")]
        public int idPaquete { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [DisplayName("Incluye")]
        public string incluye { get; set; }
        [DisplayName("Entra")]
        public string checkin { get; set; }
        [DisplayName("Sale")]
        public string checkout { get; set; }
        [DisplayName("N")]
        public int cantidadPersonas { get; set; }
        [DisplayName("Precio")]
        public Decimal precio { get; set; }
        [DisplayName("Extra")]
        public Decimal personaExtra { get; set; }
    }
}
