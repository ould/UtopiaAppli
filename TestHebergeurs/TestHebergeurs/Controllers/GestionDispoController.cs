using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestHebergeurs.Models;

namespace TestHebergeurs.Controllers
{
    [Authorize]
    public class GestionDispoController : Controller
    {
        // GET: GestionDispo
        public ActionResult Index()
        {
            var model = new List<Disponibilite>();

            return View(model);
        }

        // GET: GestionDispo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GestionDispo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GestionDispo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionDispo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GestionDispo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionDispo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GestionDispo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}