using ChoreBoard.Data.Database.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Data.Database
{
    internal class ChoreDbContext : DbContext
    {
        public DbSet<Chore> Chores { get; set; }
        public DbSet<ChoreCategory> ChoreCategories { get; set; }
        public DbSet<ChoreHistory> ChoreHistory { get; set; }
        public DbSet<ChoreRecurrence> ChoreRecurrence { get; set; }
        public DbSet<SuspendedChore> SuspendedChores { get; set; }
    }
}
