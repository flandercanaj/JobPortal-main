using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Reminder
    {
        [Key]
        public int ReminderId { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ReminderTime { get; set; }

        [Required]
        [StringLength(500)]
        public string ReminderDetails { get; set; }

        [Required]
        public string Status { get; set; }

        [ForeignKey("EventId")]
        public int EventId { get; set; }

        public Event Event { get; set; }
    }
}