using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate;

public class Destination:IEntity
{
    [Key]
    public int DestinationId  { get; set; }
    public string City  { get; set; }
    public string DayNight { get; set; }
    public double Price { get; set; }
    public string Image { get; set; }
    public string DastinationDescription { get; set; }
    public int Capacity  { get; set; }
    public bool DastinationStatus  { get; set; }
    public string CoverImage  { get; set; }
    public string Details1 { get; set; }
    public string Details2 { get; set; }
    public string Image2 { get; set; }
    public List<Comment> Comments { get; set; }



}
