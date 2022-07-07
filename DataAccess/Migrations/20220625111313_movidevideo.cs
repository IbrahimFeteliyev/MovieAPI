﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class movidevideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Casts_CastId",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "CastId",
                table: "Movies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "MovieVideos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieVideos_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieVideos_MovieId",
                table: "MovieVideos",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Casts_CastId",
                table: "Movies",
                column: "CastId",
                principalTable: "Casts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Casts_CastId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "MovieVideos");

            migrationBuilder.AlterColumn<int>(
                name: "CastId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Casts_CastId",
                table: "Movies",
                column: "CastId",
                principalTable: "Casts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
