using Microsoft.EntityFrameworkCore;

namespace ScholarshipProgramProject.Models
{
    public class StudentsDBContext : DbContext
    {
        public StudentsDBContext(DbContextOptions<StudentsDBContext> DbOptions) : base(DbOptions)
            {
            }

        public DbSet<Student> Students { get; set; }

    }
}
