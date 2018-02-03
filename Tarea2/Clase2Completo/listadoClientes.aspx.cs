using Clase2Completo.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase2Completo
{
    public partial class Listado_Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cliente"] != null)
            {
                List<Cliente> lista = new List<Cliente>();
                lista = (List<Cliente>)Session["Cliente"];
                grvListado.DataSource = lista;
                grvListado.DataBind();
            }
        }
    }
}