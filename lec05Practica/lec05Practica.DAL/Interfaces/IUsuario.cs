using lec05Practica.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec05Practica.DAL.Interfaces
{
    public interface IUsuario
    {
        List<Usuario> ListarUsuarios();
        Usuario BuscarUsuario(int pIdUsuario);
        void InsertarUsuario(Usuario pUsuario);
        void ActualizarUsuario(Usuario pUsuario);
        void EliminarUsuario(int pIdUsuario);
        Usuario ValidarIngreso(string nombreUsuario, string clave);

        Usuario ExisteUsuario(string pIdentificacion, string pNombreUsuario);

        
    }
}
