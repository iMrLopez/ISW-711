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
    public partial class listarRecreativa : System.Web.UI.Page
    {
        private List<RecreativaEntidad> listaRecreativas;
        private RecreativaLN recreativa;

        protected void Page_Load(object sender, EventArgs e)
        {
            recreativa = new RecreativaLN();
            this.cargarRecreativas();
        }


        private void cargarRecreativas() {
            //Cargar las recreativas aqui
            try {
                this.listaRecreativas = recreativa.ListarRecreativaEntidad();

                var lista = listaRecreativas.Select(x => new { x.IdRecreativa, x.descripcion, x.tipoRecreativa, x.kilometros, x.costoAdicionales, x.costoTotal, x.idUser }).ToList();

                dgvRecreativa.DataSource = lista;
                dgvRecreativa.DataBind();
            } catch (Exception a) {
                Console.WriteLine(a.Message);

            }




        }


    }
}