using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Private_Lessons.Models

{
   public partial class entitycoreContext : DbContext
{
public virtual DbSet<Item> Item { get; set; }
public virtual DbSet<subject> subject { get; set; }
public virtual DbSet<users> users {get; set;}
public virtual DbSet<user_types> user_types {get; set;}
public virtual DbSet<teachers> teachers{get; set;}
public virtual DbSet<answers> answers{get; set;}
public virtual DbSet<book> book{get; set;}
public virtual DbSet<exam_question> exam_question{get; set;}
public virtual DbSet<exam> exam{get; set;}
public virtual DbSet<question> question{get; set;}
public virtual DbSet<student_answer> student_answer{get; set;}
public virtual DbSet<student_exams> student_exams{get; set;}
public virtual DbSet<student_subject_registration> student_subject_registration{get; set;}
public virtual DbSet<students> students{get; set;}
public virtual DbSet<subject_teachers> subject_teachers{get; set;}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{

optionsBuilder.UseNpgsql(@"Host=localhost;Database=PLS;Username=postgres;Password=bb12345");
}
//model builder for item table
  


        protected  void OnModel(ModelBuilder modelBuilder1)
        {
            modelBuilder1.Entity<user_types>(entity =>
            {
              

                entity.ToTable("user_types", "public");
                entity.Property(e => e.type_id).HasColumnName("user_id");

                entity.Property(e => e.type_name)
                    .HasColumnName("type_name")
                    .HasColumnType("text")
                    .HasMaxLength(14);

            });
        }




}
}