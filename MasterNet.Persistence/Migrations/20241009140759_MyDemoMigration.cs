using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MyDemoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "precios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    PrecioActual = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    PrecioPromocion = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "calificaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Alumno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puntaje = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_calificaciones_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagenes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagenes_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_instructores",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstructorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_instructores", x => new { x.InstructorId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_instructores_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_instructores_instructores_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_precios",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrecioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_precios", x => new { x.PrecioId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_precios_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_precios_precios_PrecioId",
                        column: x => x.PrecioId,
                        principalTable: "precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("0fbe5196-858c-41d9-ba84-525f7026a38b"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 10, 9, 14, 7, 59, 231, DateTimeKind.Utc).AddTicks(5370), "Refined Plastic Salad" },
                    { new Guid("1ae45d9b-983e-4516-a80c-ae6f192cc9d9"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 10, 9, 14, 7, 59, 231, DateTimeKind.Utc).AddTicks(5255), "Handcrafted Steel Bike" },
                    { new Guid("306dda49-ed91-431b-9912-293f6d69ad61"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 10, 9, 14, 7, 59, 231, DateTimeKind.Utc).AddTicks(5389), "Practical Soft Soap" },
                    { new Guid("5a85d4e0-9f43-45af-9574-f3a49bea3e6b"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 10, 9, 14, 7, 59, 231, DateTimeKind.Utc).AddTicks(5297), "Unbranded Steel Hat" },
                    { new Guid("7a63c6cd-c05b-47f4-98c0-bcc5a0241aa7"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 10, 9, 14, 7, 59, 231, DateTimeKind.Utc).AddTicks(5357), "Rustic Steel Chicken" },
                    { new Guid("c6ea28f4-086c-4a22-bed7-60a0a101d917"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 10, 9, 14, 7, 59, 231, DateTimeKind.Utc).AddTicks(5344), "Licensed Steel Keyboard" },
                    { new Guid("caf24155-388f-4767-990d-e14d1120a7c7"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 10, 9, 14, 7, 59, 231, DateTimeKind.Utc).AddTicks(5315), "Sleek Soft Computer" },
                    { new Guid("daf2e454-3a8a-454c-bbf0-8742d1e96e33"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 10, 9, 14, 7, 59, 231, DateTimeKind.Utc).AddTicks(5326), "Incredible Fresh Car" },
                    { new Guid("f4418871-f1d9-4f7b-b849-0612f7c7c06f"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 10, 9, 14, 7, 59, 231, DateTimeKind.Utc).AddTicks(5380), "Handmade Rubber Shoes" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("3cac74c6-05de-4db6-9a43-73efc77078ba"), "Nicolas", "International Mobility Planner", "Fern" },
                    { new Guid("74ea0a22-32f9-44df-9ef5-24c12f45f222"), "Mayert", "Internal Branding Orchestrator", "Roslyn" },
                    { new Guid("904f06ce-c7d6-4f4d-9993-798ba74be36f"), "Stiedemann", "Investor Operations Producer", "Jonathan" },
                    { new Guid("9906fec2-bdb3-4613-a7ec-15b59bb459b4"), "Lakin", "Regional Usability Developer", "Broderick" },
                    { new Guid("a31521d6-99d1-4601-a621-fd4cf5222c78"), "Lueilwitz", "Human Program Architect", "Marjory" },
                    { new Guid("aad9cc2f-3bfa-423a-8c57-f6fd41f57b12"), "Heidenreich", "Human Functionality Representative", "Layne" },
                    { new Guid("b7aa3784-1174-4a78-b276-8ba294eaa672"), "Wolf", "Corporate Division Specialist", "Parker" },
                    { new Guid("d2a93d0d-074e-44e4-94c0-51fe7599302f"), "Cassin", "Future Interactions Assistant", "Ferne" },
                    { new Guid("de241b60-f688-4595-a9be-f4c8426e2d5a"), "Predovic", "Direct Research Strategist", "Eric" },
                    { new Guid("f7e733f2-8818-4fe8-9b55-ff4f2262bc97"), "Koch", "Regional Applications Developer", "Marcelle" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("9ca4b411-3acc-4c95-b628-d12f052c7d78"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.CreateIndex(
                name: "IX_calificaciones_CursoId",
                table: "calificaciones",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_instructores_CursoId",
                table: "cursos_instructores",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_precios_CursoId",
                table: "cursos_precios",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_imagenes_CursoId",
                table: "imagenes",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calificaciones");

            migrationBuilder.DropTable(
                name: "cursos_instructores");

            migrationBuilder.DropTable(
                name: "cursos_precios");

            migrationBuilder.DropTable(
                name: "imagenes");

            migrationBuilder.DropTable(
                name: "instructores");

            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
