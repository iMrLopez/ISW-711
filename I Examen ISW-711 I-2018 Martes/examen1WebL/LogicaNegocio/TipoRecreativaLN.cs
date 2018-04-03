using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{

    public class TipoRecreativaLN
    {

        private ITipoRecreativaDatos usuarioDB;

        public TipoRecreativaLN()
        {
            usuarioDB = new TipoRecreativaDatos();
        }

        public List<TipoRecreativaEntidad> ListarTipoRecreativaEntidad() => usuarioDB.ListarTipoRecreativaEntidad();


    }
}
