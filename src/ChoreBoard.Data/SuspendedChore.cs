using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ChoreBoard.Data
{
    internal class SuspendedChore
    {
        [Key]
        public int SuspensionId { get; set; }

        [Required]
        public int ChoreId { get; set; }

        [Required]
        [ForeignKey(nameof(ChoreId))]
        public Chore Chore { get; set; }

        [Required]
        public DateTime SuspendStartDateUtc { get; set; }

        public DateTime? SuspendEndDateUtc { get; set; }
    }
}
