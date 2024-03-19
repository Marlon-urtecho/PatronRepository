using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_PatronRepository
{
    public interface IEmpleadosRepository
    {
        List<Empleado> ObtenerTodos();

        void GuadarTodos(List<Empleado> empleados);
    }
}
