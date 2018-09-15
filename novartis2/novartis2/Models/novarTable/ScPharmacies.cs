using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MSContext
{
    public class ScPharmacy
    {
        public ScPharmacy()
        {
            ScOrders = new HashSet<ScOrder>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PharmacyId { get; set; }


        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        [Required]
        [MaxLength(200)]
        public string PharmacyName { get; set; }

        [MaxLength(50)]
        public string PharmacyCodeId { get; set; } // what is this?

        public int HmoId { get; set; }
        [ForeignKey("HmoId")]
        public virtual ScHmo Hmo { get; set; }

        public int PharmacyGroup { get; set; }
        public int PharmacyClass { get; set; }
        public int? PharmacySector { get; set; }
        public int? PharmacyGsl { get; set; }
        public int? PharmacyErepId { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateModified { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;

        public int? CreatorAccountId { get; set; }
        [ForeignKey("CreatorAccountId")]
        public virtual Account CreatorAccount { get; set; }

        public int? ModifierAccountId { get; set; }
        [ForeignKey("ModifierAccountId")]
        public virtual Account ModifierAccount { get; set; }

        public virtual ICollection<ScOrder> ScOrders { get; set; }
    }
}
