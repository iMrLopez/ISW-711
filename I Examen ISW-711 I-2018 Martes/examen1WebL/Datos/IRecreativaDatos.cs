using System.Collections.Generic;
using System.Data;
using Entidades;

namespace Datos
{
    public interface IRecreativaDatos
    {
        void Insertar(RecreativaEntidad carrera);
        List<RecreativaEntidad> listarRecreativaEntidad();
    }
}