using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Migrations
{
    /// <inheritdoc />
    public partial class sample3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelectedStudent_Students_StudId",
                table: "SelectedStudent");

            migrationBuilder.DropIndex(
                name: "IX_SelectedStudent_StudId",
                table: "SelectedStudent");

            migrationBuilder.DropColumn(
                name: "StudId",
                table: "SelectedStudent");

            migrationBuilder.AddColumn<int>(
                name: "SelecStudentIdx",
                table: "Students",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_SelecStudentIdx",
                table: "Students",
                column: "SelecStudentIdx");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_SelectedStudent_SelecStudentIdx",
                table: "Students",
                column: "SelecStudentIdx",
                principalTable: "SelectedStudent",
                principalColumn: "Idx");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_SelectedStudent_SelecStudentIdx",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SelecStudentIdx",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SelecStudentIdx",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudId",
                table: "SelectedStudent",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SelectedStudent_StudId",
                table: "SelectedStudent",
                column: "StudId");

            migrationBuilder.AddForeignKey(
                name: "FK_SelectedStudent_Students_StudId",
                table: "SelectedStudent",
                column: "StudId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
