using System.Collections.Generic;
using System.Linq;
using ServiceStack.OrmLite;
using System.Data;
using DAL.Interfaces;
using DATOS;

namespace DAL.Metodos
{
    public class MPaquete : IPaquete
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MPaquete()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<Paquete> ListarPaquetes()
        {
            return _db.Select<Paquete>();
        }

        public Paquete BuscarPaquete(int idPaquete)
        {
            return _db.Select<Paquete>(x => x.idPaquete == idPaquete)
                .FirstOrDefault();
        }

        public void InsertarPaquete(Paquete paquete)
        {
            _db.Insert(paquete);
        }

        public void ActualizarPaquete(Paquete paquete)
        {
            _db.Update(paquete);
        }

        public void EliminarPaquete(int idPaquete)
        {
            _db.Delete<Paquete>(x => x.idPaquete == idPaquete);
        }
    }
}
