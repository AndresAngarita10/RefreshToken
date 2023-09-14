using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialCreatePass3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userRol_rol_IdRolFk",
                table: "userRol");

            migrationBuilder.DropForeignKey(
                name: "FK_userRol_user_IdUserFk",
                table: "userRol");

            migrationBuilder.RenameColumn(
                name: "IdRolFk",
                table: "userRol",
                newName: "RolId");

            migrationBuilder.RenameColumn(
                name: "IdUserFk",
                table: "userRol",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_userRol_IdRolFk",
                table: "userRol",
                newName: "IX_userRol_RolId");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "rol",
                newName: "rolName");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "user",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_userRol_rol_RolId",
                table: "userRol",
                column: "RolId",
                principalTable: "rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userRol_user_UsuarioId",
                table: "userRol",
                column: "UsuarioId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userRol_rol_RolId",
                table: "userRol");

            migrationBuilder.DropForeignKey(
                name: "FK_userRol_user_UsuarioId",
                table: "userRol");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "userRol",
                newName: "IdRolFk");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "userRol",
                newName: "IdUserFk");

            migrationBuilder.RenameIndex(
                name: "IX_userRol_RolId",
                table: "userRol",
                newName: "IX_userRol_IdRolFk");

            migrationBuilder.RenameColumn(
                name: "rolName",
                table: "rol",
                newName: "nombre");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "user",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_userRol_rol_IdRolFk",
                table: "userRol",
                column: "IdRolFk",
                principalTable: "rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userRol_user_IdUserFk",
                table: "userRol",
                column: "IdUserFk",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
