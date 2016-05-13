using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Reveries.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public int ReverieId { get; set; }


        public virtual User User { get; set; }
  
        public virtual Reverie Reverie { get; set; }
    }
}