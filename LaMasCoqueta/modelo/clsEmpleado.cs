using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaMasCoqueta.modelo
{
    public class clsEmpleado
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }

        public string ToCSV()
        {
            return $"{Codigo},{Nombre},{Apellido},{Edad},{Cargo},{SalarioBase}";
        }

        public static clsEmpleado FromCSV(string linea)
        {
            string[] datos = linea.Split(',');
            return new clsEmpleado
            {
                Codigo = int.Parse(datos[0]),
                Nombre = datos[1],
                Apellido = datos[2],
                Edad = int.Parse(datos[3]),
                Cargo = datos[4],
                SalarioBase = decimal.Parse(datos[5])
            };
        }
    }
}