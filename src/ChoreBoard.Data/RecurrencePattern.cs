using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreBoard.Data
{
    public class RecurrencePattern
    {
        [Key]
        public int RecurrenceId { get; set; }

        [Required]
        public int ChoreId { get; set; }

        [Required]
        [ForeignKey(nameof(ChoreId))]
        public Chore Chore { get; set; }

        [Required]
        public FrequencyType FrequencyType { get; set; }

        [Required]
        public int FrequencyInterval { get; set; }

        [Required]
        public RolloverType RolloverType { get; set; }

        [Required]
        public RolloverFrom RolloverFrom { get; set; }

        public int? MaxOccurrences { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
