using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace LaMasCoqueta.modelo
{
    public class clsGestionEmpleado
    {
        private  string rutaArchivo = HttpContext.Current.Server.MapPath("~/Archivos/empleados.txt");

        public  void GuardarEmpleado(clsEmpleado empleado)
        {
            // Verificar que la carpeta exista
            string directorio = Path.GetDirectoryName(rutaArchivo);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(empleado.ToCSV());
            }
        }

        public  List<clsEmpleado> LeerEmpleados()
        {
            List<clsEmpleado> empleados = new List<clsEmpleado>();

            if (!File.Exists(rutaArchivo))
            {
                HttpContext.Current.Response.Write("⚠️ Archivo NO encontrado: " + rutaArchivo);
                return empleados; // Retorna lista vacía
            }

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    empleados.Add(clsEmpleado.FromCSV(linea));
                }
            }

            return empleados;
        }

        public  clsEmpleado BuscarEmpleado(int codigo)
        {
            List<clsEmpleado> empleados = LeerEmpleados();
            return empleados.Find(e => e.Codigo == codigo);
        }
    }
}
