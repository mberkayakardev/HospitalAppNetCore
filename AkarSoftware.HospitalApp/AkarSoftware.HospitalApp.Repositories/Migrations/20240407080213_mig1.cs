using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkarSoftware.HospitalApp.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4073), new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.InsertData(
                table: "AppMenus",
                columns: new[] { "Id", "ActionName", "ActionParameters", "AppModulesId", "AreaName", "ControllerName", "CreatedDate", "CreatedUser", "CreatedUserId", "IconName", "IsActive", "MenuDesctiption", "MenuName", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RootMenusId" },
                values: new object[,]
                {
                    { 1001, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4090), "APP", 0, "Randevu Al", true, "Randevu Al", "Randevu Al 2 ", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4091), 0, "APP", 1 },
                    { 1002, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4093), "APP", 0, "Randevu Al", true, "Randevu Al", "Randevu Al 2 - 2 ", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4094), 0, "APP", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AppModules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4329), new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "AppModules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4331), new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.InsertData(
                table: "AppMenus",
                columns: new[] { "Id", "ActionName", "ActionParameters", "AppModulesId", "AreaName", "ControllerName", "CreatedDate", "CreatedUser", "CreatedUserId", "IconName", "IsActive", "MenuDesctiption", "MenuName", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RootMenusId" },
                values: new object[,]
                {
                    { 1003, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4096), "APP", 0, "Randevu Al", true, "Randevu Al", "Randevu Al 3 - 1  ", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4097), 0, "APP", 1002 },
                    { 1004, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4099), "APP", 0, "Randevu Al", true, "Randevu Al", "asdasdasd ", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4099), 0, "APP", 1002 },
                    { 1005, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4101), "APP", 0, "Randevu Al", true, "Randevu Al", "Randevu Al 3 - 2  ", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4102), 0, "APP", 1004 },
                    { 1006, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4104), "APP", 0, "Randevu Al", true, "Randevu Al", "Randevu 34534534  ", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4105), 0, "APP", 1004 },
                    { 1010, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4107), "APP", 0, "Randevu Al", true, "Randevu Al", "Randevu 234234234 ", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4108), 0, "APP", 1006 },
                    { 1020, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4110), "APP", 0, "Randevu Al", true, "Randevu Al", "Randevu Al 123123123  ", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4110), 0, "APP", 1010 },
                    { 1030, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4112), "APP", 0, "Randevu Al", true, "Randevu Al", "Randevu Al asdasdasd2  ", new DateTime(2024, 4, 7, 11, 2, 12, 154, DateTimeKind.Local).AddTicks(4113), 0, "APP", 1020 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8172), new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.InsertData(
                table: "AppMenus",
                columns: new[] { "Id", "ActionName", "ActionParameters", "AppModulesId", "AreaName", "ControllerName", "CreatedDate", "CreatedUser", "CreatedUserId", "IconName", "IsActive", "MenuDesctiption", "MenuName", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RootMenusId" },
                values: new object[,]
                {
                    { 2, "Kurumsal", "", 1, "Kurumsal", "Kurumsal", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8189), "APP", 0, "Kurumsal", true, "", "Kurumsal", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8189), 0, "APP", null },
                    { 7, "Sonuçlar", "", 1, "Sonuçlar", "Sonuçlar", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8203), "APP", 0, "Sonuçlar", true, "", "Sonuçlar", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8203), 0, "APP", null },
                    { 10, "Doktorlar", "", 1, "Doktorlar", "Doktorlar", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8211), "APP", 0, "Doktorlar", true, "", "Doktorlar", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8211), 0, "APP", null }
                });

            migrationBuilder.UpdateData(
                table: "AppModules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "AppModules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8483), new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8486), new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8488), new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.InsertData(
                table: "AppMenus",
                columns: new[] { "Id", "ActionName", "ActionParameters", "AppModulesId", "AreaName", "ControllerName", "CreatedDate", "CreatedUser", "CreatedUserId", "IconName", "IsActive", "MenuDesctiption", "MenuName", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RootMenusId" },
                values: new object[,]
                {
                    { 3, "Hakkımızda", "", 1, "Hakkımızda", "Hakkımızda", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8192), "APP", 0, "Hakkımızda", true, "", "Hakkımızda", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8192), 0, "APP", 2 },
                    { 8, "Reçete", "", 1, "Reçete", "Reçete", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8205), "APP", 0, "Reçete", true, "", "Reçete", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8206), 0, "APP", 7 },
                    { 9, "Tahlil", "", 1, "Tahlil ", "Tahlil", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8208), "APP", 0, "Tahlil", true, "", "Tahlil", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8209), 0, "APP", 7 },
                    { 4, "Misyon", "", 1, "Misyon", "Misyon", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8194), "APP", 0, "Misyon", true, "", "Misyon", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8195), 0, "APP", 3 },
                    { 5, "Vizyon", "", 1, "Vizyon", "Vizyon", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8197), "APP", 0, "Vizyon", true, "", "Vizyon", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8198), 0, "APP", 3 },
                    { 6, "Kariyer", "", 1, "Kariyer", "Kariyer", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8200), "APP", 0, "Kariyer", true, "", "Kariyer", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8201), 0, "APP", 3 }
                });
        }
    }
}
