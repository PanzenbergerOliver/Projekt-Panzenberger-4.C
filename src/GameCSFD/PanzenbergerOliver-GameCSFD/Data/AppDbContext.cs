using Microsoft.EntityFrameworkCore;
using PanzenbergerOliver_GameCSFD.Entities;
using System.Collections.Generic;

namespace PanzenbergerOliver_GameCSFD.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        

    }
}
