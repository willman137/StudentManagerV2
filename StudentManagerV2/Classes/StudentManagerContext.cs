namespace StudentManager.Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentManagerContext : DbContext
    {
        public StudentManagerContext()
            : base("name=StudentManagerContext")
        {
        }

        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Program>()
                .Property(e => e.ProgramCode)
                .IsFixedLength();

            modelBuilder.Entity<Program>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.LastName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.ProgramCode)
                .IsFixedLength();
        }
    }
}
