using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DI.Data.Models;
using DI.Data;
using DI.Services;

namespace DI.Controllers
{
    public class SchoolsController : Controller
    {
        private readonly SchoolService _service;

        public SchoolsController(SchoolService service)
        {
            _service = service;
        }

        // GET: Schools
        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        // GET: Schools/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            School school = _service.GetById(id.Value);
            if (school == null)
                return HttpNotFound();
                        
            return View(school);
        }

        // GET: Schools/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Schools/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] School school)
        {
            if (ModelState.IsValid)
            {
                _service.Add(school);
                return RedirectToAction("Index", "Home");
            }

            return View(school);
        }

        // GET: Schools/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            School school = _service.GetById(id.Value);
            if (school == null)
                return HttpNotFound();
            
            return View(school);
        }

        // POST: Schools/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] School school)
        {
            if (ModelState.IsValid)
            {
                _service.Update(school);
                return RedirectToAction("Index", "Home");
            }

            return View(school);
        }

        // GET: Schools/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            School school = _service.GetById(id.Value);
            if (school == null)
                return HttpNotFound();
            
            return View(school);
        }

        // POST: Schools/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
