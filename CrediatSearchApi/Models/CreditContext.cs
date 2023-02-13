using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CrediatSearchApi.Models
{
    public class CreditContext : DbContext
    {
        public CreditContext(DbContextOptions<CreditContext> options)  : base(options) { }

        public DbSet<Credit> Credits { get;set; }
        public DbSet<Bank> Bank { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>()
                .HasMany(c => c.Credits)
                .WithOne(b => b.Bank)
                .HasForeignKey(f => f.BankId);

        }
    }
}
