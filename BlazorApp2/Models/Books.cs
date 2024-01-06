using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
    [Table("Book", Schema = "dbo")]
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [Required]
        [StringLength(50)]
        public string Rating { get; set; }

        [Required]
        [StringLength(50)]
        public string Number_pages { get; set; }

        [Required]
        [StringLength(50)]
        public string Rating_count { get; set; }

        [Required]
        [StringLength(50)]
        public string Publication_date { get; set; }

        [Required]
        [StringLength(50)]
        public string Publisher { get; set; }


        
    }
}
