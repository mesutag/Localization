using Microsoft.EntityFrameworkCore;

namespace Localization.Core.Entities.Resource
{
    public static class ResourceConfig
    {
        public static void AddResourceConfig(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>(n =>
            {
                n.HasKey(ne => ne.Id);
                n.ToTable("Resource");
            });
        }
    }
}
