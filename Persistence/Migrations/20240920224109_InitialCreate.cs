using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechnicsTest.GraphQL.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AuthorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    BookGenreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => x.BookGenreID);
                    table.ForeignKey(
                        name: "FK_BookGenres_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenres_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "LastName", "Name" },
                values: new object[,]
                {
                    { new Guid("0cf03f11-dc38-44e7-bc28-1c77a726db99"), "Bode", "Shaniya" },
                    { new Guid("0d47e3d7-6bcd-4875-8ce0-845a6e00ae64"), "Larson", "Josephine" },
                    { new Guid("22a3f9a7-0e73-4ecd-9abb-c94df5983062"), "Kub", "Jany" },
                    { new Guid("395ddc67-1ea7-4cfb-9ba1-51475f54d098"), "Lesch", "Rahsaan" },
                    { new Guid("e1b2b2c7-275f-43b0-badd-351ca0285737"), "Connelly", "Trenton" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Name" },
                values: new object[,]
                {
                    { new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5"), "Electronics" },
                    { new Guid("1d885ced-3b38-4345-8db9-b6515d8aed87"), "Outdoors" },
                    { new Guid("4b547d84-d249-497a-9f45-3b887b0cfefe"), "Garden" },
                    { new Guid("55dbb31b-00c1-4573-bae1-796883230a6a"), "Beauty" },
                    { new Guid("68f63252-534c-4b07-b092-b49001ab667d"), "Grocery" },
                    { new Guid("9b03337b-9fc0-4ed6-aa4c-56c5d8853372"), "Automotive" },
                    { new Guid("a887dffd-39b2-4719-800b-37307b8d37ed"), "Grocery" },
                    { new Guid("c3ce31ab-7f02-490d-a797-8a9fe1d92f45"), "Computers" },
                    { new Guid("f6121152-54a1-4109-9f55-572585ce513a"), "Computers" },
                    { new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde"), "Computers" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "Role" },
                values: new object[] { new Guid("6b67b8c0-fb73-46ea-9142-b8e0723df042"), "test1@example.com", "KingCris", "contraseña01", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "Description", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"), new Guid("0cf03f11-dc38-44e7-bc28-1c77a726db99"), "Reprehenderit molestiae non tenetur ipsum doloremque.\nDolores ipsum ut possimus molestias in.", new DateOnly(2011, 5, 26), "Officiis quo ab." },
                    { new Guid("2750ec46-70f7-4866-b5fd-3a4177fcca5a"), new Guid("e1b2b2c7-275f-43b0-badd-351ca0285737"), "Corporis repellendus id.\nQuos architecto alias fuga in ut voluptas.", new DateOnly(2022, 5, 18), "Maiores rem nihil." },
                    { new Guid("78c4455b-2984-422f-8fe6-cdf2937f3a9e"), new Guid("0d47e3d7-6bcd-4875-8ce0-845a6e00ae64"), "Autem quis eos inventore officiis.\nMolestiae et deleniti sed accusamus.", new DateOnly(2018, 9, 19), "Et placeat corrupti." },
                    { new Guid("7a55d2be-a1db-4c3c-b12a-bcab950a07c1"), new Guid("0cf03f11-dc38-44e7-bc28-1c77a726db99"), "Itaque facilis voluptatem eos animi aut voluptatem.\nEt delectus consequatur error saepe quis doloribus.", new DateOnly(2009, 7, 18), "A sunt non." },
                    { new Guid("7bf996e6-d026-4665-b4b1-037e78cd9855"), new Guid("0d47e3d7-6bcd-4875-8ce0-845a6e00ae64"), "Sed aspernatur nulla ea aliquam praesentium.\nQuia voluptatem eligendi explicabo ipsa debitis molestiae dolorum quae.", new DateOnly(2013, 4, 8), "Pariatur deserunt aut." },
                    { new Guid("847a73e7-d476-43b3-8424-a41154cef1d2"), new Guid("22a3f9a7-0e73-4ecd-9abb-c94df5983062"), "Dolorem aliquam voluptas architecto.\nVoluptatum esse nostrum.", new DateOnly(2006, 4, 5), "Omnis dolore ullam." },
                    { new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"), new Guid("22a3f9a7-0e73-4ecd-9abb-c94df5983062"), "Exercitationem aperiam consequatur voluptates doloremque illo libero non.\nLaboriosam aut ipsum dolores est.", new DateOnly(2024, 5, 24), "Dolor sunt et." },
                    { new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"), new Guid("22a3f9a7-0e73-4ecd-9abb-c94df5983062"), "Dolorem qui eum est asperiores consequatur.\nDolor vel voluptates occaecati iusto laboriosam.", new DateOnly(2018, 8, 6), "Iure rerum ullam." },
                    { new Guid("bbe8ebc4-2517-4ed3-a418-758c8f8b69e5"), new Guid("0d47e3d7-6bcd-4875-8ce0-845a6e00ae64"), "Expedita voluptatem consequatur et facere et adipisci repellendus.\nDolorem dolore voluptatem in est et.", new DateOnly(1999, 11, 3), "Illo nulla explicabo." },
                    { new Guid("c478d9e0-20df-48e2-8bd8-70389b3a132f"), new Guid("395ddc67-1ea7-4cfb-9ba1-51475f54d098"), "Consectetur maxime ea sit ut aut rem.\nAut deserunt itaque mollitia et voluptas voluptatem placeat repudiandae at.", new DateOnly(2007, 7, 16), "Veniam voluptatem explicabo." },
                    { new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"), new Guid("e1b2b2c7-275f-43b0-badd-351ca0285737"), "Est officiis est autem ut in.\nQuis est dolore sunt laudantium saepe.", new DateOnly(2022, 6, 6), "Earum fuga odio." }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookGenreID", "BookID", "GenreID" },
                values: new object[,]
                {
                    { new Guid("0231452d-12e7-4864-9789-0398817c42a9"), new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"), new Guid("a887dffd-39b2-4719-800b-37307b8d37ed") },
                    { new Guid("1380bb90-beb6-4fa5-a5a3-16d05231fd19"), new Guid("2750ec46-70f7-4866-b5fd-3a4177fcca5a"), new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5") },
                    { new Guid("34517cbf-897c-48ae-bfcc-8106083a2719"), new Guid("847a73e7-d476-43b3-8424-a41154cef1d2"), new Guid("68f63252-534c-4b07-b092-b49001ab667d") },
                    { new Guid("42334e55-405c-4726-ac2e-8deb471bcf45"), new Guid("2750ec46-70f7-4866-b5fd-3a4177fcca5a"), new Guid("68f63252-534c-4b07-b092-b49001ab667d") },
                    { new Guid("522d3bc9-76f6-482b-b460-792547f427c9"), new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"), new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde") },
                    { new Guid("53ac1d0e-293b-4f34-9efe-fd4d285a5fcd"), new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"), new Guid("4b547d84-d249-497a-9f45-3b887b0cfefe") },
                    { new Guid("5ca7c528-8b3e-443a-a92a-e9488c1bfd57"), new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"), new Guid("68f63252-534c-4b07-b092-b49001ab667d") },
                    { new Guid("674d39d0-3c5a-44e8-b742-83f088735798"), new Guid("bbe8ebc4-2517-4ed3-a418-758c8f8b69e5"), new Guid("a887dffd-39b2-4719-800b-37307b8d37ed") },
                    { new Guid("76871d19-0122-4fe4-90ad-f9fee31d8399"), new Guid("847a73e7-d476-43b3-8424-a41154cef1d2"), new Guid("68f63252-534c-4b07-b092-b49001ab667d") },
                    { new Guid("880bf0df-e78b-4150-9bab-64cbc8c66d9e"), new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"), new Guid("9b03337b-9fc0-4ed6-aa4c-56c5d8853372") },
                    { new Guid("90440b10-99a8-4d2f-abf6-a66085ec70c0"), new Guid("7a55d2be-a1db-4c3c-b12a-bcab950a07c1"), new Guid("f6121152-54a1-4109-9f55-572585ce513a") },
                    { new Guid("9f4479f0-c21e-44d7-86b2-afd0d041822b"), new Guid("bbe8ebc4-2517-4ed3-a418-758c8f8b69e5"), new Guid("1d885ced-3b38-4345-8db9-b6515d8aed87") },
                    { new Guid("a05da6a3-67e1-45dc-9027-83ea39a0558b"), new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"), new Guid("9b03337b-9fc0-4ed6-aa4c-56c5d8853372") },
                    { new Guid("a1c46f00-f455-4258-8113-2c3158845ea9"), new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"), new Guid("1d885ced-3b38-4345-8db9-b6515d8aed87") },
                    { new Guid("a4dfc962-43aa-4406-9fc0-bd312a5cd5ff"), new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"), new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde") },
                    { new Guid("ae7a7347-244a-4a6d-852c-0605f0e86775"), new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"), new Guid("55dbb31b-00c1-4573-bae1-796883230a6a") },
                    { new Guid("afe3316b-c3c6-4399-8545-cb5bafe22aa1"), new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"), new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde") },
                    { new Guid("b0930f53-4f6c-4c64-bea0-4dd781c6f6c8"), new Guid("847a73e7-d476-43b3-8424-a41154cef1d2"), new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5") },
                    { new Guid("b817c45f-56c9-4674-9e9a-3a98871dabf1"), new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"), new Guid("f6121152-54a1-4109-9f55-572585ce513a") },
                    { new Guid("c02dd986-d6eb-47d9-ae1b-20533546798b"), new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"), new Guid("f6121152-54a1-4109-9f55-572585ce513a") },
                    { new Guid("d82591e2-9fad-4f3f-8468-4423f0927769"), new Guid("7bf996e6-d026-4665-b4b1-037e78cd9855"), new Guid("f6121152-54a1-4109-9f55-572585ce513a") },
                    { new Guid("dafa196f-2c94-4957-8e9a-11d8d6e2de6d"), new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"), new Guid("1d885ced-3b38-4345-8db9-b6515d8aed87") },
                    { new Guid("df08daa4-86d8-4fc1-95cc-45b6de805e65"), new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"), new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde") },
                    { new Guid("edaa3021-a962-4536-8f7c-3049431aa19f"), new Guid("c478d9e0-20df-48e2-8bd8-70389b3a132f"), new Guid("55dbb31b-00c1-4573-bae1-796883230a6a") },
                    { new Guid("f29f26d1-9507-4175-bad9-b7deeca6a372"), new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"), new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5") },
                    { new Guid("f5c8d2a4-1c31-44d3-9e37-316afc8d14de"), new Guid("c478d9e0-20df-48e2-8bd8-70389b3a132f"), new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5") },
                    { new Guid("f61c2a56-55dd-454f-8dfd-b17637a2af17"), new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"), new Guid("a887dffd-39b2-4719-800b-37307b8d37ed") },
                    { new Guid("feee5d90-b7bb-4ea1-824a-fecbc00e7ad4"), new Guid("78c4455b-2984-422f-8fe6-cdf2937f3a9e"), new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_BookID",
                table: "BookGenres",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenreID",
                table: "BookGenres",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
