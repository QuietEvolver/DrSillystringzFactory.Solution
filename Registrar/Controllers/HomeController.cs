using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
  public class HomeController : Controller
  {
    private readonly RegistrarContext _db;

    public HomeController(RegistrarContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Course[] courses = _db.Courses.ToArray();
      Student[] students = _db.Students.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("courses", courses);
      model.Add("students", students);
      return View();
    }
  }
}