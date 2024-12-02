using Microsoft.EntityFrameworkCore;

namespace DictionaryAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Translation> Translations { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }

    public class Translation
    {
        public int Id { get; set; }
        public string English { get; set; }
        public string Hungarian { get; set; }
    }
}
