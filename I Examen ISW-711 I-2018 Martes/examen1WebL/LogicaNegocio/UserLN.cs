using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class UserLN
    {

        private IUserDatos usuarioDB;

        public UserLN()
        {
            usuarioDB = new UserDatos();
        }

        public UserEntidad ValidarIngreso(string nombreUser, string clave) => usuarioDB.ValidarIngreso(nombreUser, clave);
        
    }
}
