using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StudentManagementApp.DAL.Entities
{
    public partial class StudentManagementModel : DbContext
    {
        public StudentManagementModel()
            : base("name=StudentModel")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<ScoreCategory> ScoreCategories { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(e => e.CourseID)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.SubjectID)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Registrations)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Majors)
                .WithRequired(e => e.Faculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Faculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Teachers)
                .WithRequired(e => e.Faculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.StudentID)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.CourseID)
                .IsUnicode(false);

            modelBuilder.Entity<Score>()
                .Property(e => e.StudentID)
                .IsUnicode(false);

            modelBuilder.Entity<Score>()
                .Property(e => e.SubjectID)
                .IsUnicode(false);

            modelBuilder.Entity<Score>()
                .Property(e => e.ScoreCategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<ScoreCategory>()
                .Property(e => e.ScoreCategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<ScoreCategory>()
                .HasMany(e => e.Scores)
                .WithRequired(e => e.ScoreCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Semester>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Semester)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Registrations)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Scores)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.SubjectID)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Scores)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Teachers)
                .WithMany(e => e.Subjects)
                .Map(m => m.ToTable("teacher_subject").MapLeftKey("SubjectID").MapRightKey("TeacherID"));

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);
        }
    }
}
