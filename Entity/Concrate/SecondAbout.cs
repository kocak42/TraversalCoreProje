using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate;

public class SecondAbout :IEntity
{
    [Key]
    public int SecondAboutId { get; set; }
    public string SecondAboutTitle1 { get; set; }
    public string SecondAboutTitle2 { get; set; }
    public string SecondAboutdescription { get; set; }
    public string Image { get; set; }
}
