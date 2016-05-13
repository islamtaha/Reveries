using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Reveries.Models;

namespace Reveries.ViewModels
{
    public class UserEditProfile
    {
        public string about { get; set; }
        [Required]
        public string pass { get; set; }
        public string confirmpass { get; set; }
        public string oldpass { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        public string name { get; set; }

        public User user { get; set; }
    }
}