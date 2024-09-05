using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Education
    {
        [Key]  
        public int EducationId { get; set; }

        [ForeignKey("User")]  
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]  
        public string InstituteName { get; set; }

        [Required]
        [StringLength(100)]  
        public string FieldOfStudy { get; set; }

        [Required]
        [StringLength(50)]  
        public string Degree { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }  

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }  

       
        public virtual User User { get; set; }
    }
}
