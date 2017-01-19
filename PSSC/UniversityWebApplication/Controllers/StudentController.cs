using System;
using System.Collections;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Database;
using Models.Generics;
using UniversityWebApplication.Repository;

namespace UniversityWebApplication.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository _studentRepository;

        public StudentController()
        {
            
        }
        // GET: Student
        public ActionResult List()
        {
            _studentRepository = new StudentRepository();
            ViewBag.userdetails = _studentRepository.List;
            return View();
        }

        
        [HttpGet]
        public ActionResult Add()
        {
            //var student = new Models.Student.Student(new PlainText("Gica"), new Credits(40), new RegistrationNumber(new Guid(//).ToString()));
            return View("Add");
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
      
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {
            var stud = new ArrayList();
            try
            {
               foreach(var elem in collection.AllKeys.Skip(1))
                {
                    stud.Add(collection[elem]);
                }

                var student = new Models.Student.Student(new PlainText(stud[0].ToString()), new Credits(Convert.ToInt32(stud[1])) , new RegistrationNumber(stud[2].ToString()) );
                //string nume= check_student.Name.Text;
                //int credits = check_student.Credits.Count;
                //string regNumber = check_student.RegNumber.Number;
                //var student = new Models.Student.Student(nume, credits, regNumber); 

                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Models.Student.Student, Database.Studentt>();
                });


                var convertedStudent = Mapper.Map<Models.Student.Student, Database.Studentt>(student);
                var studentRepository = new StudentRepository();
                studentRepository.Add(convertedStudent);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return null;
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
