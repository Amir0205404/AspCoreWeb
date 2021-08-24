﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class fvhilvhuirhvlidrhvgy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FiasStatments",
                columns: table => new
                {
                    FiasStatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActStatus = table.Column<int>(type: "int", nullable: false),
                    FiasGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CurrStatus = table.Column<int>(type: "int", nullable: false),
                    AdressName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    NextId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrevId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShortTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiasStatments", x => x.FiasStatmentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FiasStatments",
                columns: table => new
                {
                    FiasStatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActStatus = table.Column<int>(type: "int", nullable: false),
                    FiasGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CurrStatus = table.Column<int>(type: "int", nullable: false),
                    AdressName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    NextId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrevId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShortTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiasStatments", x => x.FiasStatmentId);
                });
        }
    }
}
