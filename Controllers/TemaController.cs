
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
    public class TemaController : Controller
    {
        RepositorioTema repoTema = new RepositorioTema();

        public ActionResult Index()
        {
            return View(repoTema.obtenerTema());
        }
        //Borrar Tema
        public ActionResult TemaDelete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            return View(repoTema.obtenerTema(id));
        }

        [HttpPost]
        public ActionResult TemaDelete(int id, FormCollection datos)
        {
            //Delete del registro
            if (repoTema.obtenerDependenciaTema(id) == 1)
            {
                return RedirectToAction("Error","Tema");
            }
            else
            {
                repoTema.eliminarTema(id);
                return RedirectToAction("Index");
            }
        }
        public ActionResult TemaDetails(int id)
        {
            return View(repoTema.obtenerTema(id));
        }

        public ActionResult TemaEdit(int id)
        {
            return View(repoTema.obtenerTema(id));
        }

        [HttpPost]
        public ActionResult TemaEdit(int id, Tema datosTema)
        {
            datosTema.IdTema = id;
            repoTema.actualizarTema(datosTema);
            return RedirectToAction("Index");
        }
        public ActionResult TemaCreate()
        {
            //Muestra interfaz
            return View();
        }

        [HttpPost]
        public ActionResult TemaCreate(Tema datos)
        {
            repoTema.insertarTema(datos);
            return RedirectToAction("Index");
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}
