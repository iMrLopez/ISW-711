using Entidades;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TipoRecreativaDatos : ITipoRecreativaDatos
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public TipoRecreativaDatos()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                        SqlServerDialect.Provider);
            _db = _conexion.Open();
        }


        public List<TipoRecreativaEntidad> ListarTipoRecreativaEntidad()
        {
            return _db.Select<TipoRecreativaEntidad>();
        }
    }

}
