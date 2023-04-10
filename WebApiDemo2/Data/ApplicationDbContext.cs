using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Data;
using WebApiDemo2.Models;

namespace WebApiDemo2.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
      public DbSet<Product> products { get; set; }
    }
}
