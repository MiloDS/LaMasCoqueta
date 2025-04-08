using LaMasCoqueta.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaMasCoqueta
{
    public partial class Empleados : System.Web.UI.Page
    {
        clsGestionEmpleado objGestionEmpleado = new clsGestionEmpleado();
        clsEmpleado objEmpleado = new clsEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            objEmpleado.Codigo = int.Parse(txtCodigo.Text);
            objEmpleado.Nombre = txtNombre.Text;
            objEmpleado.Apellido = txtApellido.Text;
            objEmpleado.Edad = int.Parse(txtEdad.Text);
            objEmpleado.Cargo = ddlCargo.Text;
            objEmpleado.SalarioBase = int.Parse(txtSalarioBase.Text);

            objGestionEmpleado.GuardarEmpleado(objEmpleado);
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            ddlCargo.Items.Clear();
            txtSalarioBase.Text = "";
        }
    }
}