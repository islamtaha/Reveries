using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reveries.Models;
using System.ComponentModel.DataAnnotations;

namespace Reveries.ViewModels
{
    public class UserLogin
    {
        [Required]
        public string username { get; set; }
        [Required, DataType(DataType.Password)]
        public string password { get; set; }
    }
}