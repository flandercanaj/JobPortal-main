using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace backend.Models;

public class Payment
{
    [Key]
    public int PaymentId { get; set; }
    
    [Required]
    public string PaymentType { get; set; }
    
    [Required]
    public float Amount { get; set; }
    
    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; } = DateTime.UtcNow;
    
    [ForeignKey("UserId")]
    public string UserId { get; }
    
    public User User { get; set; }
    
    // Single instance for one-to-one relationship
    public PremiumPlan PremiumPlan { get; set; }
}