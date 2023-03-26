using Microsoft.EntityFrameworkCore;
using BAITHUCHANH0703.Models;


namespace BAITHUCHANH0703.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}