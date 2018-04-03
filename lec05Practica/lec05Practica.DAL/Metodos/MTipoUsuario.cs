using lec05Practica.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lec05Practica.DATA;
using System.Data;
using ServiceStack.OrmLite;

namespace lec05Practica.DAL.Metodos
{
    public class MTipoUsuario : ITipoUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MTipoUsuario()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                       SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public TipoUsuario BuscarTipoUsuario(int pIdTipoUsuario)
        {
            return _db.Select<TipoUsuario>(x => x.IdTipoUsuario == pIdTipoUsuario).FirstOrDefault();
        }

        public List<TipoUsuario> ListaTipoUsuario()
        {
            return _db.Select<TipoUsuario>();
        }
    }
}
