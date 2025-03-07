﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechnicsTest.GraphQL.Persistence;

#nullable disable

namespace TechnicsTest.GraphQL.Persistence.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20240920224109_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.Author", b =>
                {
                    b.Property<Guid>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorID = new Guid("395ddc67-1ea7-4cfb-9ba1-51475f54d098"),
                            LastName = "Lesch",
                            Name = "Rahsaan"
                        },
                        new
                        {
                            AuthorID = new Guid("e1b2b2c7-275f-43b0-badd-351ca0285737"),
                            LastName = "Connelly",
                            Name = "Trenton"
                        },
                        new
                        {
                            AuthorID = new Guid("22a3f9a7-0e73-4ecd-9abb-c94df5983062"),
                            LastName = "Kub",
                            Name = "Jany"
                        },
                        new
                        {
                            AuthorID = new Guid("0cf03f11-dc38-44e7-bc28-1c77a726db99"),
                            LastName = "Bode",
                            Name = "Shaniya"
                        },
                        new
                        {
                            AuthorID = new Guid("0d47e3d7-6bcd-4875-8ce0-845a6e00ae64"),
                            LastName = "Larson",
                            Name = "Josephine"
                        });
                });

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.Book", b =>
                {
                    b.Property<Guid>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("PublishedDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("AuthorID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookID = new Guid("c478d9e0-20df-48e2-8bd8-70389b3a132f"),
                            AuthorID = new Guid("395ddc67-1ea7-4cfb-9ba1-51475f54d098"),
                            Description = "Consectetur maxime ea sit ut aut rem.\nAut deserunt itaque mollitia et voluptas voluptatem placeat repudiandae at.",
                            PublishedDate = new DateOnly(2007, 7, 16),
                            Title = "Veniam voluptatem explicabo."
                        },
                        new
                        {
                            BookID = new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"),
                            AuthorID = new Guid("e1b2b2c7-275f-43b0-badd-351ca0285737"),
                            Description = "Est officiis est autem ut in.\nQuis est dolore sunt laudantium saepe.",
                            PublishedDate = new DateOnly(2022, 6, 6),
                            Title = "Earum fuga odio."
                        },
                        new
                        {
                            BookID = new Guid("2750ec46-70f7-4866-b5fd-3a4177fcca5a"),
                            AuthorID = new Guid("e1b2b2c7-275f-43b0-badd-351ca0285737"),
                            Description = "Corporis repellendus id.\nQuos architecto alias fuga in ut voluptas.",
                            PublishedDate = new DateOnly(2022, 5, 18),
                            Title = "Maiores rem nihil."
                        },
                        new
                        {
                            BookID = new Guid("847a73e7-d476-43b3-8424-a41154cef1d2"),
                            AuthorID = new Guid("22a3f9a7-0e73-4ecd-9abb-c94df5983062"),
                            Description = "Dolorem aliquam voluptas architecto.\nVoluptatum esse nostrum.",
                            PublishedDate = new DateOnly(2006, 4, 5),
                            Title = "Omnis dolore ullam."
                        },
                        new
                        {
                            BookID = new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"),
                            AuthorID = new Guid("22a3f9a7-0e73-4ecd-9abb-c94df5983062"),
                            Description = "Exercitationem aperiam consequatur voluptates doloremque illo libero non.\nLaboriosam aut ipsum dolores est.",
                            PublishedDate = new DateOnly(2024, 5, 24),
                            Title = "Dolor sunt et."
                        },
                        new
                        {
                            BookID = new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"),
                            AuthorID = new Guid("22a3f9a7-0e73-4ecd-9abb-c94df5983062"),
                            Description = "Dolorem qui eum est asperiores consequatur.\nDolor vel voluptates occaecati iusto laboriosam.",
                            PublishedDate = new DateOnly(2018, 8, 6),
                            Title = "Iure rerum ullam."
                        },
                        new
                        {
                            BookID = new Guid("7a55d2be-a1db-4c3c-b12a-bcab950a07c1"),
                            AuthorID = new Guid("0cf03f11-dc38-44e7-bc28-1c77a726db99"),
                            Description = "Itaque facilis voluptatem eos animi aut voluptatem.\nEt delectus consequatur error saepe quis doloribus.",
                            PublishedDate = new DateOnly(2009, 7, 18),
                            Title = "A sunt non."
                        },
                        new
                        {
                            BookID = new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"),
                            AuthorID = new Guid("0cf03f11-dc38-44e7-bc28-1c77a726db99"),
                            Description = "Reprehenderit molestiae non tenetur ipsum doloremque.\nDolores ipsum ut possimus molestias in.",
                            PublishedDate = new DateOnly(2011, 5, 26),
                            Title = "Officiis quo ab."
                        },
                        new
                        {
                            BookID = new Guid("78c4455b-2984-422f-8fe6-cdf2937f3a9e"),
                            AuthorID = new Guid("0d47e3d7-6bcd-4875-8ce0-845a6e00ae64"),
                            Description = "Autem quis eos inventore officiis.\nMolestiae et deleniti sed accusamus.",
                            PublishedDate = new DateOnly(2018, 9, 19),
                            Title = "Et placeat corrupti."
                        },
                        new
                        {
                            BookID = new Guid("7bf996e6-d026-4665-b4b1-037e78cd9855"),
                            AuthorID = new Guid("0d47e3d7-6bcd-4875-8ce0-845a6e00ae64"),
                            Description = "Sed aspernatur nulla ea aliquam praesentium.\nQuia voluptatem eligendi explicabo ipsa debitis molestiae dolorum quae.",
                            PublishedDate = new DateOnly(2013, 4, 8),
                            Title = "Pariatur deserunt aut."
                        },
                        new
                        {
                            BookID = new Guid("bbe8ebc4-2517-4ed3-a418-758c8f8b69e5"),
                            AuthorID = new Guid("0d47e3d7-6bcd-4875-8ce0-845a6e00ae64"),
                            Description = "Expedita voluptatem consequatur et facere et adipisci repellendus.\nDolorem dolore voluptatem in est et.",
                            PublishedDate = new DateOnly(1999, 11, 3),
                            Title = "Illo nulla explicabo."
                        });
                });

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.BookGenre", b =>
                {
                    b.Property<Guid>("BookGenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenreID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BookGenreID");

                    b.HasIndex("BookID");

                    b.HasIndex("GenreID");

                    b.ToTable("BookGenres");

                    b.HasData(
                        new
                        {
                            BookGenreID = new Guid("edaa3021-a962-4536-8f7c-3049431aa19f"),
                            BookID = new Guid("c478d9e0-20df-48e2-8bd8-70389b3a132f"),
                            GenreID = new Guid("55dbb31b-00c1-4573-bae1-796883230a6a")
                        },
                        new
                        {
                            BookGenreID = new Guid("f5c8d2a4-1c31-44d3-9e37-316afc8d14de"),
                            BookID = new Guid("c478d9e0-20df-48e2-8bd8-70389b3a132f"),
                            GenreID = new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5")
                        },
                        new
                        {
                            BookGenreID = new Guid("53ac1d0e-293b-4f34-9efe-fd4d285a5fcd"),
                            BookID = new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"),
                            GenreID = new Guid("4b547d84-d249-497a-9f45-3b887b0cfefe")
                        },
                        new
                        {
                            BookGenreID = new Guid("a1c46f00-f455-4258-8113-2c3158845ea9"),
                            BookID = new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"),
                            GenreID = new Guid("1d885ced-3b38-4345-8db9-b6515d8aed87")
                        },
                        new
                        {
                            BookGenreID = new Guid("a4dfc962-43aa-4406-9fc0-bd312a5cd5ff"),
                            BookID = new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"),
                            GenreID = new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde")
                        },
                        new
                        {
                            BookGenreID = new Guid("afe3316b-c3c6-4399-8545-cb5bafe22aa1"),
                            BookID = new Guid("d47ae111-b7d2-4f0d-ad5d-f107e5b6b111"),
                            GenreID = new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde")
                        },
                        new
                        {
                            BookGenreID = new Guid("42334e55-405c-4726-ac2e-8deb471bcf45"),
                            BookID = new Guid("2750ec46-70f7-4866-b5fd-3a4177fcca5a"),
                            GenreID = new Guid("68f63252-534c-4b07-b092-b49001ab667d")
                        },
                        new
                        {
                            BookGenreID = new Guid("1380bb90-beb6-4fa5-a5a3-16d05231fd19"),
                            BookID = new Guid("2750ec46-70f7-4866-b5fd-3a4177fcca5a"),
                            GenreID = new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5")
                        },
                        new
                        {
                            BookGenreID = new Guid("34517cbf-897c-48ae-bfcc-8106083a2719"),
                            BookID = new Guid("847a73e7-d476-43b3-8424-a41154cef1d2"),
                            GenreID = new Guid("68f63252-534c-4b07-b092-b49001ab667d")
                        },
                        new
                        {
                            BookGenreID = new Guid("76871d19-0122-4fe4-90ad-f9fee31d8399"),
                            BookID = new Guid("847a73e7-d476-43b3-8424-a41154cef1d2"),
                            GenreID = new Guid("68f63252-534c-4b07-b092-b49001ab667d")
                        },
                        new
                        {
                            BookGenreID = new Guid("b0930f53-4f6c-4c64-bea0-4dd781c6f6c8"),
                            BookID = new Guid("847a73e7-d476-43b3-8424-a41154cef1d2"),
                            GenreID = new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5")
                        },
                        new
                        {
                            BookGenreID = new Guid("dafa196f-2c94-4957-8e9a-11d8d6e2de6d"),
                            BookID = new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"),
                            GenreID = new Guid("1d885ced-3b38-4345-8db9-b6515d8aed87")
                        },
                        new
                        {
                            BookGenreID = new Guid("880bf0df-e78b-4150-9bab-64cbc8c66d9e"),
                            BookID = new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"),
                            GenreID = new Guid("9b03337b-9fc0-4ed6-aa4c-56c5d8853372")
                        },
                        new
                        {
                            BookGenreID = new Guid("ae7a7347-244a-4a6d-852c-0605f0e86775"),
                            BookID = new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"),
                            GenreID = new Guid("55dbb31b-00c1-4573-bae1-796883230a6a")
                        },
                        new
                        {
                            BookGenreID = new Guid("c02dd986-d6eb-47d9-ae1b-20533546798b"),
                            BookID = new Guid("8e53b1e7-b21a-444b-9755-cc3c25778076"),
                            GenreID = new Guid("f6121152-54a1-4109-9f55-572585ce513a")
                        },
                        new
                        {
                            BookGenreID = new Guid("f29f26d1-9507-4175-bad9-b7deeca6a372"),
                            BookID = new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"),
                            GenreID = new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5")
                        },
                        new
                        {
                            BookGenreID = new Guid("f61c2a56-55dd-454f-8dfd-b17637a2af17"),
                            BookID = new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"),
                            GenreID = new Guid("a887dffd-39b2-4719-800b-37307b8d37ed")
                        },
                        new
                        {
                            BookGenreID = new Guid("522d3bc9-76f6-482b-b460-792547f427c9"),
                            BookID = new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"),
                            GenreID = new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde")
                        },
                        new
                        {
                            BookGenreID = new Guid("0231452d-12e7-4864-9789-0398817c42a9"),
                            BookID = new Guid("9d555a47-1c5d-4ef2-b936-5af72c52f978"),
                            GenreID = new Guid("a887dffd-39b2-4719-800b-37307b8d37ed")
                        },
                        new
                        {
                            BookGenreID = new Guid("90440b10-99a8-4d2f-abf6-a66085ec70c0"),
                            BookID = new Guid("7a55d2be-a1db-4c3c-b12a-bcab950a07c1"),
                            GenreID = new Guid("f6121152-54a1-4109-9f55-572585ce513a")
                        },
                        new
                        {
                            BookGenreID = new Guid("df08daa4-86d8-4fc1-95cc-45b6de805e65"),
                            BookID = new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"),
                            GenreID = new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde")
                        },
                        new
                        {
                            BookGenreID = new Guid("5ca7c528-8b3e-443a-a92a-e9488c1bfd57"),
                            BookID = new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"),
                            GenreID = new Guid("68f63252-534c-4b07-b092-b49001ab667d")
                        },
                        new
                        {
                            BookGenreID = new Guid("b817c45f-56c9-4674-9e9a-3a98871dabf1"),
                            BookID = new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"),
                            GenreID = new Guid("f6121152-54a1-4109-9f55-572585ce513a")
                        },
                        new
                        {
                            BookGenreID = new Guid("a05da6a3-67e1-45dc-9027-83ea39a0558b"),
                            BookID = new Guid("0189b46e-ada3-4e88-ba33-3d2263c2aa45"),
                            GenreID = new Guid("9b03337b-9fc0-4ed6-aa4c-56c5d8853372")
                        },
                        new
                        {
                            BookGenreID = new Guid("feee5d90-b7bb-4ea1-824a-fecbc00e7ad4"),
                            BookID = new Guid("78c4455b-2984-422f-8fe6-cdf2937f3a9e"),
                            GenreID = new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde")
                        },
                        new
                        {
                            BookGenreID = new Guid("d82591e2-9fad-4f3f-8468-4423f0927769"),
                            BookID = new Guid("7bf996e6-d026-4665-b4b1-037e78cd9855"),
                            GenreID = new Guid("f6121152-54a1-4109-9f55-572585ce513a")
                        },
                        new
                        {
                            BookGenreID = new Guid("9f4479f0-c21e-44d7-86b2-afd0d041822b"),
                            BookID = new Guid("bbe8ebc4-2517-4ed3-a418-758c8f8b69e5"),
                            GenreID = new Guid("1d885ced-3b38-4345-8db9-b6515d8aed87")
                        },
                        new
                        {
                            BookGenreID = new Guid("674d39d0-3c5a-44e8-b742-83f088735798"),
                            BookID = new Guid("bbe8ebc4-2517-4ed3-a418-758c8f8b69e5"),
                            GenreID = new Guid("a887dffd-39b2-4719-800b-37307b8d37ed")
                        });
                });

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.Genre", b =>
                {
                    b.Property<Guid>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreID = new Guid("55dbb31b-00c1-4573-bae1-796883230a6a"),
                            Name = "Beauty"
                        },
                        new
                        {
                            GenreID = new Guid("1d885ced-3b38-4345-8db9-b6515d8aed87"),
                            Name = "Outdoors"
                        },
                        new
                        {
                            GenreID = new Guid("fc33d92f-5cd0-4576-b9b4-65a4abb4fdde"),
                            Name = "Computers"
                        },
                        new
                        {
                            GenreID = new Guid("a887dffd-39b2-4719-800b-37307b8d37ed"),
                            Name = "Grocery"
                        },
                        new
                        {
                            GenreID = new Guid("4b547d84-d249-497a-9f45-3b887b0cfefe"),
                            Name = "Garden"
                        },
                        new
                        {
                            GenreID = new Guid("f6121152-54a1-4109-9f55-572585ce513a"),
                            Name = "Computers"
                        },
                        new
                        {
                            GenreID = new Guid("10c864aa-63e8-4eca-8dc6-74c5707d83a5"),
                            Name = "Electronics"
                        },
                        new
                        {
                            GenreID = new Guid("c3ce31ab-7f02-490d-a797-8a9fe1d92f45"),
                            Name = "Computers"
                        },
                        new
                        {
                            GenreID = new Guid("68f63252-534c-4b07-b092-b49001ab667d"),
                            Name = "Grocery"
                        },
                        new
                        {
                            GenreID = new Guid("9b03337b-9fc0-4ed6-aa4c-56c5d8853372"),
                            Name = "Automotive"
                        });
                });

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = new Guid("6b67b8c0-fb73-46ea-9142-b8e0723df042"),
                            Email = "test1@example.com",
                            Name = "KingCris",
                            Password = "contraseña01",
                            Role = 1
                        });
                });

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.Book", b =>
                {
                    b.HasOne("TechnicsTest.GraphQL.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.BookGenre", b =>
                {
                    b.HasOne("TechnicsTest.GraphQL.Models.Book", "Books")
                        .WithMany("Genres")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechnicsTest.GraphQL.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.Book", b =>
                {
                    b.Navigation("Genres");
                });

            modelBuilder.Entity("TechnicsTest.GraphQL.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
