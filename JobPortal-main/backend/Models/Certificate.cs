using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Certificate
    {
        [Key]
        public int CertificateId { get; set; }
        
        [StringLength(50)]
        [Required]
        public string CertificationName { get; set; }
        
        [StringLength(50)]
        [Required]
        public string TitleAwarded { get; set; }
        
        [StringLength(50)]
        public string Organization { get; set; }
        
        [Required]
        public DateTime IssueDate { get; set; }
        
        public DateTime? ExpirationDate { get; set; }
        
        [Required]
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        
        [Required]
        [ForeignKey("SkillId")]
        public int SkillId { get; set; }
        public User User { get; set; }
        public Skill Skill { get; set; }
    }
}