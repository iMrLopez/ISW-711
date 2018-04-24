using System.Collections.Generic;
using System.Linq;
using ServiceStack.OrmLite;
using System.Data;
using DAL.Interfaces;
using DATOS;

namespace DAL.Metodos
{
    public class MTour : ITour
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MTour()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<Tour> ListarTours()
        {
            return _db.Select<Tour>();
        }

        public Tour BuscarTour(int idTour)
        {
            return _db.Select<Tour>(x => x.idTour == idTour)
                .FirstOrDefault();
        }

        public void InsertarTour(Tour tour)
        {
            _db.Insert(tour);
        }

        public void ActualizarTour(Tour tour)
        {
            _db.Update(tour);
        }

        public void EliminarTour(int idTour)
        {
            _db.Delete<Tour>(x => x.idTour == idTour);
        }
    }
}
