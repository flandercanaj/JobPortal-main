using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models;

public class Resume
{
    [Key]
    public int ResumeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }
    
    public string File { get; set; }

    [ForeignKey("UserId")]
    public string UserId { get; }
    
    
    [ForeignKey("ApplicationId")]
    public int ApplicationId { get;}
    
    public User User { get; set; }
    public JobApplication JobApplication { get; set; }
}