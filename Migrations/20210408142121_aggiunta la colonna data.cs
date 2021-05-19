using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Busi.Alessandro._5H.SecondaWeb.Migrations
{
    public partial class aggiuntalacolonnadata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataPrenotazione",
                table: "Prenotazioni",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PrenotazioneId",
                table: "Prenotazioni",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPrenotazione",
                table: "Prenotazioni");

            migrationBuilder.DropColumn(
                name: "PrenotazioneId",
                table: "Prenotazioni");
        }
    }
}
