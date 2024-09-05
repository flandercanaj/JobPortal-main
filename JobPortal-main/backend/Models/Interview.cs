using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace backend.Models;

public class Interview
{
    [Key] public int InterviewId { get; set; }

    [ForeignKey("UserId")] public string UserId { get; set; }

    [ForeignKey("ApplicationId")]
    public int ApplicationId { get; }
    
    
    public User User { get; set; }
    public JobApplication  JobApplication { get; set;}




}