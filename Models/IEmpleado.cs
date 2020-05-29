using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public interface IEmpleado
    {
        List<Empleado> obtenerEmpleados();
        Empleado obtenerEmpleados(int IdEmpleado);
        void insertarEmpleado(Empleado datosEmpleado);
        void elimnarEmpleado(int IdEmpleado);
        void actualizarEmpleado(Empleado datosEmpleado);
    }
}