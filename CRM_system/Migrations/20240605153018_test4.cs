using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM_system.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_Deals_TBL_Clients_ClientId",
                schema: "dbo",
                table: "TBL_Deals");

            migrationBuilder.DropIndex(
                name: "IX_TBL_Deals_ClientId",
                schema: "dbo",
                table: "TBL_Deals");

            migrationBuilder.AlterColumn<long>(
                name: "ClientId",
                schema: "dbo",
                table: "TBL_Deals",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "DealId",
                schema: "dbo",
                table: "TBL_Clients",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Deals_ClientId",
                schema: "dbo",
                table: "TBL_Deals",
                column: "ClientId",
                unique: true,
                filter: "[ClientId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_Deals_TBL_Clients_ClientId",
                schema: "dbo",
                table: "TBL_Deals",
                column: "ClientId",
                principalSchema: "dbo",
                principalTable: "TBL_Clients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_Deals_TBL_Clients_ClientId",
                schema: "dbo",
                table: "TBL_Deals");

            migrationBuilder.DropIndex(
                name: "IX_TBL_Deals_ClientId",
                schema: "dbo",
                table: "TBL_Deals");

            migrationBuilder.AlterColumn<long>(
                name: "ClientId",
                schema: "dbo",
                table: "TBL_Deals",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DealId",
                schema: "dbo",
                table: "TBL_Clients",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Deals_ClientId",
                schema: "dbo",
                table: "TBL_Deals",
                column: "ClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_Deals_TBL_Clients_ClientId",
                schema: "dbo",
                table: "TBL_Deals",
                column: "ClientId",
                principalSchema: "dbo",
                principalTable: "TBL_Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
