using Cusat_University.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Cusat_University.DAL
{
    public class SchoolContext :DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Course>()
             .HasMany(c => c.Instructors).WithMany(i => i.Courses)
             .Map(t => t.MapLeftKey("CourseID")
                 .MapRightKey("InstructorID")
                 .ToTable("CourseInstructor"));

            //This code instructs Entity Framework to use stored procedures for insert, update, and delete operations on the Department entity.
            modelBuilder.Entity<Department>().MapToStoredProcedures();
        }
    }
}