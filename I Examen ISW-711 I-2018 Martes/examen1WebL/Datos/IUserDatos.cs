using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public interface IUserDatos
    {
        void ActualizarUser(UserEntidad pUser);
        UserEntidad BuscarUser(int pIdUser);
        void EliminarUser(int pIdUser);
        UserEntidad ExisteUser(int pIdentificacion, string pNombreUser);
        void InsertarUser(UserEntidad pUser);
        List<UserEntidad> ListarUsers();
        UserEntidad ValidarIngreso(string nombreUser, string clave);
    }
}