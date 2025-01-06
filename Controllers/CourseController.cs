using _1_Asp.Net_MVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace _1_Asp.Net_MVC.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {     
            return View();
        }
        public IActionResult Details(int? id)
        {
            if(id==null)
            {             
                return RedirectToAction("List","Course");
            }
            var kurs=Repository.GetById(id);
            return View(kurs);
        }

        public IActionResult List()
        {            
            return View("CourseList", Repository.Courses);
        }
    }
}