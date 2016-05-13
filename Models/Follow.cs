using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Reveries.Models
{
    [Table("Follows")]
    public class Follow
    {
        public int Id { get; set; }
        public int FollowerId { get; set; }
        public int FollowedId { get; set; }

        [ForeignKey("FollowerId")]
        [InverseProperty("Follower")]
        public virtual User Follower { get; set; }

        [ForeignKey("FollowedId")]
        [InverseProperty("Followed")]
        public virtual User Followed { get; set; }

    }
}