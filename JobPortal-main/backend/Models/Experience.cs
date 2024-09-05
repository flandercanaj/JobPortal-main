using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Experience
    {
        [Key]  
        public int ExperienceId { get; set; }

        [ForeignKey("User")]  
        public int UserId { get; set; }

        [Required]
        [StringLength(100)] 
        public string CompanyName { get; set; }

        [Required]
        [StringLength(100)]  
        public string JobTitle { get; set; }

        [Required]
        [StringLength(100)]  
        public string Location { get; set; }

        [Required]
        [StringLength(500)]  
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }  

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }  

        
        public virtual User User { get; set; }
    }
}
 