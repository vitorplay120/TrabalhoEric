using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_mvc3.Models;

namespace CRUD_mvc3.Controllers
{
    public class equipamentosController : Controller
    {
        private contexto db = new contexto();

        // GET: equipamentos
        public ActionResult Index()
        {
            return View(db.Equipamentos.ToList());
        }

        // GET: equipamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipamentos equipamentos = db.Equipamentos.Find(id);
            if (equipamentos == null)
            {
                return HttpNotFound();
            }
            return View(equipamentos);
        }

        // GET: equipamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: equipamentos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cnpj")] equipamentos equipamentos)
        {
            if (ModelState.IsValid)
            {
                db.Equipamentos.Add(equipamentos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipamentos);
        }

        // GET: equipamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipamentos equipamentos = db.Equipamentos.Find(id);
            if (equipamentos == null)
            {
                return HttpNotFound();
            }
            return View(equipamentos);
        }

        // POST: equipamentos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "equipamentosId,tipo,cnpj,equipamento")] equipamentos equipamentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipamentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipamentos);
        }

        // GET: equipamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipamentos equipamentos = db.Equipamentos.Find(id);
            if (equipamentos == null)
            {
                return HttpNotFound();
            }
            return View(equipamentos);
        }

        // POST: equipamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            equipamentos equipamentos = db.Equipamentos.Find(id);
            db.Equipamentos.Remove(equipamentos);
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
