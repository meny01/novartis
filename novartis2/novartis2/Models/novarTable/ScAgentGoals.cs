using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MSContext
{
    public class ScAgentGoal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgentGoalId { get; set; }


        
        public int HmoId { get; set; }
        [ForeignKey("HmoId")]
        public virtual ScHmo Hmo { get; set; }


        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual ScProduct Product { get; set; }

        public int? Q1Quantity { get; set; }
        public int? Q2Quantity { get; set; }
        public int? Q3Quantity { get; set; }
        public int? Q4Quantity { get; set; }
        public int? Year { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateModified { get; set; } = DateTime.UtcNow;


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
