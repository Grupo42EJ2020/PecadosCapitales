using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public interface ITema
    {
        List<Tema> obtenerCurso();
        Tema obtenerCurso(int IdTema);
        void insertarCurso(Tema datosTema);
        void eliminarCurso(int idTema);
        void actualizarCurso(Curso datosTema);
    }
}