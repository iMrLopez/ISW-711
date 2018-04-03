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
    public class UserDatos : IUserDatos
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public UserDatos()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                        SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarUser(UserEntidad pUser)
        {
            _db.Update(pUser);
        }

        public UserEntidad ValidarIngreso(string nombreUser, string clave)
        {
            return _db.Select<UserEntidad>(x => x.nombreUser == nombreUser && x.password == clave).FirstOrDefault();
        }

        public UserEntidad BuscarUser(int pIdUser)
        {
            return _db.Select<UserEntidad>(x => x.idUser == pIdUser).FirstOrDefault();
        }

        public void EliminarUser(int pIdUser)
        {
            _db.Delete<UserEntidad>(x => x.idUser == pIdUser);
        }

        public void InsertarUser(UserEntidad pUser)
        {
            _db.Insert(pUser);
        }

        public List<UserEntidad> ListarUsers()
        {
            return _db.Select<UserEntidad>();
        }

        public UserEntidad ExisteUser(int pIdentificacion, string pNombreUser)
        {
            return _db.Select<UserEntidad>(x => x.idUser == pIdentificacion || x.nombreUser == pNombreUser).FirstOrDefault();
        }
    }

}
