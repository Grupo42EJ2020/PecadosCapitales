using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public interface ICurso_Tema
    {
        List<Curso_Tema> obtenerCurso_Tema();
        Curso_Tema obtenerCurso_Tema(int IdCT);
        void insertarCurso_Tema(Curso_Tema datosCurso);
        void eliminarCurso_Tema(int idCT);
        void actualizarCurso_Tema(Curso_Tema datosCurso);
    }
}