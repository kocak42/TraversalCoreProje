using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate;

public class FirstFeature :IEntity
{
    [Key]
    public int FirstFeatureId { get; set; }
    public string FeatureName{ get; set; }
    public string FirstFeatureDescription { get; set; }
    public string FirstFeatureImage { get; set; }
    public bool FirstFeatureStatus { get; set; }

}
