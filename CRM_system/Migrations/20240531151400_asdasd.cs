using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM_system.Migrations
{
    /// <inheritdoc />
    public partial class asdasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "TBL_Clients",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DealId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_Companies",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfEstab = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DirectorId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DealStatuses",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DealStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DirectorsAcctsLogsPwds",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DirectorId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DirectorsAcctsLogsPwds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_ManagersAcctsLogsPwds",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ManagersAcctsLogsPwds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_ClientsNotations",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ClientsNotations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_ClientsNotations_TBL_Clients_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "dbo",
                        principalTable: "TBL_Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_Directors",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<short>(type: "smallint", nullable: false),
                    DirectorAcctLogPwdId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_Directors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_Directors_TBL_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "TBL_Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_Directors_TBL_DirectorsAcctsLogsPwds_DirectorAcctLogPwdId",
                        column: x => x.DirectorAcctLogPwdId,
                        principalSchema: "dbo",
                        principalTable: "TBL_DirectorsAcctsLogsPwds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_Managers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<short>(type: "smallint", nullable: false),
                    ManagerAcctLogPwdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_Managers_TBL_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "TBL_Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_Managers_TBL_ManagersAcctsLogsPwds_ManagerAcctLogPwdId",
                        column: x => x.ManagerAcctLogPwdId,
                        principalSchema: "dbo",
                        principalTable: "TBL_ManagersAcctsLogsPwds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_Deals",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    DealStatusId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_Deals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_Deals_TBL_Clients_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "dbo",
                        principalTable: "TBL_Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_Deals_TBL_DealStatuses_DealStatusId",
                        column: x => x.DealStatusId,
                        principalSchema: "dbo",
                        principalTable: "TBL_DealStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_Deals_TBL_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "dbo",
                        principalTable: "TBL_Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DealsEvents",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DealId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DealsEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_DealsEvents_TBL_Deals_DealId",
                        column: x => x.DealId,
                        principalSchema: "dbo",
                        principalTable: "TBL_Deals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_ClientsNotations_ClientId",
                schema: "dbo",
                table: "TBL_ClientsNotations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Deals_ClientId",
                schema: "dbo",
                table: "TBL_Deals",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Deals_DealStatusId",
                schema: "dbo",
                table: "TBL_Deals",
                column: "DealStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Deals_ManagerId",
                schema: "dbo",
                table: "TBL_Deals",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DealsEvents_DealId",
                schema: "dbo",
                table: "TBL_DealsEvents",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Directors_CompanyId",
                schema: "dbo",
                table: "TBL_Directors",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Directors_DirectorAcctLogPwdId",
                schema: "dbo",
                table: "TBL_Directors",
                column: "DirectorAcctLogPwdId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Managers_CompanyId",
                schema: "dbo",
                table: "TBL_Managers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Managers_ManagerAcctLogPwdId",
                schema: "dbo",
                table: "TBL_Managers",
                column: "ManagerAcctLogPwdId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_ClientsNotations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TBL_DealsEvents",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TBL_Directors",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TBL_Deals",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TBL_DirectorsAcctsLogsPwds",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TBL_Clients",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TBL_DealStatuses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TBL_Managers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TBL_Companies",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TBL_ManagersAcctsLogsPwds",
                schema: "dbo");
        }
    }
}
