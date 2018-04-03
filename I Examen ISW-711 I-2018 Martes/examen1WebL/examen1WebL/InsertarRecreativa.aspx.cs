using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examen1WebL
{
    public partial class InsertarRecreativa : System.Web.UI.Page
    {


        private RecreativaLN recreativa;
        private List<TipoRecreativaEntidad> tipoRecreativa;

        protected void Page_Load(object sender, EventArgs e)
        {
            tipoRecreativa = new TipoRecreativaLN().ListarTipoRecreativaEntidad(); //Cargar tipo recreativas
            recreativa = new RecreativaLN();
            this.CargarTipoRecreativa();
        }


        private void CargarTipoRecreativa()
        {
            ddlTipo.Items.Add(new ListItem("--- Seleccione un valor ---", "-1"));
            foreach (var item in tipoRecreativa)
            {
                ddlTipo.Items.Add(new ListItem(item.descripcion, Convert.ToString(item.idTipoRecreativa)));
            }
        }

        protected void btnProcesar_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Session["Usuario"] != null)
                {
                    UserEntidad usuarioedita = (UserEntidad) Session["Usuario"];
                    String descripcion = txtBDescripcion.Text;
                    int tipoRecreativa = ddlTipo.SelectedIndex;
                    int kilometros = Int32.Parse(txtbKilometros.Text);
                    int costo = Int32.Parse(txtbCosto.Text);
                    int total = Int32.Parse(txtbTotal.Text);
                    int codUsuario = usuarioedita.idUser;
                    RecreativaEntidad tempora = new RecreativaEntidad(descripcion, tipoRecreativa, kilometros, costo, total, codUsuario);
                    recreativa.Insertar(tempora);
                }
                else
                {
                }
            }


        }
    }
}