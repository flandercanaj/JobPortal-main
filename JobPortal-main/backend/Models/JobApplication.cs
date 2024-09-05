using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models;

public class JobApplication
{
    [Key]
    public int JobApplicationId { get; set; }

    public string Status { get; set; }

    [Required]
    public DateTime ApplicationDate { get; set; }

    [Required]
    [ForeignKey("JobId")]
    public int JobId { get; }
    

    [Required] [ForeignKey("UserId")] 
    public string UserId { get; }
    
    public User User { get; set; }
    public JobListing JobListing { get; set; }
    
    public ICollection<Interview> Interview { get; set; }
    public ICollection<Resume> Resume { get; set; }
    
    
}