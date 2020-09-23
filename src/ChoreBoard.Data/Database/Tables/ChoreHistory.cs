using ChoreBoard.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ChoreBoard.Data.Database.Tables
{
    internal class ChoreHistory
    {
        [Key]
        public int HistoryId { get; set; }

        [Required]
        public int ChoreId { get; set; }

        [Required]
        [ForeignKey(nameof(ChoreId))]
        public Chore Chore { get; set; }

        [Required]
        public ActionType Action { get; set; }

        [Required]
        public DateTime ActionDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
    }
}
