using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class CursoController : Controller
    {
        RepositorioCurso repoCurso = new RepositorioCurso();

        //Muestra la lista de Cursos
        public ActionResult Index()
        {
            return View(repoCurso.obtenerCurso());
        }

        //Metodo para borrar un Curso
        public ActionResult CursoDelete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            return View(repoCurso.obtenerCurso(id));
        }

        [HttpPost]
        public ActionResult CursoDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            repoCurso.eliminarCurso(id);

            return RedirectToAction("Index");
        }

        public ActionResult CursoDetails(int id)
        {
            return View(repoCurso.obtenerCurso(id));
        }

        public ActionResult CursoEdit(int id)
        {
            return View(repoCurso.obtenerCurso(id));
        }


        [HttpPost]
        public ActionResult CursoEdit(int id, Curso datosCurso)
        {
            datosCurso.IdCurso = id;
            repoCurso.actualizarCurso(datosCurso);

            return RedirectToAction("Index");
        }

        public ActionResult CursoCreate()
        {
            //mostrar interfaz para llenado
            return View();
        }

        [HttpPost]
        public ActionResult CursoCreate(Curso datos)
        {
            repoCurso.insertarCurso(datos);
            return RedirectToAction("Index");
        }
    }
}
