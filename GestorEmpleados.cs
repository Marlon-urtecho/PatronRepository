using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_PatronRepository
{
    public class GestorEmpleados
    {
        private IEmpleadosRepository _repository;

        public GestorEmpleados (IEmpleadosRepository repository)
        {
            _repository = repository;
        }

        public List<Empleado> ObtenerTodosLosEmpleados()
        {
            return _repository.ObtenerTodos();
        }
        
        public void AgregarEmpleado(Empleado empleado)
        {
            List<Empleado> empleados = _repository.ObtenerTodos();
            empleados.Add(empleado);
            _repository.GuadarTodos(empleados);
        }




    }
}
