using ContosoUniversity.DAL;
using ContosoUniversity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class StudentCourseGradeCreditController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: StudentCourseGradeCredit
        public ActionResult Index()
        {
            IList<StudentCourseGradeCredit> viewTable = new List<StudentCourseGradeCredit>();           
            var enrollments = db.Enrollments.OrderBy(x => x.Course.Title);
            foreach (var e in enrollments)
            {
                StudentCourseGradeCredit temp = new StudentCourseGradeCredit();
                temp.StudentName = e.Student.FullName;
                temp.CourseTitle = e.Course.Title;
                temp.DepartmentName = e.Course.Department.Name;
                temp.CourseCredit = e.Course.Credits;                
                temp.EnrollementGrade = (Grade?)e.Grade;
                viewTable.Add(temp);
            }
            return View(viewTable);
        }

        // GET: StudentCourseGradeCredit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentCourseGradeCredit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentCourseGradeCredit/Create
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

        // GET: StudentCourseGradeCredit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentCourseGradeCredit/Edit/5
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

        // GET: StudentCourseGradeCredit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentCourseGradeCredit/Delete/5
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
