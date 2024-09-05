using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    

namespace backend.Models;

public class Connections
{
    [Key]
    public int ConnectionId { get; set; }

    [StringLength(20)] 
    [Required]
    public string Status { get; set; }

    [Required] public DateTime ConnectionDate { get; set; } = DateTime.Now;

    [ForeignKey("UserId")]
    public string UserId { get; }

    public User User { get; set; }


}