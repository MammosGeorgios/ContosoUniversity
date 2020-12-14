using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class CourseDepartmentController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: CourseDepartment
        public ActionResult Index(int? id)
        {
            IList<CourseDepartment> viewModel = new List<CourseDepartment>();            
            var departments = db.Departments;
            foreach (var dep in departments)
            {
                CourseDepartment temp = new CourseDepartment();
                temp.Department = dep;
                temp.Courses = new List<Course>();
                foreach (var course in dep.Courses)
                {
                    temp.Courses.Add(course);
                }
                viewModel.Add(temp);
            }
            return View(viewModel);            
        }

        // GET: CourseDepartment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseDepartment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseDepartment/Create
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

        // GET: CourseDepartment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseDepartment/Edit/5
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

        // GET: CourseDepartment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseDepartment/Delete/5
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
