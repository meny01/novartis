using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSContext
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(45)]
        [Display(Name = "Middle Name")]
        public string MidName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string FullName {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int AccountType { get; set; } = 0;

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
      

        
        public bool IsActive { get; set; } = true;

      

       
        
    }
}