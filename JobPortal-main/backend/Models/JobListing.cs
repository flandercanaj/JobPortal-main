using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace backend.Models;

public class JobListing
{
    [Key]
    public int JobId { get; set; }
    
    [StringLength(20)]
    [Required]
    public string Title { get; set; }
    
    [StringLength(20)]
    [Required]
    public string JobType { get; set; }
    
    [StringLength(500)]
    [Required]
    public string Description { get; set; }
    
    [StringLength(20)]
    [Required]
    public string Location { get; set; }
    
    [Column(TypeName = "datetime")]
    public DateTime PostDate { get; set; } = DateTime.UtcNow;
    
    [ForeignKey("CompanyId")]
    public int CompanyId { get; }
    
    // Navigation property for related Company
    public Company Company { get; set; }
    
    public ICollection<JobApplication> JobApplication{ get; set; }
}