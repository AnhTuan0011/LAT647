using BTH2703.Models;
using Microsoft.EntityFrameworkCore;


// aplication dbcontext de quan ly thay doi khi update database
namespace BTH2703.Data;

    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student{get; set;} = default!;
        public DbSet<Employee> Employee {get;set;  }
        public DbSet<Person> Person {get;set;}
        public DbSet<BTH2703.Models.Customer> Customer { get; set; } = default!;

        public DbSet<BTH2703.Models.Faculty> Faculty { get; set; } = default!;

    }