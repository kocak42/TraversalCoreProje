using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate;

public class SecondFeature :IEntity
{
    [Key]
    public int SecondFeatureId { get; set; }
    public string SecondFeatureTitle { get; set; }
    public string SecondFeatureDescription { get; set; }
    public string SecondFeatureImage { get; set; }
    public bool SecondFeatureStatus { get; set; }
}
