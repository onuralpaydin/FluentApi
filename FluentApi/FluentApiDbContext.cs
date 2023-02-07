using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    internal class FluentApiDbContext:DbContext
    {
        public FluentApiDbContext():base("conn")
        {

        }
        //public DbSet<Ogrenci> Ogrenci { get; set; }
        //public DbSet<OgrenciAdres> OgrenciAdres { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAdress> StudentAdresses { get; set; }
        public DbSet<Grade> Grades { get; set; }

       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //1-0 ya da 1-1
            modelBuilder.Entity<Student>().HasOptional(st => st.Adress)
                .WithRequired(a => a.Student);

            //1 e çok
            modelBuilder.Entity<Student>().HasRequired<Grade>(student => student.CurrentGrade)
                .WithMany(grade => grade.Students)
                .HasForeignKey<int>(student => student.CurrentGradeId);

            //Çoka çok
            modelBuilder.Entity<Student>()
                .HasMany<Course>(student => student.Courses)
                .WithMany(courses => courses.Students)
                .Map(sc =>
                {
                    sc.MapLeftKey("StudentId");
                    sc.MapRightKey("CourseId");
                    sc.ToTable("StudentCourse");

                }
                );




            base.OnModelCreating(modelBuilder);
        }
    }
}
