using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leaning_system.Migrations
{
    public partial class leanings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Powers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Powers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    usernameHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    passwordHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameHS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.usernameHV);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    usernameGV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    passwordGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.usernameGV);
                    table.ForeignKey(
                        name: "FK_Teachers_Powers_PowerId",
                        column: x => x.PowerId,
                        principalTable: "Powers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "test_schedule",
                columns: table => new
                {
                    Topic = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectsSubjectId = table.Column<int>(type: "int", nullable: false),
                    Day_test = table.Column<DateTime>(type: "datetime2", nullable: false),
                    time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    form = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_test = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_test = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    file = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test_schedule", x => x.Topic);
                    table.ForeignKey(
                        name: "FK_test_schedule_Subjects_SubjectsSubjectId",
                        column: x => x.SubjectsSubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberday = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Security = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    studentusernameHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    teacherusernameGV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    usernameGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usernameHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subjectsSubjectId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_Classes_Students_studentusernameHV",
                        column: x => x.studentusernameHV,
                        principalTable: "Students",
                        principalColumn: "usernameHV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Subjects_subjectsSubjectId",
                        column: x => x.subjectsSubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_teacherusernameGV",
                        column: x => x.teacherusernameGV,
                        principalTable: "Teachers",
                        principalColumn: "usernameGV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Course = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    numberday = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Course);
                    table.ForeignKey(
                        name: "FK_Courses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Examl_detial",
                columns: table => new
                {
                    Context = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_xaml = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examl_detial", x => x.Context);
                    table.ForeignKey(
                        name: "FK_Examl_detial_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scord",
                columns: table => new
                {
                    usernameHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    usernameGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assiduity_point = table.Column<int>(type: "int", nullable: false),
                    Mouth_point = table.Column<int>(type: "int", nullable: false),
                    factor2 = table.Column<int>(type: "int", nullable: false),
                    factor3 = table.Column<int>(type: "int", nullable: false),
                    avegare = table.Column<int>(type: "int", nullable: false),
                    scord_TB = table.Column<int>(type: "int", nullable: false),
                    result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Upload_day = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scord", x => x.usernameHV);
                    table.ForeignKey(
                        name: "FK_Scord_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ClassID",
                table: "Chats",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_studentusernameHV",
                table: "Classes",
                column: "studentusernameHV");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_subjectsSubjectId",
                table: "Classes",
                column: "subjectsSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_teacherusernameGV",
                table: "Classes",
                column: "teacherusernameGV");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassId",
                table: "Courses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Examl_detial_ClassId",
                table: "Examl_detial",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Scord_ClassId",
                table: "Scord",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_PowerId",
                table: "Teachers",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_test_schedule_SubjectsSubjectId",
                table: "test_schedule",
                column: "SubjectsSubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Examl_detial");

            migrationBuilder.DropTable(
                name: "Scord");

            migrationBuilder.DropTable(
                name: "test_schedule");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Powers");
        }
    }
}
