using DATOS;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ITour
    {
        List<Tour> ListarTours();
        Tour BuscarTour(int idTour);
        void InsertarTour(DATOS.Tour tour);
        void ActualizarTour(Tour tour);
        void EliminarTour(int idTour);
    }
}
