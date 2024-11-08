using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionSeguridad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("0fbe5196-858c-41d9-ba84-525f7026a38b"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("1ae45d9b-983e-4516-a80c-ae6f192cc9d9"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("306dda49-ed91-431b-9912-293f6d69ad61"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("5a85d4e0-9f43-45af-9574-f3a49bea3e6b"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("7a63c6cd-c05b-47f4-98c0-bcc5a0241aa7"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("c6ea28f4-086c-4a22-bed7-60a0a101d917"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("caf24155-388f-4767-990d-e14d1120a7c7"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("daf2e454-3a8a-454c-bbf0-8742d1e96e33"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("f4418871-f1d9-4f7b-b849-0612f7c7c06f"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3cac74c6-05de-4db6-9a43-73efc77078ba"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("74ea0a22-32f9-44df-9ef5-24c12f45f222"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("904f06ce-c7d6-4f4d-9993-798ba74be36f"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("9906fec2-bdb3-4613-a7ec-15b59bb459b4"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("a31521d6-99d1-4601-a621-fd4cf5222c78"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("aad9cc2f-3bfa-423a-8c57-f6fd41f57b12"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b7aa3784-1174-4a78-b276-8ba294eaa672"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("d2a93d0d-074e-44e4-94c0-51fe7599302f"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("de241b60-f688-4595-a9be-f4c8426e2d5a"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("f7e733f2-8818-4fe8-9b55-ff4f2262bc97"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("9ca4b411-3acc-4c95-b628-d12f052c7d78"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01940f86-4516-4a95-80c6-9463598f91a7", null, "XSaint", "ADMIN" },
                    { "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89", null, "CLIENT", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("0da79c18-c9a6-4306-aebd-87b11e2c0619"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 10, 9, 20, 12, 29, 799, DateTimeKind.Utc).AddTicks(595), "Licensed Concrete Gloves" },
                    { new Guid("195f755d-4a8c-4e7b-8465-bf05fd7f107f"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 10, 9, 20, 12, 29, 799, DateTimeKind.Utc).AddTicks(700), "Sleek Steel Chair" },
                    { new Guid("2330aad8-3408-4510-95c3-4209fd7cf945"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 10, 9, 20, 12, 29, 799, DateTimeKind.Utc).AddTicks(630), "Practical Cotton Pants" },
                    { new Guid("2f856e62-1f82-4471-924e-827db48ede33"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 10, 9, 20, 12, 29, 799, DateTimeKind.Utc).AddTicks(662), "Awesome Fresh Bike" },
                    { new Guid("7627d119-637d-4498-bb53-06e381a1384b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 10, 9, 20, 12, 29, 799, DateTimeKind.Utc).AddTicks(616), "Intelligent Granite Gloves" },
                    { new Guid("91906bd7-cc8a-48c2-9e54-b3d2d09b1ced"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 10, 9, 20, 12, 29, 799, DateTimeKind.Utc).AddTicks(711), "Licensed Concrete Chair" },
                    { new Guid("9bc898ba-4113-411e-99c3-6c4836f7522a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 10, 9, 20, 12, 29, 799, DateTimeKind.Utc).AddTicks(723), "Incredible Fresh Pants" },
                    { new Guid("ec775abd-06d4-4c88-9820-444aeb6429c1"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 10, 9, 20, 12, 29, 799, DateTimeKind.Utc).AddTicks(675), "Tasty Rubber Pants" },
                    { new Guid("f745677b-2a9d-490b-88ce-7ff6449c034f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 10, 9, 20, 12, 29, 799, DateTimeKind.Utc).AddTicks(649), "Awesome Cotton Pizza" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0404c51c-8663-4747-94dd-99925ff8622e"), "Herzog", "Forward Intranet Director", "Jaylon" },
                    { new Guid("08c50a4a-0707-422c-a358-164e10d26c3c"), "Zieme", "Future Applications Manager", "Dora" },
                    { new Guid("08e9543d-00cc-4f02-a554-2b46e5d435c5"), "Goodwin", "Forward Branding Manager", "Alison" },
                    { new Guid("162bceea-4738-4ce7-9196-99b5606050fc"), "Waelchi", "Investor Implementation Technician", "Chris" },
                    { new Guid("2b2d05ed-d62d-4382-b259-2bd59b11016b"), "Quigley", "Regional Functionality Specialist", "Marcelo" },
                    { new Guid("2fbcf94d-3e73-4ce2-9af6-6f7cf147395d"), "Bosco", "Internal Tactics Director", "Reta" },
                    { new Guid("561a1c56-da55-4bcd-8d72-70a024de3c42"), "Treutel", "Corporate Metrics Engineer", "Armand" },
                    { new Guid("60ce7d49-4204-4636-88e7-11900335f606"), "Hintz", "International Data Liaison", "Justine" },
                    { new Guid("6c0fad22-3ee7-47ad-8fd0-05771ba16085"), "Brown", "Lead Operations Orchestrator", "Kasey" },
                    { new Guid("f8476d51-745d-4c44-8786-3591ca510ecc"), "Wiza", "Future Division Supervisor", "Joanie" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("7b0abc40-d492-47ff-8e6b-3b8d1b93ed2c"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 2, "POLICIES", "CURSO_UPDATE", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 3, "POLICIES", "CURSO_WRITE", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 4, "POLICIES", "CURSO_DELETE", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 8, "POLICIES", "COMENTARIO_READ", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "01940f86-4516-4a95-80c6-9463598f91a7" },
                    { 11, "POLICIES", "CURSO_READ", "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89" },
                    { 13, "POLICIES", "COMENTARIO_READ", "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("0da79c18-c9a6-4306-aebd-87b11e2c0619"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("195f755d-4a8c-4e7b-8465-bf05fd7f107f"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("2330aad8-3408-4510-95c3-4209fd7cf945"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("2f856e62-1f82-4471-924e-827db48ede33"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("7627d119-637d-4498-bb53-06e381a1384b"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("91906bd7-cc8a-48c2-9e54-b3d2d09b1ced"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("9bc898ba-4113-411e-99c3-6c4836f7522a"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ec775abd-06d4-4c88-9820-444aeb6429c1"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("f745677b-2a9d-490b-88ce-7ff6449c034f"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("0404c51c-8663-4747-94dd-99925ff8622e"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("08c50a4a-0707-422c-a358-164e10d26c3c"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("08e9543d-00cc-4f02-a554-2b46e5d435c5"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("162bceea-4738-4ce7-9196-99b5606050fc"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("2b2d05ed-d62d-4382-b259-2bd59b11016b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("2fbcf94d-3e73-4ce2-9af6-6f7cf147395d"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("561a1c56-da55-4bcd-8d72-70a024de3c42"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("60ce7d49-4204-4636-88e7-11900335f606"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("6c0fad22-3ee7-47ad-8fd0-05771ba16085"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("f8476d51-745d-4c44-8786-3591ca510ecc"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("7b0abc40-d492-47ff-8e6b-3b8d1b93ed2c"));

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
        }
    }
}
