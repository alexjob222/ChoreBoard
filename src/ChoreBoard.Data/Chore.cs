using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public ChoreCategory Category { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public string Description { get; set; }
    }
}
