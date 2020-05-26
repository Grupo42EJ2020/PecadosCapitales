using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public interface ICurso_Tema_Video
    {
        List<Curso_Tema_Video> ObtenerCTV();
        Curso_Tema_Video ObtenerCTV(int IdCTV);
        void insertarCTV(Curso_Tema_Video datosCTV);
        void eliminarCTV(int IdCTV);
        void actualizarCTV(Curso_Tema_Video datosCTV);

    }
}