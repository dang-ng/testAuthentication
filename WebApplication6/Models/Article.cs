using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models;

public class Article
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime PublishDate { get; set; }

    public string Content {set; get;}
}