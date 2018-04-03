using lec05Practica.DAL.Interfaces;
using lec05Practica.DAL.Metodos;
using lec05Practica.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lec05Practica
{
    public partial class ListadoUsuarios : System.Web.UI.Page
    {
        private IUsuario usuarioDB;
        private ITipoUsuario tipoUsuarioBD;

        public ListadoUsuarios()
        {
            usuarioDB = new MUsuario();
            tipoUsuarioBD = new MTipoUsuario();
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            /*List<Usuario> listaUsuarios = usuarioDB.ListarUsuarios();

            var lista = listaUsuarios.Select(x => new
            {
                x.IdUsuario,
                x.Identificacion,
                x.Nombre,
                x.Apellido,
                x.IdTipoUsuario
            });

            dgvUsuarios.DataSource = lista;
            dgvUsuarios.DataBind();*/
        }

        protected void dgvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codUsuarioEdita = dgvUsuarios.SelectedRow.Cells[0].Text;

            Session["codUsuarioEdita"] = codUsuarioEdita;

            Response.Redirect("RegistrarUsuario.aspx");

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}