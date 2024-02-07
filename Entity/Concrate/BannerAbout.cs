using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate;

public class BannerAbout:IEntity
{
    [Key]
    public int BannerAboutId { get; set; }
    public string BannerAboutTitle { get; set; }
    public string BannerAboutDescription { get; set; }
}
