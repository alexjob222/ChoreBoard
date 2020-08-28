using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreBoard.Data
{
    internal class Chore
    {
        [Key]
        public int ChoreId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public Guid Guid { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public ChoreCategory Category { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public string Notes { get; set; }

        public int? RecurrenceId { get; set; }

        [ForeignKey(nameof(RecurrenceId))]
        public ChoreRecurrence RecurrencePattern { get; set; }
    }
}
