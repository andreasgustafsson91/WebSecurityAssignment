using System.ComponentModel.DataAnnotations;

namespace WebSecurityAssignment.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

    }
}
