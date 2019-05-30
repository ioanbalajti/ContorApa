﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContorApa.Migrations
{
    public partial class DateAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataInregistrarii",
                table: "ContorIndexes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataInregistrarii",
                table: "ContorIndexes");
        }
    }
}
