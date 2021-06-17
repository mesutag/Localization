using Localization.Core.Entities.Resource;
using Microsoft.EntityFrameworkCore;

namespace Localization.Core.Context
{
    public class LocalizationContext : DbContext
    {
        public LocalizationContext()
        {
        }

        public LocalizationContext(DbContextOptions<LocalizationContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddResourceConfig();
        }
    }
}
