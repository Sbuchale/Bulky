
using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
         
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; } 
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(

                new Category { Id = 1, Name = "action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(

                new Company {
                    Id = 1, 
                    Name = "tech solution",
                    StreetAddress = "123 tech st",
                    City = "Tech City",
                    PostalCode = "12121",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid book",
                    StreetAddress = "999 tech st",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Reader club",
                    StreetAddress = "99 main st",
                    City = "Lala Land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "111333555"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                  new Product
                  {
                      Id = 1,
                      Title = "The Pragmatic Programmer",
                      Description = "Classic book on software engineering and best practices.",
                      ISBN = "978-0201616224",
                      Author = "Andrew Hunt & David Thomas",
                      ListPrice = 59.99,
                      Price = 54.99,
                      Price50 = 49.99,
                      Price100 = 44.99,
                      CategoryId = 1,
                      ImageUrl = ""
                  },
    new Product
    {
        Id = 2,
        Title = "Refactoring",
        Description = "Improving the design of existing code.",
        ISBN = "978-0134757599",
        Author = "Martin Fowler",
        ListPrice = 69.99,
        Price = 64.99,
        Price50 = 59.99,
        Price100 = 54.99,
        CategoryId = 1,
        ImageUrl = ""
    },
    new Product
    {
        Id = 3,
        Title = "You Don't Know JS Yet",
        Description = "A deep dive into JavaScript for serious learners.",
        ISBN = "978-1091210090",
        Author = "Kyle Simpson",
        ListPrice = 45.00,
        Price = 40.00,
        Price50 = 37.00,
        Price100 = 34.00,
        CategoryId = 1,
        ImageUrl = ""
    },
    new Product
    {
        Id = 4,
        Title = "Introduction to Algorithms",
        Description = "Comprehensive textbook on algorithms.",
        ISBN = "978-0262033848",
        Author = "Thomas H. Cormen",
        ListPrice = 89.99,
        Price = 79.99,
        Price50 = 74.99,
        Price100 = 69.99,
        CategoryId = 2,
        ImageUrl = ""
    },
    new Product
    {
        Id = 5,
        Title = "Clean Architecture",
        Description = "A guide to building maintainable and scalable software systems.",
        ISBN = "978-0134494166",
        Author = "Robert C. Martin",
        ListPrice = 65.00,
        Price = 58.00,
        Price50 = 55.00,
        Price100 = 50.00,
        CategoryId = 7,
        ImageUrl = ""
    }
      );
        }
    }
}
