using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using YoutubeTestV2.Models;
using System.Linq;
using System.Threading.Tasks;

namespace YoutubeTestV2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
    }
}
