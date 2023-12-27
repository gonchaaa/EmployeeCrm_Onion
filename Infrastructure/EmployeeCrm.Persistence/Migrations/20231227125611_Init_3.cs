using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCrm.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "StudentPayments");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "RegisterBlanks",
                newName: "LastName");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntructorId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Payment",
                table: "Students",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StudenPaymentId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentPaymentId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "StudentPayments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "RegisterBlanks",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "RegisterBlanks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InformationListId",
                table: "RegisterBlanks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "RegisterBlanks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNum",
                table: "RegisterBlanks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "RegisterBlanks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "lessonTime",
                table: "RegisterBlanks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Internships",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Internships",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Internships",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "Internships",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Expenses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "Employees",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PositionId",
                table: "Users",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_EmployeeId",
                table: "Students",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LessonId",
                table: "Students",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentPaymentId",
                table: "Students",
                column: "StudentPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_LessonId",
                table: "StudentPayments",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterBlanks_InformationListId",
                table: "RegisterBlanks",
                column: "InformationListId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterBlanks_LessonId",
                table: "RegisterBlanks",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Internships_LessonId",
                table: "Internships",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_EmployeeId",
                table: "Groups",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Employees_EmployeeId",
                table: "Groups",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Internships_Lesson_LessonId",
                table: "Internships",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterBlanks_InformationLists_InformationListId",
                table: "RegisterBlanks",
                column: "InformationListId",
                principalTable: "InformationLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterBlanks_Lesson_LessonId",
                table: "RegisterBlanks",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPayments_Lesson_LessonId",
                table: "StudentPayments",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Employees_EmployeeId",
                table: "Students",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Lesson_LessonId",
                table: "Students",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentPayments_StudentPaymentId",
                table: "Students",
                column: "StudentPaymentId",
                principalTable: "StudentPayments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Positions_PositionId",
                table: "Users",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Employees_EmployeeId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Internships_Lesson_LessonId",
                table: "Internships");

            migrationBuilder.DropForeignKey(
                name: "FK_RegisterBlanks_InformationLists_InformationListId",
                table: "RegisterBlanks");

            migrationBuilder.DropForeignKey(
                name: "FK_RegisterBlanks_Lesson_LessonId",
                table: "RegisterBlanks");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPayments_Lesson_LessonId",
                table: "StudentPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Employees_EmployeeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Lesson_LessonId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentPayments_StudentPaymentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Positions_PositionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PositionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Students_EmployeeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GroupId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_LessonId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentPaymentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudentPayments_LessonId",
                table: "StudentPayments");

            migrationBuilder.DropIndex(
                name: "IX_RegisterBlanks_InformationListId",
                table: "RegisterBlanks");

            migrationBuilder.DropIndex(
                name: "IX_RegisterBlanks_LessonId",
                table: "RegisterBlanks");

            migrationBuilder.DropIndex(
                name: "IX_Internships_LessonId",
                table: "Internships");

            migrationBuilder.DropIndex(
                name: "IX_Groups_EmployeeId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IntructorId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Payment",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudenPaymentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentPaymentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "StudentPayments");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "RegisterBlanks");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "RegisterBlanks");

            migrationBuilder.DropColumn(
                name: "InformationListId",
                table: "RegisterBlanks");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "RegisterBlanks");

            migrationBuilder.DropColumn(
                name: "PhoneNum",
                table: "RegisterBlanks");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "RegisterBlanks");

            migrationBuilder.DropColumn(
                name: "lessonTime",
                table: "RegisterBlanks");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "RegisterBlanks",
                newName: "lastName");

            migrationBuilder.AddColumn<bool>(
                name: "PaymentMethod",
                table: "StudentPayments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Internships",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Expenses",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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
        }
    }
}
