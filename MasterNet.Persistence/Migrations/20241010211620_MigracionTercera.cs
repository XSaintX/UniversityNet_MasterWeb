using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionTercera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89");

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

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "RoleId",
                value: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "RoleId",
                value: "f5345073-cd2b-43f2-990f-9c7ad2304510");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "RoleId",
                value: "f5345073-cd2b-43f2-990f-9c7ad2304510");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "RoleId",
                value: "f5345073-cd2b-43f2-990f-9c7ad2304510");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "RoleId",
                value: "f5345073-cd2b-43f2-990f-9c7ad2304510");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "668ebeff-21a5-42c5-8b65-df999ae4fcd6", null, "XSaint", "ADMIN" },
                    { "f5345073-cd2b-43f2-990f-9c7ad2304510", null, "CLIENT", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("0e99118f-4595-4735-9135-24d97b9d5668"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 10, 10, 21, 16, 20, 387, DateTimeKind.Utc).AddTicks(358), "Fantastic Concrete Shirt" },
                    { new Guid("192e805d-ea6e-4e3a-b3a6-3b376628e3be"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 10, 10, 21, 16, 20, 387, DateTimeKind.Utc).AddTicks(342), "Unbranded Soft Chair" },
                    { new Guid("472f2faf-cb6e-49d7-a4fc-e3294eb180ee"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 10, 10, 21, 16, 20, 387, DateTimeKind.Utc).AddTicks(241), "Sleek Fresh Shoes" },
                    { new Guid("4fe9a603-2930-4561-957e-04e260bed853"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 10, 10, 21, 16, 20, 387, DateTimeKind.Utc).AddTicks(402), "Gorgeous Rubber Chair" },
                    { new Guid("6a28db2a-d20a-4c16-a1cf-0424359d9554"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 10, 10, 21, 16, 20, 387, DateTimeKind.Utc).AddTicks(428), "Practical Soft Chair" },
                    { new Guid("ccd12c04-10f4-4623-a1e2-443bbde07371"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 10, 10, 21, 16, 20, 387, DateTimeKind.Utc).AddTicks(377), "Handmade Metal Chips" },
                    { new Guid("d6335071-ae9d-4df2-bc2f-c6d3f05be1f6"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 10, 10, 21, 16, 20, 387, DateTimeKind.Utc).AddTicks(303), "Ergonomic Cotton Fish" },
                    { new Guid("d8315941-f6a5-4501-9faa-cb4986b2d67f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 10, 10, 21, 16, 20, 387, DateTimeKind.Utc).AddTicks(323), "Incredible Steel Chair" },
                    { new Guid("d8e905c7-a33a-4f19-856d-dae9c6e42e08"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 10, 10, 21, 16, 20, 387, DateTimeKind.Utc).AddTicks(417), "Awesome Steel Salad" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("11f24ad9-84d3-4ef8-a6e8-dfb5a3ce154e"), "Ruecker", "Legacy Group Strategist", "Woodrow" },
                    { new Guid("27e12b72-88dd-4396-8713-e9413ad9a2e5"), "Bartoletti", "Senior Division Director", "Nona" },
                    { new Guid("3ec7d79f-3a09-4845-be6c-873e5ba0d968"), "Hauck", "Chief Paradigm Architect", "William" },
                    { new Guid("6e62f633-097d-45e6-bebe-ec4ef54f0bc4"), "Okuneva", "Human Identity Associate", "Patrick" },
                    { new Guid("9267dcd0-0e37-4b00-8531-80e3c5eaacd5"), "Hintz", "Investor Metrics Designer", "Katharina" },
                    { new Guid("a0f7d318-1055-4f79-a812-e0ccbc1bdb41"), "Emmerich", "Future Metrics Specialist", "Aniyah" },
                    { new Guid("a9a3844a-80d6-442a-b3d0-131f94e70285"), "Schneider", "District Directives Agent", "Ellis" },
                    { new Guid("c5ff06cf-af87-44a7-b8f8-89d676a30693"), "Jakubowski", "Principal Assurance Strategist", "Rupert" },
                    { new Guid("ef48f945-6cff-4480-a1f6-594f13410604"), "Rosenbaum", "Chief Tactics Facilitator", "Camila" },
                    { new Guid("ff8f23b4-819b-45f5-b23c-280037923dc9"), "Mills", "Central Optimization Technician", "Pasquale" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("ebe18ad1-fdc0-406d-9482-c342e765e004"), "Precio Regular", 10.0m, 8.0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "668ebeff-21a5-42c5-8b65-df999ae4fcd6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5345073-cd2b-43f2-990f-9c7ad2304510");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("0e99118f-4595-4735-9135-24d97b9d5668"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("192e805d-ea6e-4e3a-b3a6-3b376628e3be"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("472f2faf-cb6e-49d7-a4fc-e3294eb180ee"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("4fe9a603-2930-4561-957e-04e260bed853"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6a28db2a-d20a-4c16-a1cf-0424359d9554"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ccd12c04-10f4-4623-a1e2-443bbde07371"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("d6335071-ae9d-4df2-bc2f-c6d3f05be1f6"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("d8315941-f6a5-4501-9faa-cb4986b2d67f"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("d8e905c7-a33a-4f19-856d-dae9c6e42e08"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("11f24ad9-84d3-4ef8-a6e8-dfb5a3ce154e"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("27e12b72-88dd-4396-8713-e9413ad9a2e5"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3ec7d79f-3a09-4845-be6c-873e5ba0d968"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("6e62f633-097d-45e6-bebe-ec4ef54f0bc4"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("9267dcd0-0e37-4b00-8531-80e3c5eaacd5"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("a0f7d318-1055-4f79-a812-e0ccbc1bdb41"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("a9a3844a-80d6-442a-b3d0-131f94e70285"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("c5ff06cf-af87-44a7-b8f8-89d676a30693"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("ef48f945-6cff-4480-a1f6-594f13410604"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("ff8f23b4-819b-45f5-b23c-280037923dc9"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("ebe18ad1-fdc0-406d-9482-c342e765e004"));

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "RoleId",
                value: "01940f86-4516-4a95-80c6-9463598f91a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "RoleId",
                value: "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "RoleId",
                value: "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "RoleId",
                value: "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "RoleId",
                value: "4a388092-fbdd-46ee-9cdc-2e73a1bd9b89");

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
        }
    }
}
