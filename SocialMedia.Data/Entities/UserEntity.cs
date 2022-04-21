using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Microsoft.AspNetCore.Identity;


namespace SocialMedia.Data.Entities
{
    public class UserEntity
    {
        [Key]
       public int Id { get; set;} 
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
    var entity = new UserEntity
    {
        Email = model.Email,
        Username = model.Username,git
        DateCreated = DateTime.Now
    };
    var passwordHasher = new PasswordHasher<UserEntity.();
    entity.Password = passwordHasher.HashPassword(entity, model.Password);
}