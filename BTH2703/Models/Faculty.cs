using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BTH2703.Models
{   
    [Table("Faculty")]
    public class Faculty
    {
        [Key]
        public string FacultyID { get; set; }
        public string FacultyName { get; set; }
        // public DbSet<BTH2703.Models.Faculty> Faculty { get; set; } = default!;


    }
}