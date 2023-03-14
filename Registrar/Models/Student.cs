using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
using System;

namespace Registrar.Models
{
  public class Student 
  {
    public int StudentId { get; set; }
    //   [Required]
    public string StudentName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    //     [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category. Have you created a category yet?")]
    public int CourseId { get; set; }
    public Course Course {get; set; }
    //public List<ItemTag> JoinEntities { get;}
    public List<CourseStudent> JoinEntities { get;}
  }
}