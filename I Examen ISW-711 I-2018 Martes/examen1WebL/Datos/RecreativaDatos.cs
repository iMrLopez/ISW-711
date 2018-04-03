using Entidades;
using ServiceStack.OrmLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RecreativaDatos : IRecreativaDatos
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public RecreativaDatos()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                        SqlServerDialect.Provider);
            _db = _conexion.Open();
        }


        public void Insertar(RecreativaEntidad carrera)
        {
            _db.Insert(carrera);
        }

        public List<RecreativaEntidad> listarRecreativaEntidad()
        {
            return _db.Select<RecreativaEntidad>();
        }


    }
}

