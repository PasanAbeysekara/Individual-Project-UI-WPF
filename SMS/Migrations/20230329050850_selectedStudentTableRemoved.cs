using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Migrations
{
    /// <inheritdoc />
    public partial class selectedStudentTableRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_SelectedStudent_SelecStudentIdx",
                table: "Students");

            migrationBuilder.DropTable(
                name: "SelectedStudent");

            migrationBuilder.DropIndex(
                name: "IX_Students_SelecStudentIdx",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SelecStudentIdx",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SelecStudentIdx",
                table: "Students",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SelectedStudent",
                columns: table => new
                {
                    Idx = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedStudent", x => x.Idx);
                });

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
    }
}
