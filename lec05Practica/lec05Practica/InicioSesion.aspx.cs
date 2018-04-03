using lec05Practica.DAL.Interfaces;
using lec05Practica.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lec05Practica
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        private IUsuario usuarioDB;

        public InicioSesion()
        {
            usuarioDB = new MUsuario();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = usuarioDB.ValidarIngreso(tbUsuario.Text, tbClave.Text);

                if (usuario != null)
                {
                    Session["Usuario"] = usuario;
                    Response.Redirect("RegistrarUsuario.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "alerta", "alert('El usuario o la contraseña son incorrectas');", true);
                }
            }
            catch (Exception) { }
        }
    }
}