using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Role
    {
        [Key]  
        public int RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleType { get; set; }

        
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
 