using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
using System;

namespace Registrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    // [Required]
    public string CourseName {get; set; }

    public string CourseNumber { get; set; }

    public List<Student> Students { get; set; }

    public List<CourseStudent> JoinEntities { get;}

  }
}