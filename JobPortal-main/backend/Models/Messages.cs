using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    

namespace backend.Models;

public class Messages
{
    [Key]
    public int MessageId { get; set; }

    [StringLength(500)]
        
    public string Description { get; set; }
    
    [StringLength(30)]
    [Required]
    public string Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Delivered { get; set; } = DateTime.UtcNow;
    
    [ForeignKey("UserId")] 
     public string UserId { get; }
     
     public User User { get; set; }
     
} 