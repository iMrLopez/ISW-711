﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examen1WebL
{
    public partial class Plantilla : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                UserEntidad usuarioLog = (UserEntidad)Session["Usuario"];
                lbUsuario.Text = usuarioLog.nombreUser + " " + usuarioLog.idUser;
            }
            else {
                Response.Redirect("Login.aspx");
            }

        }
    }
}