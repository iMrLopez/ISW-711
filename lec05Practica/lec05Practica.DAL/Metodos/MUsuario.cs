using lec05Practica.DAL.Interfaces;
using lec05Practica.DATA;
using ServiceStack.OrmLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec05Practica.DAL.Metodos
{
    public class MUsuario : IUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MUsuario()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                        SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarUsuario(Usuario pUsuario)
        {
            _db.Update(pUsuario);
        }

        public Usuario ValidarIngreso(string nombreUsuario, string clave)
        {
            return _db.Select<Usuario>(x => x.NombreUsuario == nombreUsuario && x.Clave == clave).FirstOrDefault();
        }

        public Usuario BuscarUsuario(int pIdUsuario)
        {
            return _db.Select<Usuario>(x => x.IdUsuario == pIdUsuario).FirstOrDefault();
        }

        public void EliminarUsuario(int pIdUsuario)
        {
            _db.Delete<Usuario>(x => x.IdUsuario == pIdUsuario);
        }

        public void InsertarUsuario(Usuario pUsuario)
        {
            _db.Insert(pUsuario);
        }

        public List<Usuario> ListarUsuarios()
        {
            return _db.Select<Usuario>();
        }

        public Usuario ExisteUsuario(string pIdentificacion, string pNombreUsuario)
        {
            return _db.Select<Usuario>(x => x.Identificacion == pIdentificacion || x.NombreUsuario == pNombreUsuario).FirstOrDefault();
        }
    }
}
