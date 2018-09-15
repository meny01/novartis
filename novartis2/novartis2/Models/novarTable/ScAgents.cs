using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MSContext
{
    public class ScAgent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgentId { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; } = DateTime.UtcNow;

        public bool? IsPharmSale { get; set; }
        public bool? IsFormSale { get; set; }

        //[Index]
        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        //[Index]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        public int? CreatorAccountId { get; set; }
        [ForeignKey("CreatorAccountId")]
        public virtual Account CreatorAccount { get; set; }

        public int? ModifierAccountId { get; set; }
        [ForeignKey("ModifierAccountId")]
        public virtual Account ModifierAccount { get; set; }
    }
}
