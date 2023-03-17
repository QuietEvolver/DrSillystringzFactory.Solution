using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The name cannot be empty.")]
    public string MachineName {get; set; }

    public string MachineNumber { get; set; }
    public List<EngineerMachine> JoinEntities { get;}

  }
}