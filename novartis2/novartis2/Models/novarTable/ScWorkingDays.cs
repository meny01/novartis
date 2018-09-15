using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MSContext
{
    public class ScWorkingDay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScWorkingDayId { get; set; }


        public int Year { get; set; }
        public int Month { get; set; }
        public decimal WorkingDays { get; set; }
        public int Quarter { get; set; }
        public DateTime Date { get; set; }
    }
}
