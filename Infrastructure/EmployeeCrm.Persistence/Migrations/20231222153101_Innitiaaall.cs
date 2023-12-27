using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EmployeeCrm.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Innitiaaall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordRepeat",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "StudentPayments",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "PaymentMethod",
                table: "StudentPayments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Satisfactions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "RegisterBlanks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "RegisterBlanks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PositionName",
                table: "Positions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Messages",
                table: "Messages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "MeetingDate",
                table: "Meetings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LessonName",
                table: "Lesson",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Internships",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Internships",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "InformationLists",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GroupNumber",
                table: "Groups",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Groups",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ExpenseTypes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ExpenseTypeId",
                table: "Expenses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Expenses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Expenses",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "Expenses",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "EventTime",
                table: "Events",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Organizator",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Present",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartWork",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "UserAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LessonId = table.Column<int>(type: "integer", nullable: false),
                    Attendance = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAttendances_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAttendances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAttendances_LessonId",
                table: "UserAttendances",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAttendances_UserId",
                table: "UserAttendances",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.DropTable(
                name: "UserAttendances");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordRepeat",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "StudentPayments");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "StudentPayments");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Satisfactions");

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "RegisterBlanks");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "RegisterBlanks");

            migrationBuilder.DropColumn(
                name: "PositionName",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "Messages",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MeetingDate",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "LessonName",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "InformationLists");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "ExpenseTypes");

            migrationBuilder.DropColumn(
                name: "ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "EventTime",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Organizator",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Present",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartWork",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                });
        }
    }
}
