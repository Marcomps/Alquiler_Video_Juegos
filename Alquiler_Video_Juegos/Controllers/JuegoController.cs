using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alquileres_Video_Juego.ENT;
using Alquiler_Video_Juegos.BL;

namespace Alquiler_Video_Juegos.Controllers
{
    public class JuegoController : Controller
    {
        // GET: Juego
        public ActionResult Index()
        {
            JuegoBL Juego = new JuegoBL();
            JuegoENT JuegoENT = new JuegoENT();

            var listaJuego = Juego.ObtenerRegistros();

            return View(listaJuego);
        }

        // GET: Juego/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Juego/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juego/Create
        [HttpPost]
        public ActionResult Create(JuegoENT JuegoENT)
        {
            // TODO: Add insert logic here
            JuegoBL JuegoBL = new JuegoBL();
            try
            {
                int result = JuegoBL.AgregarJuegoBD(JuegoENT);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juego/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Juego/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juego/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Juego/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
