using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Reveries.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string About { get; set; }
        public string Gender { get; set; }
        public string ProfilePic { get; set; }
        public string CoverPic { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }


        public virtual void SetPassword(string Password)
        {
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(Password, 13);
        }
        public static void FakeHash()
        {
            BCrypt.Net.BCrypt.HashPassword("", 13);
        }
        public virtual bool CheckPassword(string Password)
        {
            return BCrypt.Net.BCrypt.Verify(Password, PasswordHash);
        }

        public virtual List<Reverie> Reveries { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Like> Likes { get; set; }
        public virtual List<Follow> Follower { get; set; }
        public virtual List<Follow> Followed { get; set; }

    }
}