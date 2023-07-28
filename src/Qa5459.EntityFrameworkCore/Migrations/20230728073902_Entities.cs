using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qa5459.Migrations
{
    /// <inheritdoc />
    public partial class Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppParentEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppParentEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppChildEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppChildEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppChildEntities_AppParentEntities_ParentEntityId",
                        column: x => x.ParentEntityId,
                        principalTable: "AppParentEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppChildEntities_ParentEntityId",
                table: "AppChildEntities",
                column: "ParentEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppChildEntities");

            migrationBuilder.DropTable(
                name: "AppParentEntities");
        }
    }
}
