using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_PatronRepository
{
    public class EmpleadoRepositoryArchivo : IEmpleadosRepository
    {
        private string _nombreArchivo;

        public EmpleadoRepositoryArchivo(string nombreArchivo)
        {
            _nombreArchivo = nombreArchivo;
        }


        public void GuadarTodos(List<Empleado> empleados)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_nombreArchivo))
                {
                    foreach (Empleado empleado in empleados)
                    {
                        sw.WriteLine($"{empleado.nombre},{empleado.edad},{empleado.puesto}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error al escribir el Archivo" + $"{e.Message}");
            }

        }

        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                using (StreamReader sr = new StreamReader(_nombreArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        Empleado empleado = new Empleado
                        {
                            nombre = datos[0],
                            edad = Convert.ToInt32(datos[1]),
                            puesto = datos[2]

                        };
                        empleados.Add(empleado);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("Error al escribir el Archivo"+e.Message);
            }

            return empleados;
        }







    }
}

