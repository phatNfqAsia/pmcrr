using System;
using Microsoft.EntityFrameworkCore;
using pmcrr.Models;
namespace pmcrr.DataContext
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Wearing> Wearing { get; set; }
        public virtual DbSet<Outfit> Outfit { get; set; }
        public virtual DbSet<OutfitAndWearing> OutfitAndWearing { get; set; }
    }
}
 