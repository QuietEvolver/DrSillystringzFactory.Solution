using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

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
      List<Course> model = _db.Courses.Include(course => course.Student).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
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
                              .Include(crs => crs.JoinEntities) 
                              .ThenInclude(join => join.Student)
                              .FirstOrDefault(courses => courses.CourseId == id);// IFF:1to1=.Include(cat => cat.Items)
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