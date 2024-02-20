using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Feedback.Migrations
{
    /// <inheritdoc />
    public partial class changeanswermodelstofeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Answers_AnswerId",
                table: "Files");

            migrationBuilder.RenameColumn(
                name: "AnswerId",
                table: "Files",
                newName: "FeedbackId");

            migrationBuilder.RenameIndex(
                name: "IX_Files_AnswerId",
                table: "Files",
                newName: "IX_Files_FeedbackId");

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Answers",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AddColumn<bool>(
                name: "IsSeen",
                table: "Answers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Reviewed",
                table: "Answers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Answers_FeedbackId",
                table: "Files",
                column: "FeedbackId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Answers_FeedbackId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "IsSeen",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Reviewed",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "FeedbackId",
                table: "Files",
                newName: "AnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_Files_FeedbackId",
                table: "Files",
                newName: "IX_Files_AnswerId");

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Answers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Answers_AnswerId",
                table: "Files",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
