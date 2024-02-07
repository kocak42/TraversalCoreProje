using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate;

public class Employee:IEntity
{
    [Key]
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string EmployeDescription { get; set; }
    public string TwitterUrl { get; set; }
    public string InstagramUrl { get; set; }
    public bool EmployeeStatus { get; set; }
}
