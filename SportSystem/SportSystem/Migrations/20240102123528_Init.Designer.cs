﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportSystem.Data.DataContext;

#nullable disable

namespace SportSystem.Migrations
{
    [DbContext(typeof(SportSystemDbContext))]
    [Migration("20240102123528_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Identity")
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("IdentityRole", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("IdentityRoleClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("IdentityUserRoles", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "Identity");
                });

            modelBuilder.Entity("SportSystem.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("IdentityUsers", "Identity");
                });

            modelBuilder.Entity("SportSystem.Data.Models.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HostTeamGoals")
                        .HasColumnType("int");

                    b.Property<Guid>("HostTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("VisitorTeamGoals")
                        .HasColumnType("int");

                    b.Property<Guid>("VisitorTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HostTeamId");

                    b.HasIndex("LocationId");

                    b.HasIndex("VisitorTeamId");

                    b.ToTable("Games", "Identity");
                });

            modelBuilder.Entity("SportSystem.Data.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.Property<int>("Surface")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Locations", "Identity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ab0d0068-9385-4dcf-81ce-ac38dfc2203c"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 15222,
                            State = "Podlaskie",
                            Street = "Dąbrowskiego",
                            StreetNumber = 15,
                            Surface = 0
                        },
                        new
                        {
                            Id = new Guid("05d4a8ae-6681-4724-94d8-85f64207b2be"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 154777,
                            State = "Podlaskie",
                            Street = "Piotrkowska",
                            StreetNumber = 28,
                            Surface = 1
                        },
                        new
                        {
                            Id = new Guid("d921f2b2-5044-48b5-9d17-d5ddd1035c86"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 12345,
                            State = "Podlaskie",
                            Street = "Zielona",
                            StreetNumber = 9,
                            Surface = 0
                        },
                        new
                        {
                            Id = new Guid("b0eb3655-876b-4a2c-a413-9b0f521c2da7"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 54321,
                            State = "Podlaskie",
                            Street = "Mazurska",
                            StreetNumber = 47,
                            Surface = 1
                        },
                        new
                        {
                            Id = new Guid("0fa5891b-5945-41d6-bb08-142fab15fcfa"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 67890,
                            State = "Podlaskie",
                            Street = "Grunwaldzka",
                            StreetNumber = 82,
                            Surface = 0
                        },
                        new
                        {
                            Id = new Guid("e80b8ca4-a81e-4068-811a-5ab18c6e1ca5"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 11111,
                            State = "Podlaskie",
                            Street = "Kwiatowa",
                            StreetNumber = 11,
                            Surface = 1
                        },
                        new
                        {
                            Id = new Guid("10795dc7-adb3-4845-9aee-a2920c48eedc"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 22222,
                            State = "Podlaskie",
                            Street = "Słoneczna",
                            StreetNumber = 33,
                            Surface = 0
                        },
                        new
                        {
                            Id = new Guid("2649ca81-571f-4e76-81dc-5e5d8c1353bb"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 33333,
                            State = "Podlaskie",
                            Street = "Piękna",
                            StreetNumber = 16,
                            Surface = 1
                        },
                        new
                        {
                            Id = new Guid("ab3e6c09-fdd3-44b8-b55e-7e1254d51bf9"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 44444,
                            State = "Podlaskie",
                            Street = "Zachodnia",
                            StreetNumber = 5,
                            Surface = 0
                        },
                        new
                        {
                            Id = new Guid("6f76b46b-1d75-46d5-83af-58d7a40e93a8"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 55555,
                            State = "Podlaskie",
                            Street = "Akacjowa",
                            StreetNumber = 22,
                            Surface = 1
                        },
                        new
                        {
                            Id = new Guid("6d8ff10f-40b2-454b-996a-ed00a837a64c"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 66666,
                            State = "Podlaskie",
                            Street = "Klonowa",
                            StreetNumber = 18,
                            Surface = 0
                        },
                        new
                        {
                            Id = new Guid("13070321-0179-4839-ad6e-649b5ae893b3"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 77777,
                            State = "Podlaskie",
                            Street = "Nadrzeczna",
                            StreetNumber = 39,
                            Surface = 1
                        },
                        new
                        {
                            Id = new Guid("293d4fde-8593-4f0f-8732-0661b28a54e7"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 88888,
                            State = "Podlaskie",
                            Street = "Topolowa",
                            StreetNumber = 7,
                            Surface = 0
                        },
                        new
                        {
                            Id = new Guid("fa3b9052-cddc-41a6-9d60-7674e6409769"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 99999,
                            State = "Podlaskie",
                            Street = "Kamienna",
                            StreetNumber = 25,
                            Surface = 1
                        },
                        new
                        {
                            Id = new Guid("4b018c63-246c-438f-80d9-f24b15589522"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 101010,
                            State = "Podlaskie",
                            Street = "Żytnia",
                            StreetNumber = 12,
                            Surface = 0
                        },
                        new
                        {
                            Id = new Guid("600ed060-221a-4590-8ab6-bc399bac1002"),
                            City = "Białystok",
                            Country = "Polska",
                            PostalCode = 111111,
                            State = "Podlaskie",
                            Street = "Łąkowa",
                            StreetNumber = 31,
                            Surface = 1
                        });
                });

            modelBuilder.Entity("SportSystem.Data.Models.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams", "Identity");
                });

            modelBuilder.Entity("SportSystem.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("00000001-0000-0000-0000-000000000000"));

                    b.Property<Guid?>("RoleInTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserRoleInTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleInTeamId");

                    b.ToTable("User", "Identity");
                });

            modelBuilder.Entity("SportSystem.Data.Models.UserRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles", "Identity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000001-0000-0000-0000-000000000000"),
                            Name = "Coach"
                        },
                        new
                        {
                            Id = new Guid("00000002-0000-0000-0000-000000000000"),
                            Name = "NormalUser"
                        });
                });

            modelBuilder.Entity("SportSystem.Data.Models.UserTeam", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("UserTeams", "Identity");
                });

            modelBuilder.Entity("SportSystem.Data.Models.UserTeamRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserTeamRole", "Identity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000001-0000-0000-0000-000000000000"),
                            Name = "Goalkeeper"
                        },
                        new
                        {
                            Id = new Guid("00000002-0000-0000-0000-000000000000"),
                            Name = "Defender"
                        },
                        new
                        {
                            Id = new Guid("00000003-0000-0000-0000-000000000000"),
                            Name = "DefensiveMidfielder"
                        },
                        new
                        {
                            Id = new Guid("00000004-0000-0000-0000-000000000000"),
                            Name = "ForwardMidfielder"
                        },
                        new
                        {
                            Id = new Guid("00000005-0000-0000-0000-000000000000"),
                            Name = "Midfielder"
                        },
                        new
                        {
                            Id = new Guid("00000006-0000-0000-0000-000000000000"),
                            Name = "Striker"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SportSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SportSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SportSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportSystem.Data.Models.Game", b =>
                {
                    b.HasOne("SportSystem.Data.Models.Team", "HostTeam")
                        .WithMany("HomeGames")
                        .HasForeignKey("HostTeamId")
                        .IsRequired();

                    b.HasOne("SportSystem.Data.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportSystem.Data.Models.Team", "VisitorsTeam")
                        .WithMany("VisitorsGames")
                        .HasForeignKey("VisitorTeamId")
                        .IsRequired();

                    b.Navigation("HostTeam");

                    b.Navigation("Location");

                    b.Navigation("VisitorsTeam");
                });

            modelBuilder.Entity("SportSystem.Data.Models.User", b =>
                {
                    b.HasOne("SportSystem.Data.Models.UserRoles", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportSystem.Data.Models.UserTeamRole", "RoleInTeam")
                        .WithMany()
                        .HasForeignKey("RoleInTeamId");

                    b.Navigation("Role");

                    b.Navigation("RoleInTeam");
                });

            modelBuilder.Entity("SportSystem.Data.Models.UserTeam", b =>
                {
                    b.HasOne("SportSystem.Data.Models.Team", "Team")
                        .WithMany("Users")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportSystem.Data.Models.User", "User")
                        .WithMany("Team")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportSystem.Data.Models.Team", b =>
                {
                    b.Navigation("HomeGames");

                    b.Navigation("Users");

                    b.Navigation("VisitorsGames");
                });

            modelBuilder.Entity("SportSystem.Data.Models.User", b =>
                {
                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
