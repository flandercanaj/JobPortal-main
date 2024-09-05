using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace backend.Models;

public class PremiumPlan
{
    [Key]
    public int PremiumId { get; set; }
    
    public float? MonthlyAmount { get; set; }
    
    public float? YearlyAmount { get; set; }
    
    [ForeignKey("PaymentId")]
    public int PaymentId { get; }
    
    public Payment Payment { get; set; }
}