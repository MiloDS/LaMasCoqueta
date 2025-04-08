using LaMasCoqueta.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaMasCoqueta
{
    public partial class ListadoNomina : System.Web.UI.Page
    {
        clsGestionNomina clsGestionNomina = new clsGestionNomina();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Lee la lista de nómina desde el archivo
                var listaNominas = clsGestionNomina.LeerNominas();
                gvNomina.DataSource = listaNominas;
                gvNomina.DataBind();
            }
        }
    }
}