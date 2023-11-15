namespace BlazorPiano.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Details>().HasData(
                new Details
                {
                    Id = 1,
                    Name = "Becky",
                    Description = "I am a classically trained musician who has been teaching for over 6 years. I teach casual learners and for ABRSM exams. Styles include classical, contemporary, blues/jazz.",
                    LessonDetails = "All ages from 6 to retirement are welcome. Teaching rate: £32.00 per hour Current teaching days in Great Dunmow: Wednesday, Thursday Current availability in Great Dunmow: Thursday 3:30pm-4:00pm and 4:00pm-4:30pm. I can also accommodate fortnightly lessons, please contact for availability. Current teaching days in Bishop Stortford: Monday, Tuesday, Friday, Saturday Current availability in Bishop Stortford: Please contact",
                    ImageUrl = "https://lh3.googleusercontent.com/p/AF1QipP-QQbhWJCGSqHx_Ov9sb0UI33q7gTd-guRmVct=s680-w680-h510"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "One Lesson",
                    Description = "A single half hour lesson",
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
                    Description = "Three half hour lessons",
                    ImageUrl = "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Price = 35.99m
                }

                );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Details> Details1 { get; set; }
    }
}

