using BTH2703.Models;
using Microsoft.EntityFrameworkCore;

namespace BTH2703.Data;

    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set;}
        public DbSet<Employee> Employee {get;set;  }
        public DbSet<Customer> Customer {get;set;  }
        public DbSet<Person> Person {get;set;}
    }