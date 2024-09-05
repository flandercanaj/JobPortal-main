using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Permission
    {
        [Key]  
        public int Permission_ID { get; set; }

        [ForeignKey("Role")]  
        public int Role_ID { get; set; }

        [Required]
        [StringLength(50)]  
        public string PermissionType { get; set; }

        
        public virtual Role Role { get; set; }
    }
}
