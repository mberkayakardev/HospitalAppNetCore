using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkarSoftware.HospitalApp.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RootMenusId = table.Column<int>(type: "int", nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuDesctiption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppModulesId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMenus_AppMenus_RootMenusId",
                        column: x => x.RootMenusId,
                        principalTable: "AppMenus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppMenus_AppModules_AppModulesId",
                        column: x => x.AppModulesId,
                        principalTable: "AppModules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwoFactorAuth = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    EmailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAdressConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    GendersId = table.Column<int>(type: "int", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserMailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BornDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_Genders_GendersId",
                        column: x => x.GendersId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRolesMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppRoleId = table.Column<int>(type: "int", nullable: false),
                    AppRolesId = table.Column<int>(type: "int", nullable: false),
                    AppMenusId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRolesMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRolesMenus_AppMenus_AppMenusId",
                        column: x => x.AppMenusId,
                        principalTable: "AppMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRolesMenus_AppRoles_AppRolesId",
                        column: x => x.AppRolesId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppRoles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppModules",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "CreatedUserId", "Description", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8381), "APP", 0, "Herkesin Gördüğü Tanıtım Sayfası İçeriklerini içermektedir ", true, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8382), 0, "APP", "Landing" },
                    { 2, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8384), "APP", 0, "Bilgi İşlem Direktörlüğü ve Şirket sahiplerinin erişebildiği bir Modül ", true, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8384), 0, "APP", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "CreatedUserId", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8483), "APP", 0, true, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8484), 0, "APP", "Erkek" },
                    { 2, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8486), "APP", 0, true, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8487), 0, "APP", "Kadın" },
                    { 3, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8488), "APP", 0, true, new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8489), 0, "APP", "Belirtmek İstemiyor" }
                });

            migrationBuilder.InsertData(
                table: "AppMenus",
                columns: new[] { "Id", "ActionName", "ActionParameters", "AppModulesId", "AreaName", "ControllerName", "CreatedDate", "CreatedUser", "CreatedUserId", "IconName", "IsActive", "MenuDesctiption", "MenuName", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RootMenusId" },
                values: new object[,]
                {
                    { 1, "Randevu Al", "", 1, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8172), "APP", 0, "Randevu Al", true, "Randevu Al", "Randevu Al", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8186), 0, "APP", null },
                    { 2, "Kurumsal", "", 1, "Kurumsal", "Kurumsal", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8189), "APP", 0, "Kurumsal", true, "", "Kurumsal", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8189), 0, "APP", null },
                    { 7, "Sonuçlar", "", 1, "Sonuçlar", "Sonuçlar", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8203), "APP", 0, "Sonuçlar", true, "", "Sonuçlar", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8203), 0, "APP", null },
                    { 10, "Doktorlar", "", 1, "Doktorlar", "Doktorlar", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8211), "APP", 0, "Doktorlar", true, "", "Doktorlar", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8211), 0, "APP", null },
                    { 3, "Hakkımızda", "", 1, "Hakkımızda", "Hakkımızda", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8192), "APP", 0, "Hakkımızda", true, "", "Hakkımızda", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8192), 0, "APP", 2 },
                    { 8, "Reçete", "", 1, "Reçete", "Reçete", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8205), "APP", 0, "Reçete", true, "", "Reçete", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8206), 0, "APP", 7 },
                    { 9, "Tahlil", "", 1, "Tahlil ", "Tahlil", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8208), "APP", 0, "Tahlil", true, "", "Tahlil", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8209), 0, "APP", 7 },
                    { 4, "Misyon", "", 1, "Misyon", "Misyon", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8194), "APP", 0, "Misyon", true, "", "Misyon", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8195), 0, "APP", 3 },
                    { 5, "Vizyon", "", 1, "Vizyon", "Vizyon", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8197), "APP", 0, "Vizyon", true, "", "Vizyon", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8198), 0, "APP", 3 },
                    { 6, "Kariyer", "", 1, "Kariyer", "Kariyer", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8200), "APP", 0, "Kariyer", true, "", "Kariyer", new DateTime(2024, 4, 6, 23, 33, 24, 916, DateTimeKind.Local).AddTicks(8201), 0, "APP", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppMenus_AppModulesId",
                table: "AppMenus",
                column: "AppModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMenus_RootMenusId",
                table: "AppMenus",
                column: "RootMenusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRolesMenus_AppMenusId",
                table: "AppRolesMenus",
                column: "AppMenusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRolesMenus_AppRolesId",
                table: "AppRolesMenus",
                column: "AppRolesId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_GendersId",
                table: "AppUser",
                column: "GendersId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_AppUserId",
                table: "AppUserRoles",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_RolesId",
                table: "AppUserRoles",
                column: "RolesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRolesMenus");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppMenus");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "AppModules");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
