namespace BlazorPiano.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "One Lesson",
                    Descrition = "A single half hour lesson",
                    ImageUrl = "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Price = 20.99m
                },
        new Product
        {
            Id = 2,
            Title = "Two Lessons",
                    Description = "Two half hour lessons",
            ImageUrl = "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
            Price = 30.99m
        },
        new Product
        {
            Id = 3,
            Title = "Three Lessons",
            Descrition = "Three half hour lessons",
            ImageUrl = "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
            Price = 35.99m
        }

                );
        }
        public DbSet<Product> Products { get; set; }
    }
}

