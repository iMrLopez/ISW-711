using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class RecreativaLN
    {

        private IRecreativaDatos db;

        public RecreativaLN()
        {
            db = new RecreativaDatos();
        }


        public void Insertar(RecreativaEntidad carrera)
        {
            db.Insertar(carrera);
        }

        public List<RecreativaEntidad> ListarRecreativaEntidad() {

            return db.listarRecreativaEntidad();
        }

    }
}
