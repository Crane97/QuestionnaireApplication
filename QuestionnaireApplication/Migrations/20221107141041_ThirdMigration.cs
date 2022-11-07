using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionnaireApplication.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answer_question_QuestionId",
                table: "answer");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "answer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_answer_question_QuestionId",
                table: "answer",
                column: "QuestionId",
                principalTable: "question",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answer_question_QuestionId",
                table: "answer");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "answer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_answer_question_QuestionId",
                table: "answer",
                column: "QuestionId",
                principalTable: "question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
