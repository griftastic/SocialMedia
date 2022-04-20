using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Data.Entities
{
    public class UserEntity
    {
        [Key]
       public Int Id { get; set;} 
       [Required]
       public string Email {get; set;}
       [Required]
       public string Username {get; set;}
       [Required]
       public string Password {get; set;}
       
       public string FirstName {get; set;}
       public string LastName {get; set;}
       [Required]
       public DateTime DateCreated {get; set;}
    }
}