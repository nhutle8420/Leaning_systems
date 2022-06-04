using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leaning_system.Migrations
{
    /// <inheritdoc />
    public partial class Leanings : Migration
    {
        /// <inheritdoc />
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
                    powerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.usernameGV);
                    table.ForeignKey(
                        name: "FK_Teachers_Powers_powerID",
                        column: x => x.powerID,
                        principalTable: "Powers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "test_Schedules",
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
                    table.PrimaryKey("PK_test_Schedules", x => x.Topic);
                    table.ForeignKey(
                        name: "FK_test_Schedules_Subjects_SubjectsSubjectId",
                        column: x => x.SubjectsSubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numberday = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Security = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    TeacherusernameGV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    usernameGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectsSubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentusernameHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    usernameHV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_Classes_Students_StudentusernameHV",
                        column: x => x.StudentusernameHV,
                        principalTable: "Students",
                        principalColumn: "usernameHV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Subjects_SubjectsSubjectId",
                        column: x => x.SubjectsSubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_TeacherusernameGV",
                        column: x => x.TeacherusernameGV,
                        principalTable: "Teachers",
                        principalColumn: "usernameGV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chats",
                columns: table => new
                {
                    ChatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chats", x => x.ChatId);
                    table.ForeignKey(
                        name: "FK_chats_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Course = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoursesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    Numberday = table.Column<int>(type: "int", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Course);
                    table.ForeignKey(
                        name: "FK_Courses_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "examl_Detials",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID1 = table.Column<int>(type: "int", nullable: false),
                    day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_xaml = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examl_Detials", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_examl_Detials_Classes_ClassID1",
                        column: x => x.ClassID1,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scords",
                columns: table => new
                {
                    usernameHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_scords", x => x.usernameHV);
                    table.ForeignKey(
                        name: "FK_scords_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chats_ClassID",
                table: "chats",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_StudentusernameHV",
                table: "Classes",
                column: "StudentusernameHV");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SubjectsSubjectId",
                table: "Classes",
                column: "SubjectsSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherusernameGV",
                table: "Classes",
                column: "TeacherusernameGV");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassID",
                table: "Courses",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_examl_Detials_ClassID1",
                table: "examl_Detials",
                column: "ClassID1");

            migrationBuilder.CreateIndex(
                name: "IX_scords_ClassID",
                table: "scords",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_powerID",
                table: "Teachers",
                column: "powerID");

            migrationBuilder.CreateIndex(
                name: "IX_test_Schedules_SubjectsSubjectId",
                table: "test_Schedules",
                column: "SubjectsSubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chats");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "examl_Detials");

            migrationBuilder.DropTable(
                name: "scords");

            migrationBuilder.DropTable(
                name: "test_Schedules");

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
