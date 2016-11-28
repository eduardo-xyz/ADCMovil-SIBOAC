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
    public class Circulacions1Controller : Controller
    {
        private PC_HH_AndroidEntities db = new PC_HH_AndroidEntities();

        // GET: Circulacions1
        public ActionResult Index()
        {
            return View(db.CIRCULACION.ToList());
        }

        // GET: Circulacions1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Circulacion circulacion = db.CIRCULACION.Find(id);
            if (circulacion == null)
            {
                return HttpNotFound();
            }
            return View(circulacion);
        }

        // GET: Circulacions1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Circulacions1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descripcion,Estado,FechaDeInicio,FechaDeFin")] Circulacion circulacion)
        {
            if (ModelState.IsValid)
            {
                db.CIRCULACION.Add(circulacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(circulacion);
        }

        // GET: Circulacions1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Circulacion circulacion = db.CIRCULACION.Find(id);
            if (circulacion == null)
            {
                return HttpNotFound();
            }
            return View(circulacion);
        }

        // POST: Circulacions1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descripcion,Estado,FechaDeInicio,FechaDeFin")] Circulacion circulacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(circulacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(circulacion);
        }

        // GET: Circulacions1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Circulacion circulacion = db.CIRCULACION.Find(id);
            if (circulacion == null)
            {
                return HttpNotFound();
            }
            return View(circulacion);
        }

        // POST: Circulacions1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Circulacion circulacion = db.CIRCULACION.Find(id);
            db.CIRCULACION.Remove(circulacion);
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