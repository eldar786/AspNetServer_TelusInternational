using Microsoft.EntityFrameworkCore;

namespace AspNetServer_TelusInternational.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        // Using SQLite as DB provider and place to Data folder
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");

        // Since we don't have any data records, here's some random data created through for loop
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Post[] postsToSeed = new Post[6];

            for (int i = 1; i <= 6; i++)
            {
                postsToSeed[i - 1] = new Post
                {
                    PostId = i,
                    Queue_Group_Name = $"Queue group name {i}",
                    Offered = 0,
                    Handled = i,
                    ATT = DateTime.MinValue.ToString("HH:mm:ss"),
                    AHT = DateTime.MinValue.ToString("HH:mm:ss"),
                    ServiceLevel = i
                };
            }

            modelBuilder.Entity<Post>().HasData(postsToSeed);
        }
    }
}
