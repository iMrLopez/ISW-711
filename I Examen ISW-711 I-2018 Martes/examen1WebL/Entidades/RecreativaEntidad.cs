using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Entidades
{

    public class RecreativaEntidad
    {

        [AutoIncrement]
        public int IdRecreativa { get; set; }
        public String descripcion { get; set; }
        public int tipoRecreativa { get; set; }
        public int kilometros { get; set; }
        public int costoAdicionales { get; set; }
        public int costoTotal { get; set; }
        public int  idUser { get; set; }

        public RecreativaEntidad(string descripcion, int tipoRecreativa, int kilometros, int costoAdicionales, int costoTotal, int idUser)
        {
            this.descripcion = descripcion;
            this.tipoRecreativa = tipoRecreativa;
            this.kilometros = kilometros;
            this.costoAdicionales = costoAdicionales;
            this.costoTotal = costoTotal;
            this.idUser = idUser;
        }

    }
}