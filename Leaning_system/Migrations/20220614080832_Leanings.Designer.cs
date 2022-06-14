﻿// <auto-generated />
using System;
using Leaning_system.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Leaning_system.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220614080832_Leanings")]
    partial class Leanings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Leaning_system.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Leaning_system.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Security")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_day")
                        .HasColumnType("datetime2");

                    b.Property<int>("numberday")
                        .HasColumnType("int");

                    b.Property<DateTime>("start_day")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("studentusernameHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("subjectsSubjectId")
                        .HasColumnType("int");

                    b.Property<string>("teacherusernameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("usernameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usernameHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.HasIndex("studentusernameHV");

                    b.HasIndex("subjectsSubjectId");

                    b.HasIndex("teacherusernameGV");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Leaning_system.Models.Courses", b =>
                {
                    b.Property<int>("Course")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Course"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_day")
                        .HasColumnType("datetime2");

                    b.Property<int>("numberday")
                        .HasColumnType("int");

                    b.Property<DateTime>("start_day")
                        .HasColumnType("datetime2");

                    b.HasKey("Course");

                    b.HasIndex("ClassId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Leaning_system.Models.Examl_detial", b =>
                {
                    b.Property<string>("Context")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

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

                    b.HasKey("Context");

                    b.HasIndex("ClassId");

                    b.ToTable("Examl_detial");
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

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Mouth_point")
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

                    b.HasIndex("ClassId");

                    b.ToTable("Scord");
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

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NameGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PowerId")
                        .HasColumnType("int");

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.Property<string>("passwordGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("usernameGV");

                    b.HasIndex("PowerId");

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

                    b.ToTable("test_schedule");
                });

            modelBuilder.Entity("Leaning_system.Models.Chat", b =>
                {
                    b.HasOne("Leaning_system.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Leaning_system.Models.Class", b =>
                {
                    b.HasOne("Leaning_system.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentusernameHV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Leaning_system.Models.Subjects", "subjects")
                        .WithMany()
                        .HasForeignKey("subjectsSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Leaning_system.Models.Teacher", "teacher")
                        .WithMany()
                        .HasForeignKey("teacherusernameGV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student");

                    b.Navigation("subjects");

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("Leaning_system.Models.Courses", b =>
                {
                    b.HasOne("Leaning_system.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Leaning_system.Models.Examl_detial", b =>
                {
                    b.HasOne("Leaning_system.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Leaning_system.Models.Scord", b =>
                {
                    b.HasOne("Leaning_system.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Leaning_system.Models.Teacher", b =>
                {
                    b.HasOne("Leaning_system.Models.Power", "Power")
                        .WithMany()
                        .HasForeignKey("PowerId")
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