using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public string UserId { get; set; }

        [ForeignKey("EducationId")]
        public int? EducationId { get; set; }
        
        [ForeignKey("ExperienceId")]
        public int? ExperienceId { get; set; }
        public User User { get; set; }
        
        // public Education Education { get; set; }
        // public Experience Experience { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
    }
}