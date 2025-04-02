using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaMasCoqueta.modelo;

namespace LaMasCoqueta
{
    public partial class ListadoEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
                gvEmpleados.DataSource = clsGestionEmpleado.LeerEmpleados();
                gvEmpleados.DataBind();
            }
        }
    }
}