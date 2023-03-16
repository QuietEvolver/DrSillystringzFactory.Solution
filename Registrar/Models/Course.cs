using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Registrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    [Required(ErrorMessage = "The name cannot be empty.")]
    public string CourseName {get; set; }

    public string CourseNumber { get; set; }
    // [Range(1, int.MaxValue, ErrorMessage = "You must add your course to a student. Have you created a student yet?")]
    // public int StudentId { get; set; }
    // public Student Student { get; set; }

    // public List<Student> Students { get; set; }
    public List<CourseStudent> JoinEntities { get;}

  }
}