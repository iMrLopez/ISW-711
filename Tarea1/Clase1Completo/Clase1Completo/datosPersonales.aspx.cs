using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea1
{
    public partial class datosPersonales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnMostrar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Trim() == "" ||
                txtApellido1.Text.Trim() == "" ||
                txtApellido2.Text.Trim() == "")
            {
                lbCompleto.Text = "Debe completar todos los espacios.";
            }
            else
            {
                lbCompleto.Text = txtNombre.Text + " " + txtApellido1.Text + " " + txtApellido2.Text + ".";

            }
        }

    }
}