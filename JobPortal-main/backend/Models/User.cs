using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
namespace backend.Models;

public class User : IdentityUser
{
    [Required]
    [StringLength(20, ErrorMessage = "The name should be less than 20 characters.")]
    public string Name { get; set; }

    [Required]
    [StringLength(10, ErrorMessage = "The name should be less than 10 characters.")]
    public string Surname { get; set; }
    
    [StringLength(20, ErrorMessage = "The address should be less than 20 characters.")]
    public string? Address { get; set; }
    
    
    [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid e-mail format")]
    public new string Email { get; set; }
    
    //This is Age attribute updated to BirthDate so it can show youre date, month, year of birth instead of youre age
    public DateTime? Birthdate { get; set; } 
    
    public string? Gender { get; set; }
    
    [RegularExpression(@"^\+?\d{1,3}[- ]?\d{3,14}$", ErrorMessage = "Invalid phone number format")]
    public string? PhoneNumber { get; set; }
    
    public ICollection<Payment> Payment { get; set; }
    public ICollection<Messages> Messages { get; set; }
    public ICollection<Connections> Connections { get; set; }
    public ICollection<JobApplication> JobApplication { get; set; }
    public ICollection<Resume> Resume { get; set; }
    public ICollection<Interview> Interview { get; set; }
//
    public ICollection<Calendar> Calendar { get; set; }
    public ICollection<Certificate> Certificate { get; set; }
    public ICollection<Event> Event { get; set; }
    public ICollection<Skill> Skill { get; set; }
}