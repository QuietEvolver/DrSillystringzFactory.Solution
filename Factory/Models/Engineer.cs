using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer 
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The item's description cannot be empty.")]
    // [Required]
    public string EngineerName { get; set; }
    public DateTime HireDate { get; set; }
    public List<EngineerMachine> JoinEntities { get;}
  }
}