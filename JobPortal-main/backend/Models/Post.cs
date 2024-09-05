using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Post
    {
        [Key]  
        public int PostId { get; set; } 

        [ForeignKey("User")]  
        public int UserId { get; set; } 

        [Required]
        [StringLength(100)] 
        public string Title { get; set; } 

        [Required]
        [StringLength(500)]  
        public string Description { get; set; }

        public byte[] Image { get; set; }  

        public TimeSpan TimeCreated { get; set; }  

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }  

        
        public virtual User User { get; set; }
    }
}
