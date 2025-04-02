using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LaMasCoqueta.modelo
{
    public class clsGestionNomina
    {
        private static string rutaNomina = "~/nomina.txt";

        public static void GuardarNomina(clsNomina nomina)
        {
            using (StreamWriter sw = new StreamWriter(rutaNomina, true))
            {
                sw.WriteLine(nomina.ToCSV());
            }
        }

        public static List<clsNomina> LeerNominas()
        {
            List<clsNomina> nominas = new List<clsNomina>();
            if (File.Exists(rutaNomina))
            {
                using (StreamReader sr = new StreamReader(rutaNomina))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        clsNomina nom = new clsNomina
                        {
                            Codigo = int.Parse(datos[0]),
                            NombreCompleto = datos[1],
                            Cargo = datos[2],
                            SalarioBase = decimal.Parse(datos[3])
                        };
                        nominas.Add(nom);
                    }
                }
            }
            return nominas;
        }
    }
}