using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate;

public class Contact :IEntity
{
    [Key]
    public int ContactId { get; set; }
    public string ContactDescription { get; set; }
    public string ContactMail { get; set; }
    public string Adress  { get; set; }
    public string Phone { get; set; }
    public string MapLocation { get; set; }
    public bool ContactStatus { get; set; }


}
