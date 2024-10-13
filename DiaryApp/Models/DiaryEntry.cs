using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength =3, ErrorMessage ="Title should be between 3 and 100 chracters")]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
