using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Registrar.Models
{
  public class Student 
  {
    public int StudentId { get; set; }
    // [Required(ErrorMessage = "The item's description cannot be empty.")]
    [Required]
    public string StudentName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    // [Range(1, int.MaxValue, ErrorMessage = "You must add your student to a course. Have you created a course yet?")]
    // public int CourseId { get; set; }
    // public Course Course {get; set; }
    public List<CourseStudent> JoinEntities { get;}
  }
}