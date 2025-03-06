using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace quiz_ynov.Migrations
{
    /// <inheritdoc />
    public partial class AjoutIdQuizzandQuestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Quiz",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "QuizId",
                table: "Question",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Question");
        }
    }
}
