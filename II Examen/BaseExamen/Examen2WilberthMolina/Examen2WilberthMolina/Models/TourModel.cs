using System;

namespace Examen2WilberthMolina.Models
{
    public class TourModel
    {	
        public int idTour { get; set; }

        public int idPaquete { get; set; }

        public string idCliente { get; set; }

        public DateTime fecha { get; set; }
        
        public int cantidadPersonasExtra { get; set; }
                
        public Decimal total { get; set; }        
        
    }
}
