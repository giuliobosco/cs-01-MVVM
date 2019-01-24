﻿using _400_Videogiochi.DA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _400_Videogiochi.DA.Model;

namespace _400_VideoGioco.MVC.Controllers
{
    public class TipiController : Controller {

        private VideoGiochiContext ctx;

        public TipiController() {
            ctx = new VideoGiochiContext();
        }
        // GET: Tipi
        public ActionResult Index()
        {
            var tipi = from t in ctx.Tipi
                orderby t.Nome
                select t;

            return View(tipi);
        }

        // GET: Tipi/Details/5
        public ActionResult Details(int id) {
            var dati = from t in ctx.Tipi
                where t.Id == id
                select t;

            return View(dati.FirstOrDefault());
        }

        // GET: Tipi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipi/Create
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

        // GET: Tipi/Edit/5
        public ActionResult Edit(int id)
        {
            var dati = from t in ctx.Tipi
                where t.Id == id
                select t;

            return View(dati.FirstOrDefault());
        }

        // POST: Tipi/Edit/5
        [HttpPost]
        public ActionResult Edit(Tipo tipo)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid) {
                    ctx.Entry(tipo).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(tipo);
            }
            catch
            {
                return View();
            }
        }

        // GET: Tipi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tipi/Delete/5
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
