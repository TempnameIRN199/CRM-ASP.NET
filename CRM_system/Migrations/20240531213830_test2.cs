using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM_system.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_Directors_TBL_Companies_CompanyId",
                schema: "dbo",
                table: "TBL_Directors");

            migrationBuilder.DropIndex(
                name: "IX_TBL_Directors_CompanyId",
                schema: "dbo",
                table: "TBL_Directors");

            migrationBuilder.AlterColumn<short>(
                name: "CompanyId",
                schema: "dbo",
                table: "TBL_Directors",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Directors_CompanyId",
                schema: "dbo",
                table: "TBL_Directors",
                column: "CompanyId",
                unique: true,
                filter: "[CompanyId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_Directors_TBL_Companies_CompanyId",
                schema: "dbo",
                table: "TBL_Directors",
                column: "CompanyId",
                principalSchema: "dbo",
                principalTable: "TBL_Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_Directors_TBL_Companies_CompanyId",
                schema: "dbo",
                table: "TBL_Directors");

            migrationBuilder.DropIndex(
                name: "IX_TBL_Directors_CompanyId",
                schema: "dbo",
                table: "TBL_Directors");

            migrationBuilder.AlterColumn<short>(
                name: "CompanyId",
                schema: "dbo",
                table: "TBL_Directors",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Directors_CompanyId",
                schema: "dbo",
                table: "TBL_Directors",
                column: "CompanyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_Directors_TBL_Companies_CompanyId",
                schema: "dbo",
                table: "TBL_Directors",
                column: "CompanyId",
                principalSchema: "dbo",
                principalTable: "TBL_Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
