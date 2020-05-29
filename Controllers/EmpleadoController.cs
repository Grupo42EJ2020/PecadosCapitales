using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class EmpleadoController : Controller
    {
        //
        // GET: /Empleado/
        RepositorioEmpleado repoEmpleado = new RepositorioEmpleado();

        public ActionResult Index()
        {
            return View(repoEmpleado.obtenerEmpleados());
        }

        public ActionResult Details(int id)
        {
            return View(repoEmpleado.obtenerEmpleados(id));
        }

        public ActionResult Delete(int id)
        {
            return View(repoEmpleado.obtenerEmpleados(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection frm)
        {
            repoEmpleado.elimnarEmpleado(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(repoEmpleado.obtenerEmpleados(id));

        }
        [HttpPost]
        public ActionResult Edit(int id, Empleado datos)
        {
            datos.IdEmpleado = id;
            repoEmpleado.actualizarEmpleado(datos);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Empleado datos)
        {

            repoEmpleado.insertarEmpleado(datos);
            return RedirectToAction("Index");
        }
    }
}
