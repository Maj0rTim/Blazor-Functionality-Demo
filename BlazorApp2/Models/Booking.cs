using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
    [Table("Booking", Schema = "dbo")]
    public class Booking
    {
        [Key] 
        public int BookingID { get; set; }

        [Required]
        public Book Book { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        [Required]
        public DateOnly Date {  get; set; }

        [Required]
        public TimeOnly Duration { get; set; }
    }
}
