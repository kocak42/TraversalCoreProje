using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate;

public class FirstAbout:IEntity
{
    [Key]
    public int AboutId { get; set; }
    public string FirstAboutTitle { get; set; }
    public string FirstAboutDescription { get; set; }
    public string FirstOtherTitle { get; set; }
    public string FirstAboutImage { get; set; }
    public bool FirstAboutStatus { get; set; }
}
