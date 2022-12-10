using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessCRM.Models;

namespace ChessCRM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private AcademyContext Context { get; set; }
        public HomeController(AcademyContext ctx) => Context = ctx;

        public ViewResult AcademyHome()
        {   // Initial view after login. Displays the products starting in the current month, and options to view different reports
            var model = new AcademyViewModel();

            IQueryable<Product> query = Context.Products; // Get all products
            IQueryable<Product> queryCurrent = Context.Products; // Get all products starting in the current month
            queryCurrent = queryCurrent.Where(d => d.StartDateTime.Month == DateTime.Today.Month);

            model.AllProducts = query.ToList();
            model.CurrentProducts = queryCurrent.ToList(); // Add the current products to the view model

            return View(model); 
        }

        public ViewResult GetCurrentEnrollment(string input)
        {
            var model = new EnrollmentViewModel(); // create an enrollment viewmodel

            int prodID = Convert.ToInt32(input);

            model.Product = Context.Products.Find(prodID); // get the product to find current enrollment for

            
            IQueryable<Registration> queryR = Context.Registrations; // find the current enrollment
            queryR = queryR.Where(r => r.ProductID == prodID);

            model.Registrations = queryR.ToList(); // assign the current enrollment to the viewmodel

            IQueryable<Student> queryS = Context.Students;
            
            foreach (Registration r in model.Registrations)
            {
                Student s = Context.Students.Find(r.StudentID);
                model.Students.Add(s);
            }

            return View(model);
        }

        public ViewResult StudentList()
        {
            var model = new StudentListViewModel();

            foreach (var s in Context.Students)
            {
                model.SortedAll.AddLast(s);
            }

            model.SortedAll.AlphabetizeByLname();
            model.SortedActive = model.SortedAll.GetCurrent();

            return View(model);
        }

        public ViewResult EvaluateClass(string input)
        {
            var model = new EvaluateClassViewModel();

            int prodID = Convert.ToInt32(input);
            model.Product = Context.Products.Find(prodID);

            IQueryable<Registration> queryR = Context.Registrations; // find the current enrollment
            queryR = queryR.Where(r => r.ProductID == prodID);

            List<Registration> rList = new List<Registration>();
            rList = queryR.ToList();

            IQueryable<Student> queryS = Context.Students;

            foreach (Registration r in rList)
            {
                Student s = Context.Students.Find(r.StudentID);
                model.Enqueue(s);
            }
            //TempData["prodID"] = model.Product.ProductID.ToString();
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateSkill(string sID)
        {
            int ID = Convert.ToInt32(sID);
            var student = Context.Students.Find(ID);

            return View(student);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Student student)
        {
            if (ModelState.IsValid)
            {
                Context.Students.Update(student);
                Context.SaveChanges();
                return RedirectToAction("AcademyHome");
            }

            else
            {
                return View(student);
            }
        }

        /*public ActionResult BeginEval()
        {

        }

       // [HttpPost]
       // public ViewResult NextStudent()
        {

        }

        [HttpGet]
        public ViewResult NextStudent(Student s)
        {

        }*/
    }
}
