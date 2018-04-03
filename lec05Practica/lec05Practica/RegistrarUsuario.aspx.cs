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
    public partial class RegistrarUsuario : System.Web.UI.Page
    {
        IUsuario usuarioDB;
        ITipoUsuario tipoUsuarioDB;

        public RegistrarUsuario()
        {
            usuarioDB = new MUsuario();
            tipoUsuarioDB = new MTipoUsuario();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["codUsuarioEdita"] != null)
                {

                    List<Usuario> listaUsuarios = usuarioDB.ListarUsuarios();
                    var oUsuarioEdita = listaUsuarios.FirstOrDefault(x => x.IdUsuario == Convert.ToInt32(Session["codUsuarioEdita"]));
                    LlenarDDLTipoUSuario();

                    hfCodUsuario.Value = oUsuarioEdita.IdUsuario.ToString();
                    tbIdentificacion.Text = oUsuarioEdita.Identificacion;
                    tbNombre.Text = oUsuarioEdita.Nombre;
                    tbApellidos.Text = oUsuarioEdita.Apellido;
                    tbNombreUsuario.Text = oUsuarioEdita.NombreUsuario;
                    tbClave.Text = oUsuarioEdita.Clave;
                    ddlTipoUsuario.SelectedIndex = oUsuarioEdita.IdTipoUsuario;

                    tbIdentificacion.ReadOnly = true;
                }
                else
                {
                    if (ddlTipoUsuario.Items.Count <= 0)
                        LlenarDDLTipoUSuario();
                }
            }    
        }

        private void LlenarDDLTipoUSuario()
        {
            List<TipoUsuario> lista = tipoUsuarioDB.ListaTipoUsuario();

            ddlTipoUsuario.Items.Add(new ListItem("--- Seleccione un valor ---", "-1"));
            foreach (var item in lista)
            {
                ddlTipoUsuario.Items.Add(new ListItem(item.Nombre, Convert.ToString(item.IdTipoUsuario)));
            }
            
        }

        private void LimpiarFormulario()
        {
            tbIdentificacion.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbApellidos.Text = string.Empty;
            tbNombreUsuario.Text = string.Empty;
            tbClave.Text = string.Empty;
        }

        protected void btRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Session["codUsuarioEdita"] == null)
                {
                    if (usuarioDB.ExisteUsuario(tbIdentificacion.Text, tbNombreUsuario.Text) == null)
                    {
                        //typeof(Usuario).GetModelMetadata().PrimaryKey.AutoIncrement = false;
                        usuarioDB.InsertarUsuario(new Usuario
                        {
                            Identificacion = tbIdentificacion.Text,
                            Nombre = tbNombre.Text,
                            Apellido = tbApellidos.Text,
                            NombreUsuario = tbNombreUsuario.Text,
                            Clave = tbClave.Text,
                            IdTipoUsuario = Convert.ToInt32(ddlTipoUsuario.SelectedValue)
                        });

                        //ClientScript.RegisterStartupScript(GetType(), "confirmar", "alert('El usuario ha sido registrado correctamente!');", true);
                        mensaje.Visible = true;
                        mensajeError.Visible = false;
                        textoMensaje.InnerHtml = "El usuario ha sido registrado correctamente!";
                        LimpiarFormulario();
                        tbIdentificacion.Focus();
                    }
                    else
                    {
                        //ClientScript.RegisterStartupScript(GetType(), "error", "alert('Error, ya existe un usuario con esa identificación!'", true);
                        mensaje.Visible = false;
                        mensajeError.Visible = true;
                        textoMensajeError.InnerHtml = "Error, ya existe un usuario con esa identificación o ese nombre de usuario!";
                        tbIdentificacion.Focus();
                    }
                }else
                {

                    Usuario oUsuario = new Usuario
                    {
                        IdUsuario = Convert.ToInt32(hfCodUsuario.Value),
                        Identificacion = tbIdentificacion.Text,
                        Nombre = tbNombre.Text,
                        Apellido = tbApellidos.Text,
                        NombreUsuario = tbNombreUsuario.Text,
                        Clave = tbClave.Text,
                        IdTipoUsuario = Convert.ToInt32(ddlTipoUsuario.SelectedValue)
                    };

                    lbDescripcionTipoUsuario.Text = tbApellidos.Text;
                    usuarioDB.ActualizarUsuario(oUsuario);

                    mensaje.Visible = true;
                    mensajeError.Visible = false;
                    textoMensaje.InnerHtml = "El usuario ha sido actualizado correctamente!";
                    LimpiarFormulario();
                    tbIdentificacion.Focus();
                    //Destruye la variable de sesion
                    Session.Remove("codUsuarioEdita");
                }          
            }
            catch (Exception)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ocurrió un error";
            }

        }

        protected void ddlTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Actualiza la descripcion del TipoUsuario al cambiar el valor seleccionado del DropDownList
            TipoUsuario oTipoUsuario;
            if(ddlTipoUsuario.SelectedIndex != 0)
            {
                oTipoUsuario = tipoUsuarioDB.BuscarTipoUsuario(Convert.ToInt32(ddlTipoUsuario.SelectedValue));
                lbDescripcionTipoUsuario.Text = oTipoUsuario.Descripcion;
            }else
            {
                lbDescripcionTipoUsuario.Text = string.Empty;
            }
        }
    }
}