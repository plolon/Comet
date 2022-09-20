﻿// <auto-generated />
using Comet.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Comet.Migrations
{
    [DbContext(typeof(CometDbContext))]
    [Migration("20220920201154_SeedDatabase")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Comet.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Makes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Make1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Make2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Make3"
                        });
                });

            modelBuilder.Entity("Comet.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MakeId = 1,
                            Name = "Make1-ModelA"
                        },
                        new
                        {
                            Id = 2,
                            MakeId = 1,
                            Name = "Make1-ModelB"
                        },
                        new
                        {
                            Id = 3,
                            MakeId = 1,
                            Name = "Make1-ModelC"
                        },
                        new
                        {
                            Id = 4,
                            MakeId = 2,
                            Name = "Make2-ModelA"
                        },
                        new
                        {
                            Id = 5,
                            MakeId = 2,
                            Name = "Make2-ModelB"
                        },
                        new
                        {
                            Id = 6,
                            MakeId = 2,
                            Name = "Make2-ModelC"
                        },
                        new
                        {
                            Id = 7,
                            MakeId = 3,
                            Name = "Make3-ModelA"
                        },
                        new
                        {
                            Id = 8,
                            MakeId = 3,
                            Name = "Make3-ModelB"
                        },
                        new
                        {
                            Id = 9,
                            MakeId = 3,
                            Name = "Make3-ModelC"
                        });
                });

            modelBuilder.Entity("Comet.Models.Model", b =>
                {
                    b.HasOne("Comet.Models.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Make");
                });

            modelBuilder.Entity("Comet.Models.Make", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
