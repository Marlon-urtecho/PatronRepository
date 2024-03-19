using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Empleados_PatronRepository;

namespace Empleados_PatronRepository
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ruta del archivo para almacenar productos
           string archivoProductos = "productos.txt";

            // Crear una instancia del repositorio de productos
            // utilizando el archivo
            IEmpleadosRepository empleadosRepository = new EmpleadoRepositoryArchivo(archivoProductos);

            // Crear una instancia del gestor de productos 
            // utilizando el repositorio
            GestorEmpleados gestorEmpleados = new GestorEmpleados(empleadosRepository);

            // Agregar algunos productos de ejemplo
            gestorEmpleados.AgregarEmpleado(new Empleado { nombre = "Marcos", edad = 32, puesto="Agente de vta"});
            gestorEmpleados.AgregarEmpleado(new Empleado{ nombre = "Pedro", edad = 40 , puesto="Gerente general" });

            // Mostrar todos los productos
            Console.WriteLine("Todos los Empleados:");
            foreach (var empleado in gestorEmpleados.ObtenerTodosLosEmpleados())
                Console.WriteLine($"Nombre: {empleado.nombre}," +$"Edad: {empleado.edad}"+$"Puesto:{empleado.puesto}");

            Console.ReadKey();
        }
    }
}
