using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportSystem.Migrations
{
    /// <inheritdoc />
    public partial class applicationuserroleid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("05d4a8ae-6681-4724-94d8-85f64207b2be"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("0fa5891b-5945-41d6-bb08-142fab15fcfa"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("10795dc7-adb3-4845-9aee-a2920c48eedc"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13070321-0179-4839-ad6e-649b5ae893b3"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("2649ca81-571f-4e76-81dc-5e5d8c1353bb"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("293d4fde-8593-4f0f-8732-0661b28a54e7"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("4b018c63-246c-438f-80d9-f24b15589522"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("600ed060-221a-4590-8ab6-bc399bac1002"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6d8ff10f-40b2-454b-996a-ed00a837a64c"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6f76b46b-1d75-46d5-83af-58d7a40e93a8"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ab0d0068-9385-4dcf-81ce-ac38dfc2203c"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ab3e6c09-fdd3-44b8-b55e-7e1254d51bf9"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("b0eb3655-876b-4a2c-a413-9b0f521c2da7"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d921f2b2-5044-48b5-9d17-d5ddd1035c86"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e80b8ca4-a81e-4068-811a-5ab18c6e1ca5"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("fa3b9052-cddc-41a6-9d60-7674e6409769"));

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserRoleId",
                schema: "Identity",
                table: "IdentityUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Locations",
                columns: new[] { "Id", "City", "Country", "PostalCode", "State", "Street", "StreetNumber", "Surface" },
                values: new object[,]
                {
                    { new Guid("33cd111b-ebe1-40d8-98ad-dd51436c5743"), "Białystok", "Polska", 15222, "Podlaskie", "Dąbrowskiego", 15, 0 },
                    { new Guid("37443906-616e-4cd5-95ea-19d4fdf8e420"), "Białystok", "Polska", 33333, "Podlaskie", "Piękna", 16, 1 },
                    { new Guid("401e3dbe-cb25-452e-ac16-eaa7f83efd82"), "Białystok", "Polska", 44444, "Podlaskie", "Zachodnia", 5, 0 },
                    { new Guid("4857e092-8e3e-4b03-9b03-e3583c91908e"), "Białystok", "Polska", 99999, "Podlaskie", "Kamienna", 25, 1 },
                    { new Guid("533bd042-bb1a-42bb-8526-64f1d5a8503b"), "Białystok", "Polska", 101010, "Podlaskie", "Żytnia", 12, 0 },
                    { new Guid("5b1f8e85-aa14-4b46-9c13-39820dafeb6e"), "Białystok", "Polska", 22222, "Podlaskie", "Słoneczna", 33, 0 },
                    { new Guid("6c8a364a-8914-4bde-9bce-9414dfb1324b"), "Białystok", "Polska", 154777, "Podlaskie", "Piotrkowska", 28, 1 },
                    { new Guid("6ebdf02c-8b6c-41e2-9573-3988fbf80a09"), "Białystok", "Polska", 11111, "Podlaskie", "Kwiatowa", 11, 1 },
                    { new Guid("7ea999dc-8b6e-4b85-a2d5-d4dce4b2e3f2"), "Białystok", "Polska", 55555, "Podlaskie", "Akacjowa", 22, 1 },
                    { new Guid("8c43e9c9-bd5b-45dc-bc89-1529e7fe843b"), "Białystok", "Polska", 54321, "Podlaskie", "Mazurska", 47, 1 },
                    { new Guid("966af0f1-6fb0-436f-8bd3-657fd113022e"), "Białystok", "Polska", 111111, "Podlaskie", "Łąkowa", 31, 1 },
                    { new Guid("c0a3ab6d-76ec-4569-b500-ab52a41fb161"), "Białystok", "Polska", 77777, "Podlaskie", "Nadrzeczna", 39, 1 },
                    { new Guid("c18bc5fa-fea3-477f-a553-c95ea2dd83dd"), "Białystok", "Polska", 67890, "Podlaskie", "Grunwaldzka", 82, 0 },
                    { new Guid("ca165a98-a0e1-4ed4-8df3-c65bf8279e19"), "Białystok", "Polska", 66666, "Podlaskie", "Klonowa", 18, 0 },
                    { new Guid("d6386985-f0d9-49c4-bd5a-37e30752010e"), "Białystok", "Polska", 12345, "Podlaskie", "Zielona", 9, 0 },
                    { new Guid("f7ba5d45-10f8-41a1-afef-4502b4891ad1"), "Białystok", "Polska", 88888, "Podlaskie", "Topolowa", 7, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("33cd111b-ebe1-40d8-98ad-dd51436c5743"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("37443906-616e-4cd5-95ea-19d4fdf8e420"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("401e3dbe-cb25-452e-ac16-eaa7f83efd82"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("4857e092-8e3e-4b03-9b03-e3583c91908e"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("533bd042-bb1a-42bb-8526-64f1d5a8503b"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("5b1f8e85-aa14-4b46-9c13-39820dafeb6e"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6c8a364a-8914-4bde-9bce-9414dfb1324b"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6ebdf02c-8b6c-41e2-9573-3988fbf80a09"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("7ea999dc-8b6e-4b85-a2d5-d4dce4b2e3f2"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("8c43e9c9-bd5b-45dc-bc89-1529e7fe843b"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("966af0f1-6fb0-436f-8bd3-657fd113022e"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c0a3ab6d-76ec-4569-b500-ab52a41fb161"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c18bc5fa-fea3-477f-a553-c95ea2dd83dd"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ca165a98-a0e1-4ed4-8df3-c65bf8279e19"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d6386985-f0d9-49c4-bd5a-37e30752010e"));

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("f7ba5d45-10f8-41a1-afef-4502b4891ad1"));

            migrationBuilder.DropColumn(
                name: "ApplicationUserRoleId",
                schema: "Identity",
                table: "IdentityUsers");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Locations",
                columns: new[] { "Id", "City", "Country", "PostalCode", "State", "Street", "StreetNumber", "Surface" },
                values: new object[,]
                {
                    { new Guid("05d4a8ae-6681-4724-94d8-85f64207b2be"), "Białystok", "Polska", 154777, "Podlaskie", "Piotrkowska", 28, 1 },
                    { new Guid("0fa5891b-5945-41d6-bb08-142fab15fcfa"), "Białystok", "Polska", 67890, "Podlaskie", "Grunwaldzka", 82, 0 },
                    { new Guid("10795dc7-adb3-4845-9aee-a2920c48eedc"), "Białystok", "Polska", 22222, "Podlaskie", "Słoneczna", 33, 0 },
                    { new Guid("13070321-0179-4839-ad6e-649b5ae893b3"), "Białystok", "Polska", 77777, "Podlaskie", "Nadrzeczna", 39, 1 },
                    { new Guid("2649ca81-571f-4e76-81dc-5e5d8c1353bb"), "Białystok", "Polska", 33333, "Podlaskie", "Piękna", 16, 1 },
                    { new Guid("293d4fde-8593-4f0f-8732-0661b28a54e7"), "Białystok", "Polska", 88888, "Podlaskie", "Topolowa", 7, 0 },
                    { new Guid("4b018c63-246c-438f-80d9-f24b15589522"), "Białystok", "Polska", 101010, "Podlaskie", "Żytnia", 12, 0 },
                    { new Guid("600ed060-221a-4590-8ab6-bc399bac1002"), "Białystok", "Polska", 111111, "Podlaskie", "Łąkowa", 31, 1 },
                    { new Guid("6d8ff10f-40b2-454b-996a-ed00a837a64c"), "Białystok", "Polska", 66666, "Podlaskie", "Klonowa", 18, 0 },
                    { new Guid("6f76b46b-1d75-46d5-83af-58d7a40e93a8"), "Białystok", "Polska", 55555, "Podlaskie", "Akacjowa", 22, 1 },
                    { new Guid("ab0d0068-9385-4dcf-81ce-ac38dfc2203c"), "Białystok", "Polska", 15222, "Podlaskie", "Dąbrowskiego", 15, 0 },
                    { new Guid("ab3e6c09-fdd3-44b8-b55e-7e1254d51bf9"), "Białystok", "Polska", 44444, "Podlaskie", "Zachodnia", 5, 0 },
                    { new Guid("b0eb3655-876b-4a2c-a413-9b0f521c2da7"), "Białystok", "Polska", 54321, "Podlaskie", "Mazurska", 47, 1 },
                    { new Guid("d921f2b2-5044-48b5-9d17-d5ddd1035c86"), "Białystok", "Polska", 12345, "Podlaskie", "Zielona", 9, 0 },
                    { new Guid("e80b8ca4-a81e-4068-811a-5ab18c6e1ca5"), "Białystok", "Polska", 11111, "Podlaskie", "Kwiatowa", 11, 1 },
                    { new Guid("fa3b9052-cddc-41a6-9d60-7674e6409769"), "Białystok", "Polska", 99999, "Podlaskie", "Kamienna", 25, 1 }
                });
        }
    }
}
