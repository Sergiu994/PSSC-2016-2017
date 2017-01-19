using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityWebApplication.Repository;

namespace UniversityWebApplication.Controllers
{
    public class OptionaleController : Controller
    {
        private SubjectsRepository _subjectRepository;
        // GET: Optionale
        public ActionResult List()
        {
            _subjectRepository = new SubjectsRepository();
            var optionale = _subjectRepository._subjectsContext.proc_materii().ToList();
            ViewBag.userdetails = optionale;
            return View();
        }

        // GET: Optionale/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Optionale/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Optionale/Create
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

        // GET: Optionale/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Optionale/Edit/5
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

        // GET: Optionale/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Optionale/Delete/5
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
