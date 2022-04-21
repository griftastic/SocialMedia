using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Data.Entities
{
    public class ReplyEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
    }
}