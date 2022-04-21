using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Microsoft.AspNetCore.Identity;

namespace SocialMedia.Data.Entities
{
    public class Comments
    {
        [Required]
       public int PostId {get; set;} 
       [Required]
       public int OwnerId {get; set;}
       [Required]
       public Comment Comment {get; set;}
       [Required]
       public DateTimeOffset CreatedUtc {get; set}
       
    }
}