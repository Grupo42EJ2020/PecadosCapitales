using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class Curso_TemaController : Controller
    {
        RepositorioCurso_Tema repoCurso_Tema = new RepositorioCurso_Tema();

        //Lista de Curso_Tema
        public ActionResult Index()
        {
            return View(repoCurso_Tema.obtenerCurso_Tema ());
        }

        //Borrar un Curso_Tema
        public ActionResult Curso_TemaDelete(int id)
        {
            //Se obtienen datos de la tabla Curso_Tema para mostrarlo al usuario antes de borrarlo
            return View(repoCurso_Tema.obtenerCurso_Tema(id));
        }

        [HttpPost]
        public ActionResult Curso_TemaDelete(int id, FormCollection datos)
        {
            //Delete del registro de Curso_Tema
            repoCurso_Tema.eliminarCurso_Tema(id);

            return RedirectToAction("Index");
        }

        public ActionResult Curso_TemaDetails(int id)
        {
            return View(repoCurso_Tema.obtenerCurso_Tema (id));
        }

        public ActionResult Curso_TemaEdit(int id)
        {
            return View(repoCurso_Tema.obtenerCurso_Tema(id));
        }


        [HttpPost]
        public ActionResult Curso_TemaEdit(int id, Curso_Tema datosCurso_Tema)
        {
            datosCurso_Tema.IdCT = id;
            repoCurso_Tema.actualizarCurso_Tema(datosCurso_Tema);

            return RedirectToAction("Index");
        }

        public ActionResult Curso_TemaCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Curso_TemaCreate(Curso_Tema datos)
        {
            repoCurso_Tema.insertarCurso_Tema(datos);
            return RedirectToAction("Index");
        }

    }
}
