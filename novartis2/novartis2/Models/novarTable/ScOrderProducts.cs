using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MSContext
{
    public class ScOrderProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderProductId { get; set; }


        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual ScOrder ScOrder { get; set; }

        public int ProductId { get; set; } // what is this?


        public int Quantity { get; set; }
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
