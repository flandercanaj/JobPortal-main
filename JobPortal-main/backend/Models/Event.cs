using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime StartDateTime { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? EndDateTime { get; set; }

        [ForeignKey("CalendarId")]
        public int CalendarId { get; set; }

        public Calendar Calendar { get; set; }

        public ICollection<Reminder> Reminders { get; set; }//added later
    }
}
