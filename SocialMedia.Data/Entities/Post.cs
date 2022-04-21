namespace SocialMedia.Data.Entities
{
    public class Post
    {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Text { get; set; }
    [Required]
    public virtual List<Comment> Comment {get; set;}
    [Required]
    public Guid AuthorId { get; set; }
    }
}