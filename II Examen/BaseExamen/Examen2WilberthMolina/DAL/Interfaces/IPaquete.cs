using DATOS;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IPaquete
    {
        List<Paquete> ListarPaquetes();
        Paquete BuscarPaquete(int idPaquete);
        void InsertarPaquete(Paquete paquete);
        void ActualizarPaquete(Paquete paquete);
        void EliminarPaquete(int idPaquete);
    }
}
