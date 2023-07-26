using Microsoft.EntityFrameworkCore;

namespace VertoTestProject.Data
{
    public class ContentContext : DbContext
    {
        public ContentContext(DbContextOptions<ContentContext> options) 
            : base(options) 
        { 
        }

        public DbSet<VertoTestProject.Models.Content>? Contents { get; set; }
    }
}
