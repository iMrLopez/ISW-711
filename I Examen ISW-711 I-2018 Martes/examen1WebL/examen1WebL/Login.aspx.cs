using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examen1WebL
{
    public partial class Login : System.Web.UI.Page
    {

        private UserLN usuarioLN;


        protected void Page_Load(object sender, EventArgs e)
        {
            usuarioLN = new UserLN();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String usuario = Usuario.Text;
            String contrasenna = Contrasenna.Text;

            try
            {
                var usuarioactivo = usuarioLN.ValidarIngreso(usuario, contrasenna);

                if (usuario != null)
                {
                    Session["Usuario"] = usuarioactivo;
                      Response.Redirect("Inicio.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "alerta", "alert('El usuario o la contraseña son incorrectas');", true);
                }
            }
            catch (Exception a)
            {

                Console.Write(a);


            }
        }
    }
}