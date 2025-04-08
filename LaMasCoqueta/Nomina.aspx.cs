using LaMasCoqueta.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaMasCoqueta
{
    public partial class Nomina : System.Web.UI.Page
    {
        clsGestionNomina clsGestionNomina = new clsGestionNomina();
        clsEmpleado clsEmpleado = new clsEmpleado();
        clsNomina clsNomina = new clsNomina();
        clsGestionEmpleado clsGestionEmpleado = new clsGestionEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtEmpleado.Text);
                clsEmpleado empleado = clsGestionEmpleado.BuscarEmpleado(codigo);

                if (empleado != null)
                {
                    // Se calcula la nómina usando la clase que ya hace los cálculos
                    clsNomina nominaCalculada = clsNomina.CalcularNomina(empleado);

                    // Asignamos los valores a los controles para visualizarlos
                    txtNombre.Text = nominaCalculada.NombreCompleto;
                    txtCargo.Text = nominaCalculada.Cargo;
                    txtSalarioBase.Text = nominaCalculada.SalarioBase.ToString();                    
                    txtDeduccionSalud.Text = nominaCalculada.DeduccionSalud.ToString();
                    txtDeduccionPension.Text = nominaCalculada.DeduccionPension.ToString();
                    txtAuxilioTransporte.Text = nominaCalculada.AuxilioTransporte.ToString();
                    txtTotalPagar.Text = nominaCalculada.SalarioNeto.ToString();
                }
                else
                {
                    Response.Write("<script>alert('Empleado no encontrado');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtEmpleado.Text);
                clsEmpleado empleado = clsGestionEmpleado.BuscarEmpleado(codigo);

                if (empleado != null)
                {
                    clsNomina nominaCalculada = clsNomina.CalcularNomina(empleado);
                    clsGestionNomina.GuardarNomina(nominaCalculada);
                    Response.Write("<script>alert('Nómina guardada correctamente');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Empleado no encontrado');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error al guardar nómina: " + ex.Message + "');</script>");
            }
        }

        protected void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtEmpleado.Text);
                clsEmpleado empleado = clsGestionEmpleado.BuscarEmpleado(codigo);
                if (empleado != null)
                {
                    // Mostrar datos del empleado
                    txtNombre.Text = $"{empleado.Nombre} {empleado.Apellido}";
                    txtCargo.Text = empleado.Cargo;
                    txtSalarioBase.Text = empleado.SalarioBase.ToString();                    
                }
                else
                {
                    Response.Write("<script>alert('Empleado no encontrado');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error al buscar empleado: " + ex.Message + "');</script>");
            }
        }
    }
}