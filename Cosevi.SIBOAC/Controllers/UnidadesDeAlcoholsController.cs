﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cosevi.SIBOAC.Models;

namespace Cosevi.SIBOAC.Controllers
{
    public class UnidadesDeAlcoholsController : Controller
    {
        private PC_HH_AndroidEntities db = new PC_HH_AndroidEntities();

        // GET: UnidadesDeAlcohols
        public ActionResult Index()
        {
            return View(db.UNIDADES_ALCOHOL.ToList());
        }

        // GET: UnidadesDeAlcohols/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidadesDeAlcohol unidadesDeAlcohol = db.UNIDADES_ALCOHOL.Find(id);
            if (unidadesDeAlcohol == null)
            {
                return HttpNotFound();
            }
            return View(unidadesDeAlcohol);
        }

        // GET: UnidadesDeAlcohols/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnidadesDeAlcohols/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Estado,FechaDeInicio,FechaDeFin")] UnidadesDeAlcohol unidadesDeAlcohol)
        {
            if (ModelState.IsValid)
            {
                db.UNIDADES_ALCOHOL.Add(unidadesDeAlcohol);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unidadesDeAlcohol);
        }

        // GET: UnidadesDeAlcohols/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidadesDeAlcohol unidadesDeAlcohol = db.UNIDADES_ALCOHOL.Find(id);
            if (unidadesDeAlcohol == null)
            {
                return HttpNotFound();
            }
            return View(unidadesDeAlcohol);
        }

        // POST: UnidadesDeAlcohols/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Estado,FechaDeInicio,FechaDeFin")] UnidadesDeAlcohol unidadesDeAlcohol)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unidadesDeAlcohol).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unidadesDeAlcohol);
        }

        // GET: UnidadesDeAlcohols/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidadesDeAlcohol unidadesDeAlcohol = db.UNIDADES_ALCOHOL.Find(id);
            if (unidadesDeAlcohol == null)
            {
                return HttpNotFound();
            }
            return View(unidadesDeAlcohol);
        }

        // POST: UnidadesDeAlcohols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            UnidadesDeAlcohol unidadesDeAlcohol = db.UNIDADES_ALCOHOL.Find(id);
            db.UNIDADES_ALCOHOL.Remove(unidadesDeAlcohol);
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