using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MSContext
{
    public class ScOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public int PharmacyId { get; set; }
        [ForeignKey("PharmacyId")]
        public virtual ScPharmacy Pharmacy { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateModified { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;


        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        public int? CreatorAccountId { get; set; }
        [ForeignKey("CreatorAccountId")]
        public virtual Account CreatorAccount { get; set; }

        public int? ModifierAccountId { get; set; }
        [ForeignKey("ModifierAccountId")]
        public virtual Account ModifierAccount { get; set; }
    }
}
