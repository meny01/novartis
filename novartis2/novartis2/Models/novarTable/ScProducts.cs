using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MSContext
{
    public class ScProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }


        public int ProductBrandId { get; set; } // what is this?


        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public int? ClalitCode { get; set; }
        public int? YarpaCode { get; set; }
        public decimal? ClalitPrice { get; set; }
        public decimal? LeumitPrice { get; set; }
        public decimal? MeuhedetPrice { get; set; }
        public decimal? MaccabiPrice { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateModified { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        public bool IsVisible { get; set; }
        public int YearActive { get; set; }

        public int? CreatorAccountId { get; set; }
        [ForeignKey("CreatorAccountId")]
        public virtual Account CreatorAccount { get; set; }

        public int? ModifierAccountId { get; set; }
        [ForeignKey("ModifierAccountId")]
        public virtual Account ModifierAccount { get; set; }
    }
}
