using lec05Practica.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec05Practica.DAL.Interfaces
{
    public interface ITipoUsuario
    {
        List<TipoUsuario> ListaTipoUsuario();
        TipoUsuario BuscarTipoUsuario(int pIdTipoUsuario);
    }
}
