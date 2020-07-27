using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreBoard.Data
{
    public class Chore
    {
        [Key]
        public int ChoreId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public Guid Guid { get; set; } = Guid.NewGuid();

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
        public RecurrencePattern RecurrencePattern { get; set; }
    }
}
