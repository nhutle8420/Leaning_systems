﻿// <auto-generated />
using System;
using Leaning_system.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Leaning_system.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.4.22229.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Leaning_system.Models.Chat", b =>
                {
                    b.Property<int>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChatId"), 1L, 1);

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChatId");

                    b.HasIndex("ClassID");

                    b.ToTable("chats");
                });

            modelBuilder.Entity("Leaning_system.Models.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numberday")
                        .HasColumnType("int");

                    b.Property<string>("PassClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Security")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentusernameHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectsSubjectId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherusernameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startday")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("usernameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usernameHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassID");

                    b.HasIndex("StudentusernameHV");

                    b.HasIndex("SubjectsSubjectId");

                    b.HasIndex("TeacherusernameGV");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Leaning_system.Models.Courses", b =>
                {
                    b.Property<int>("Course")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Course"), 1L, 1);

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<string>("CoursesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numberday")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startday")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Course");

                    b.HasIndex("ClassID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Leaning_system.Models.Examl_detial", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassID"), 1L, 1);

                    b.Property<int>("ClassID1")
                        .HasColumnType("int");

                    b.Property<string>("Context")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("day")
                        .HasColumnType("datetime2");

                    b.Property<string>("start_xaml")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassID");

                    b.HasIndex("ClassID1");

                    b.ToTable("examl_Detials");
                });

            modelBuilder.Entity("Leaning_system.Models.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("Leaning_system.Models.Scord", b =>
                {
                    b.Property<string>("usernameHV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<int>("Mouth_point")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Upload_day")
                        .HasColumnType("datetime2");

                    b.Property<int>("assiduity_point")
                        .HasColumnType("int");

                    b.Property<int>("avegare")
                        .HasColumnType("int");

                    b.Property<int>("factor2")
                        .HasColumnType("int");

                    b.Property<int>("factor3")
                        .HasColumnType("int");

                    b.Property<string>("result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("scord_TB")
                        .HasColumnType("int");

                    b.Property<string>("usernameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("usernameHV");

                    b.HasIndex("ClassID");

                    b.ToTable("scords");
                });

            modelBuilder.Entity("Leaning_system.Models.Student", b =>
                {
                    b.Property<string>("usernameHV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameHS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.Property<string>("passwordHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("usernameHV");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Leaning_system.Models.Subjects", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("schedule")
                        .HasColumnType("datetime2");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Leaning_system.Models.Teacher", b =>
                {
                    b.Property<string>("usernameGV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.Property<string>("passwordGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("powerID")
                        .HasColumnType("int");

                    b.HasKey("usernameGV");

                    b.HasIndex("powerID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Leaning_system.Models.test_schedule", b =>
                {
                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Day_test")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubjectsSubjectId")
                        .HasColumnType("int");

                    b.Property<string>("contest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_test")
                        .HasColumnType("datetime2");

                    b.Property<string>("file")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("form")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("start_test")
                        .HasColumnType("datetime2");

                    b.Property<string>("time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Topic");

                    b.HasIndex("SubjectsSubjectId");

                    b.ToTable("test_Schedules");
                });

            modelBuilder.Entity("Leaning_system.Models.Chat", b =>
                {
                    b.HasOne("Leaning_system.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Leaning_system.Models.Class", b =>
                {
                    b.HasOne("Leaning_system.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentusernameHV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Leaning_system.Models.Subjects", "Subjects")
                        .WithMany()
                        .HasForeignKey("SubjectsSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Leaning_system.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherusernameGV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subjects");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Leaning_system.Models.Courses", b =>
                {
                    b.HasOne("Leaning_system.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Leaning_system.Models.Examl_detial", b =>
                {
                    b.HasOne("Leaning_system.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Leaning_system.Models.Scord", b =>
                {
                    b.HasOne("Leaning_system.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Leaning_system.Models.Teacher", b =>
                {
                    b.HasOne("Leaning_system.Models.Power", "Power")
                        .WithMany()
                        .HasForeignKey("powerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Power");
                });

            modelBuilder.Entity("Leaning_system.Models.test_schedule", b =>
                {
                    b.HasOne("Leaning_system.Models.Subjects", "Subjects")
                        .WithMany()
                        .HasForeignKey("SubjectsSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}