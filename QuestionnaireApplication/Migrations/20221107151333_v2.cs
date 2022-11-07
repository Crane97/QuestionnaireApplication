using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionnaireApplication.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_useranswer_question_QuestionId",
                table: "useranswer");

            migrationBuilder.DropForeignKey(
                name: "FK_useranswer_user_UserId",
                table: "useranswer");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "useranswer",
                newName: "UserIdId");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "useranswer",
                newName: "QuestionIdId");

            migrationBuilder.RenameIndex(
                name: "IX_useranswer_UserId",
                table: "useranswer",
                newName: "IX_useranswer_UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_useranswer_QuestionId",
                table: "useranswer",
                newName: "IX_useranswer_QuestionIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_useranswer_question_QuestionIdId",
                table: "useranswer",
                column: "QuestionIdId",
                principalTable: "question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_useranswer_user_UserIdId",
                table: "useranswer",
                column: "UserIdId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_useranswer_question_QuestionIdId",
                table: "useranswer");

            migrationBuilder.DropForeignKey(
                name: "FK_useranswer_user_UserIdId",
                table: "useranswer");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "useranswer",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "QuestionIdId",
                table: "useranswer",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_useranswer_UserIdId",
                table: "useranswer",
                newName: "IX_useranswer_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_useranswer_QuestionIdId",
                table: "useranswer",
                newName: "IX_useranswer_QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_useranswer_question_QuestionId",
                table: "useranswer",
                column: "QuestionId",
                principalTable: "question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_useranswer_user_UserId",
                table: "useranswer",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
