using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alquileres_Video_Juego.ENT;
using Alquiler_Video_Juegos.BL;
using System.Threading.Tasks;

namespace Alquiler_Video_Juegos.Controllers
{
    public class HistorialController : Controller
    {
        public HistorialBL Historial { get; set; }

        public HistorialController(){
            Historial = new HistorialBL();
        }

        // GET: Historial
        public ActionResult Index(int id)
        {
            var listaCliente = Historial.ObtenerHistorial(id);

            return View(listaCliente);
        }

        // GET: Historial/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Historial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Historial/Create
        [HttpPost]
        public ActionResult Create(HistorialENT Historial)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Historial/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Historial/Edit/5
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

        // GET: Historial/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Historial/Delete/5
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
