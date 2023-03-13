using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
  public class CoursesController : Controller
  {
    private readonly RegistrarContext _db;
    public CoursesController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Course> model = _db.Courses.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Course course)
    {
      _db.Courses.Add(course);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Course thisCourse = _db.Courses
                              .Include(courses => courses.Students)
                              .FirstOrDefault(courses => courses.CourseId == id);
      return View(thisCourse);
    }

  //   public ActionResult Details(int id)
  // {
  //   Course thisCourse = _db.Courses.Include(course => course.Students)
  //   .ThenInclude(student => student.JoinEntities)
  //   .FirstOrDefault(course => course.CourseId == id);
  // }






  }
}