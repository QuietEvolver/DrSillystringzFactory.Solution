using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Registrar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly RegistrarContext _db;

    public StudentsController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    { 
      List<Student> model = _db.Students.ToList(); // Include(student => student.Course)
      return View(model);

    }

    public ActionResult Create()
    {
      return View();
    }
        
    [HttpPost]
    public ActionResult Create(Student student, int courseId) // , int courseId)//
    {   
        _db.Students.Add(student);
        _db.SaveChanges();
        #nullable enable
        CourseStudent? joinEntity = _db.CourseStudents.FirstOrDefault(join => (join.CourseId == courseId && join.StudentId == student.StudentId));
        #nullable disable
        if (joinEntity == null && courseId != 0)
        {
          _db.CourseStudents.Add(new CourseStudent() { CourseId = courseId, StudentId = student.StudentId });
          _db.SaveChanges();
        }
        return RedirectToAction("Index");
      //   _db.Students.Add(student);// (new CourseStudent() { CourseId = courseId, StudentId = student.StudentId });
      //   _db.SaveChanges();
      // return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Student thisStudent = _db.Students
                          .Include(student => student.JoinEntities)
                          .ThenInclude(join => join.Course)
                          .FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }


    public ActionResult AddCourse(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult AddCourse(Student student, int courseId)
    {
      #nullable enable
      CourseStudent? joinEntity = _db.CourseStudents.FirstOrDefault(join => (join.CourseId == courseId && join.StudentId == student.StudentId));
      #nullable disable
      if (joinEntity == null && courseId != 0)
      {
        _db.CourseStudents.Add(new CourseStudent() { CourseId = courseId, StudentId = student.StudentId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = student.StudentId });
    }

    public ActionResult Edit(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      // ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult Edit(Student student)
    {
      _db.Students.Update(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id); 
      return View(thisStudent);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      _db.Students.Remove(thisStudent);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
      CourseStudent joinEntry = _db.CourseStudents.FirstOrDefault(entry => entry.CourseStudentId == joinId);
      _db.CourseStudents.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
