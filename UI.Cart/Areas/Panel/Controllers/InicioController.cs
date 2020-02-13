using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Cart.Areas.Panel.Controllers
{
    public class InicioController : Controller
    {
        // GET: Panel/Inicio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Panel/Inicio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Panel/Inicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Panel/Inicio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: Panel/Inicio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Panel/Inicio/Edit/5
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

        // GET: Panel/Inicio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Panel/Inicio/Delete/5
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
