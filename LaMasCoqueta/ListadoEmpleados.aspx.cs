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
        clsGestionEmpleado objGestionEmpleado = new clsGestionEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
                gvEmpleados.DataSource = objGestionEmpleado.LeerEmpleados();
                gvEmpleados.DataBind();
            }
        }
    }
}