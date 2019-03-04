using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LarsenNToubro.Models
{
    [Table("Login_Page")]
    public class Login_Page
    {
       
        [Key]
        [Required(ErrorMessage = "UserName is required")]
        public String Username {get;set;}

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}