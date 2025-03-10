using ImageProcessingBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageProcessingBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ImageMetadata> Images { get; set; }
    }
}
