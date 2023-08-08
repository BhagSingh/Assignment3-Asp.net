using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment3_Asp.net.Models;

namespace Assignment3_Asp.net.Data
{
    public class Assignment3_AspnetContext : DbContext
    {
        public Assignment3_AspnetContext (DbContextOptions<Assignment3_AspnetContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment3_Asp.net.Models.Movie> Movie { get; set; } = default!;
    }
}
