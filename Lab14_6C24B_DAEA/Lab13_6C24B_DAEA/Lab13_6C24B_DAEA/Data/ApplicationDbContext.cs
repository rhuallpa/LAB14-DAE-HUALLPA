using Lab13_6C24B_DAEA.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab13_6C24B_DAEA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-15\\SQLEXPRESS;Initial Catalog= FACTURADB;Integrated Security=True;trustservercertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasKey(e => e.IdEnrollment);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Grade)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GradeId);

            modelBuilder.Entity<Course>()
                .HasKey(c => c.IdCourse);  // Configurar IdCourse como clave primaria
        }
    }
}
