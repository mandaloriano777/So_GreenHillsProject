using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GreenHillsProject.Models;

namespace GreenHillsProject.Controllers
{
    public class PlantasController : Controller
    {
        private mandalorianoDataBaseEntities1 db = new mandalorianoDataBaseEntities1();

        // GET: Plantas
        public ActionResult Index()
        {
            return View(db.Plantas.ToList());
        }

        // GET: Plantas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plantas plantas = db.Plantas.Find(id);
            if (plantas == null)
            {
                return HttpNotFound();
            }
            return View(plantas);
        }

        // GET: Plantas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plantas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NomeComum,NomeCientifico,TempRecomendada,UmidRecomendada,LumiRecomendada")] Plantas plantas)
        {
            if (ModelState.IsValid)
            {
                db.Plantas.Add(plantas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plantas);
        }

        // GET: Plantas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plantas plantas = db.Plantas.Find(id);
            if (plantas == null)
            {
                return HttpNotFound();
            }
            return View(plantas);
        }

        // POST: Plantas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NomeComum,NomeCientifico,TempRecomendada,UmidRecomendada,LumiRecomendada")] Plantas plantas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plantas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plantas);
        }

        // GET: Plantas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plantas plantas = db.Plantas.Find(id);
            if (plantas == null)
            {
                return HttpNotFound();
            }
            return View(plantas);
        }

        // POST: Plantas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plantas plantas = db.Plantas.Find(id);
            db.Plantas.Remove(plantas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
