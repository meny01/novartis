using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MSContext
{
    public class ScBrand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }

        [Required]
        [MaxLength(50)]
        public string BrandName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateModified { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;


        public int? CreatorAccountId { get; set; }
        [ForeignKey("CreatorAccountId")]
        public virtual Account CreatorAccount { get; set; }

        public int? ModifierAccountId { get; set; }
        [ForeignKey("ModifierAccountId")]
        public virtual Account ModifierAccount { get; set; }
    }
}
