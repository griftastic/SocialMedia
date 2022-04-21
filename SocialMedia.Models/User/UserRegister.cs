using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models.User
{
    public class UserRegister
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(4)]
        public string Username { get; set; }
        [Required]
        [MinLength(4)]
        public string Password { get; set; }
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
    public class UserDetail
    {
        public int Id{get; set;}
        public string Username { get; set; }
        public string Email { get; set; }   
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}