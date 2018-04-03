using lec05Practica.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lec05Practica
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Usuario"] != null)
            {
                Usuario usuarioLog = (Usuario)Session["Usuario"];
                lbUsuario.Text = usuarioLog.Nombre + " " + usuarioLog.Apellido;
            }
        }
    }
}