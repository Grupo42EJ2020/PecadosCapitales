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
    public class VideoController : Controller
    {
        RepositorioVideo repoVideo = new RepositorioVideo();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Video()
        {
            return View(repoVideo.obtenerVideos());
        }

        public ActionResult VideoDelete(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult VideoDelete(int id, FormCollection datos)
        {
            repoVideo.eliminarVideo(id);

            return RedirectToAction("Video");
        }

        public ActionResult VideoDetails(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        public ActionResult VideoEdit(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }


        [HttpPost]
        public ActionResult VideoEdit(int id, Video datosVideo)
        {
            datosVideo.IdVideo = id;
            repoVideo.actualizarVideo(datosVideo);

            return RedirectToAction("Video");
        }

        public ActionResult VideoCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VideoCreate(Video datos)
        {
            repoVideo.insertarVideo(datos);
            return RedirectToAction("Video");
        }

    }
}
