using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;
using System.Web.Mvc;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class Curso_Tema_VideoController : Controller
    {
        RepositorioCurso_Tema_Video repoCTV = new RepositorioCurso_Tema_Video();
            //Muestra la lista 
            public ActionResult Index()
            {
                return View(repoCTV.obtenerCTVs());
            }

            //Metodo para borrar 
            public ActionResult CTVDelete(int id)
            {
                //obtener los datos para mostrarlo al usuario antes de borrarlo
                return View(repoCTV.obtenerCTVs());
            }

            [HttpPost]
            public ActionResult CTVDelete(int id, FormCollection datos)
            {
                //realizar el delete del registro
                repoCTV.eliminarCTV(id);

                return RedirectToAction("Index");
            }

            public ActionResult CTVDetails(int id)
            {
                return View(repoCTV.obtenerCTV(id));
            }

            public ActionResult CTVEdit(int id)
            {
                return View(repoCTV.obtenerCTV(id));
            }


            [HttpPost]
            public ActionResult CTVEdit(int id, Curso_Tema_Video datosCTV)
            {
                datosCTV.IdCTV = id;
                repoCTV.actualizarCTV(datosCTV);

                return RedirectToAction("Index");
            }

            public ActionResult CTVCreate()
            {
                //mostrar interfaz para llenado
                return View();
            }

            [HttpPost]
            public ActionResult CTVCreate(Curso_Tema_Video datos)
            {
                repoCTV.insertarCTV(datos);
                return RedirectToAction("Index");
            }
    }
}
