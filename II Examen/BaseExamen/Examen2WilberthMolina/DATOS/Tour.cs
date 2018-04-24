using System;

namespace DATOS
{
    public class Tour
    {	
        public int idTour { get; set; }

        public int idPaquete { get; set; }

        public string idCliente { get; set; }

        public DateTime fecha { get; set; }
        
        public int cantidadPersonasExtra { get; set; }
                
        public Decimal total { get; set; }        
        
    }
}
