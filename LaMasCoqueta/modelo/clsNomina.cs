using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaMasCoqueta.modelo
{
    public class clsNomina
    {
        public int Codigo { get; set; }
        public string NombreCompleto { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal DeduccionSalud => SalarioBase * 0.04m;
        public decimal DeduccionPension => SalarioBase * 0.04m;
        public decimal AuxilioTransporte => SalarioBase < (2 * 1300000) ? 200000 : 0;
        public decimal SalarioNeto => SalarioBase - DeduccionSalud - DeduccionPension + AuxilioTransporte;

        public string ToCSV()
        {
            return $"{Codigo},{NombreCompleto},{Cargo},{SalarioBase},{DeduccionSalud},{DeduccionPension},{AuxilioTransporte},{SalarioNeto}";
        }

        public static clsNomina CalcularNomina(clsEmpleado empleado)
        {
            return new clsNomina
            {
                Codigo = empleado.Codigo,
                NombreCompleto = $"{empleado.Nombre} {empleado.Apellido}",
                Cargo = empleado.Cargo,
                SalarioBase = empleado.SalarioBase
            };
        }
    }
}