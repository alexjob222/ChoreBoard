﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChoreBoard.Data.Database.Tables
{
    internal class ChoreCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public Guid Guid { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Chore> Chores { get; set; }
    }
}
