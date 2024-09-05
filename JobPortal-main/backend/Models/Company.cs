using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
namespace backend.Models;

public class Company
{
    [Key]
    public int CompanyId { get; set; }
    
    [StringLength(20)]
    [Required]
    public string CompanyName { get; set; }
    
    [StringLength(20)]
    [Required]
    public string Industry { get; set; }
    
    
    [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid e-mail format")]
    [Required]
    public string ConctactEmail { get; set; }
    
    [RegularExpression(@"^www\.[a-zA-Z0-9\-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid website format.")]
    public string? Website { get; set; }
    
    public ICollection<JobListing> JobListing { get; set; }
}