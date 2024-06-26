using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenHillsProject.Models;

namespace GreenHillsProject.Controllers
{
    public class PlantaController : Controller
    {
        public void IniciarLista()
        {
            if (Session["Planta"] == null)
                Session["Planta"] = new List<Planta>();
        }

        // GET: Planta
        public ActionResult Index()
        {
            IniciarLista();
            return View(Session["Planta"]);
        }

        // GET: Planta/Details/5
        public ActionResult Details(int id)
        {
            IniciarLista();
            return View((Session["Planta"] as List<Planta>).ElementAt(id));
        }

        // GET: Planta/Create
        public ActionResult Create()
        {
            IniciarLista();
            var listNomeCom = new List<SelectListItem>();

            listNomeCom.Add(new SelectListItem() { Text = "Feijão", Value = "FEI" });
            listNomeCom.Add(new SelectListItem() { Text = "Tomate", Value = "TOM" });
            listNomeCom.Add(new SelectListItem() { Text = "Pimentão", Value = "PIM" });
            listNomeCom.Add(new SelectListItem() { Text = "Pepino", Value = "PEP" });
            listNomeCom.Add(new SelectListItem() { Text = "Rúcula", Value = "RUC" });
            listNomeCom.Add(new SelectListItem() { Text = "Cebolinha", Value = "CEB" });
            listNomeCom.Add(new SelectListItem() { Text = "Alface", Value = "ALF" });
            listNomeCom.Add(new SelectListItem() { Text = "Coentro", Value = "COE" });
            listNomeCom.Add(new SelectListItem() { Text = "Manjericão", Value = "MAN" });
            listNomeCom.Add(new SelectListItem() { Text = "Hortelã", Value = "HOR" });
            listNomeCom.Add(new SelectListItem() { Text = "Salsa", Value = "SAL" });
            listNomeCom.Add(new SelectListItem() { Text = "Couve", Value = "COU" });
            listNomeCom.Add(new SelectListItem() { Text = "Espinafre", Value = "ESP" });
            listNomeCom.Add(new SelectListItem() { Text = "Rabanete", Value = "RAB" });
            listNomeCom.Add(new SelectListItem() { Text = "Agrião", Value = "AGR" });
            listNomeCom.Add(new SelectListItem() { Text = "Mostarda", Value = "MOS" });
            listNomeCom.Add(new SelectListItem() { Text = "Cenoura", Value = "CEN" });
            listNomeCom.Add(new SelectListItem() { Text = "Beterraba", Value = "BET" });
            listNomeCom.Add(new SelectListItem() { Text = "Nabo", Value = "NAB" });
            listNomeCom.Add(new SelectListItem() { Text = "Chicória", Value = "CHI" });
            listNomeCom.Add(new SelectListItem() { Text = "Selecione uma opção", Value = "", Selected = true });

            ViewBag.listNomeCom = listNomeCom;


            return View();
        }

        // POST: Planta/Create
        [HttpPost]
        public ActionResult Create(Planta planta)
        {
            try
            {
                // TODO: Add insert logic here
                IniciarLista();
                (Session["Planta"] as List<Planta>).Add(planta);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Planta/Edit/5
        public ActionResult Edit(int id)
        {
            IniciarLista();
            var plantas = (Session["Planta"] as List<Planta>);
            var planta = plantas.ElementAt(id);

            var listNomeCom = new List<SelectListItem>();

            listNomeCom.Add(new SelectListItem() { Text = "Feijão", Value = "FEI" });
            listNomeCom.Add(new SelectListItem() { Text = "Tomate", Value = "TOM" });
            listNomeCom.Add(new SelectListItem() { Text = "Pimentão", Value = "PIM" });
            listNomeCom.Add(new SelectListItem() { Text = "Pepino", Value = "PEP" });
            listNomeCom.Add(new SelectListItem() { Text = "Rúcula", Value = "RUC" });
            listNomeCom.Add(new SelectListItem() { Text = "Cebolinha", Value = "CEB" });
            listNomeCom.Add(new SelectListItem() { Text = "Alface", Value = "ALF" });
            listNomeCom.Add(new SelectListItem() { Text = "Coentro", Value = "COE" });
            listNomeCom.Add(new SelectListItem() { Text = "Manjericão", Value = "MAN" });
            listNomeCom.Add(new SelectListItem() { Text = "Hortelã", Value = "HOR" });
            listNomeCom.Add(new SelectListItem() { Text = "Salsa", Value = "SAL" });
            listNomeCom.Add(new SelectListItem() { Text = "Couve", Value = "COU" });
            listNomeCom.Add(new SelectListItem() { Text = "Espinafre", Value = "ESP" });
            listNomeCom.Add(new SelectListItem() { Text = "Rabanete", Value = "RAB" });
            listNomeCom.Add(new SelectListItem() { Text = "Agrião", Value = "AGR" });
            listNomeCom.Add(new SelectListItem() { Text = "Mostarda", Value = "MOS" });
            listNomeCom.Add(new SelectListItem() { Text = "Cenoura", Value = "CEN" });
            listNomeCom.Add(new SelectListItem() { Text = "Beterraba", Value = "BET" });
            listNomeCom.Add(new SelectListItem() { Text = "Nabo", Value = "NAB" });
            listNomeCom.Add(new SelectListItem() { Text = "Chicória", Value = "CHI" });
            listNomeCom.Add(new SelectListItem() { Text = "Selecione uma opção", Value = "", Selected = true });

            ViewBag.listNomeCom = listNomeCom;



            return View(planta);
        }

        // POST: Planta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Planta planta)
        {
            try
            {
                // TODO: Add update logic here
                var plantas = Session["Planta"] as List<Planta>;
                var existingPlanta = plantas.ElementAt(id);

                existingPlanta.NomeComum = planta.NomeComum;
                existingPlanta.NomeCientifico = planta.NomeCientifico;
                existingPlanta.TemperaturaRec = planta.TemperaturaRec;
                existingPlanta.UmidadeRec = planta.UmidadeRec;
                existingPlanta.LuminosidadeRec = planta.LuminosidadeRec;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Planta/Delete/5
        public ActionResult Delete(int id)
        {
            IniciarLista();
            return View((Session["Planta"] as List<Planta>).ElementAt(id));
        }

        // POST: Planta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                IniciarLista();
                var list = Session["Planta"] as List<Planta>;
                list.RemoveAt(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
