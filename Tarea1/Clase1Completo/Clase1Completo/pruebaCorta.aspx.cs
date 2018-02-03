using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea1
{
    public partial class pruebaCorta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = DateTime.Today.ToString("ddd/MM/yyyy");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int opc1 = rdbPreg1.SelectedIndex;
            int opc2 = rdbPreg2.SelectedIndex;
            int opc3 = rdbPreg3.SelectedIndex;
            int opc4 = rdbPreg4.SelectedIndex;
            int contador = 0;
            String opcioncorrecta = "Opcion I";


            switch (opc1)
            {
                case 0:
                    lbPreg1.Text = "Respuesta Incorrecta";
                    lbPreg1_0.Text = "Solución: a) Definir el título de una tabla ";
                    break;

                case 1:
                    lbPreg1.Text = opcioncorrecta;
                    lbPreg1_0.Text = "Solución: a) Definir el título de una tabla ";
                    break;

                case 2:
                    lbPreg1.Text = "Respuesta Correcta";
                    contador++;
                    break;
            }

            switch (opc2)
            {
                case 0:
                    lbPreg2.Text = opcioncorrecta;
                    lbPreg2_0.Text = "Solución: b) cargar";
                    break;

                case 1:
                    lbPreg2.Text = "Respuesta Correcta";
                    contador++;
                    break;

                case 2:
                    lbPreg2.Text = opcioncorrecta;
                    lbPreg2_0.Text = "Solución: b) cargar";
                    break;

            }


            switch (opc3)
            {
                case 0:
                    lbPreg3.Text = opcioncorrecta;
                    lbPreg3_0.Text = "Solución: b) <th>";
                    break;

                case 1:
                    lbPreg3.Text = "Respuesta Correcta";
                    contador++;
                    break;

                case 2:
                    lbPreg3.Text = opcioncorrecta;
                    lbPreg3_0.Text = "Solución: b) <th>";
                    break;

            }


            switch (opc4)
            {
                case 0:
                    lbPreg4.Text = opcioncorrecta;
                    lbPreg4_0.Text = "Solución: c) method='post'";
                    break;

                case 1:
                    lbPreg4.Text = opcioncorrecta;
                    lbPreg4_0.Text = "Solución: c) method='post' ";
                    break;

                case 2:
                    lbPreg4.Text = "Respuesta Correcta";
                    contador++;
                    break;

            }

            lbCorrectas.Text = contador.ToString();
        }
    }
}