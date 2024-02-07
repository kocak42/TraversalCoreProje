using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class Comment:IEntity
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommenContet { get; set; }
        public bool CommenState { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
