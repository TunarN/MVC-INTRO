using Microsoft.AspNetCore.Mvc;
using P326FirstWebApp.Models;
using P326FirstWebApp.ViewModels;
using System.Collections.Generic;

namespace P326FirstWebApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{

			ViewData["Name"] = "Ismayil";
			ViewBag.Surname = GetStudents();
            TempData["Age"] = 20;


			//HomeVM homeVM = new HomeVM();
			//homeVM.Students = GetStudents();
   //         homeVM.Groups = GetGroups();
            return RedirectToAction("About");
            //return View();
		}

		public IActionResult About()
		{
			return View();
		}

		private List<Student> GetStudents()
		{
			List<Student> student = new List<Student>();
			student.Add(new Student() { Id = 1, Name = "Stu1" , Surname="Sur1"});
			student.Add(new Student() { Id = 2, Name = "Stu2", Surname = "Sur2" });
			student.Add(new Student() { Id = 3, Name = "Stu3", Surname = "Sur3" });
				return student;
		}

        private List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();
            groups.Add(new Group() { Id = 1, Name = "Group1" });
            groups.Add(new Group() { Id = 2, Name = "Group2" });
            groups.Add(new Group() { Id = 3, Name = "Group3"});
			return groups;
        }
    }
}
