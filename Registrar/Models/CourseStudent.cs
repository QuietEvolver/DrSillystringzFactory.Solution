using System.Collections.Generic;

namespace Registrar.Models
{
  public class CourseStudent {
    public int CourseStudentId { get; set; }
  
    public int CourseId {get; set; }
    public Course Course {get; set; }
    public int StudentId {get; set; }
    public Student Student {get; set; }
  }
}