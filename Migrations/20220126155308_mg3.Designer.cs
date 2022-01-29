﻿// <auto-generated />
using System;
using MNS_Reviews.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MNS_Reviews.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220126155308_mg3")]
    partial class mg3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MNS_Reviews.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CommentOwner")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("MNS_Reviews.Models.Deneme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Deneme");
                });

            modelBuilder.Entity("MNS_Reviews.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"), 1L, 1);

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("MNS_Reviews.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("MNS_Reviews.Models.Movie", b =>
                {
                    b.HasBaseType("MNS_Reviews.Models.Post");

                    b.Property<string>("actors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("releaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scenarist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Movie", (string)null);
                });

            modelBuilder.Entity("MNS_Reviews.Models.Review", b =>
                {
                    b.HasBaseType("MNS_Reviews.Models.Post");

                    b.Property<string>("imgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Review", (string)null);
                });

            modelBuilder.Entity("MNS_Reviews.Models.Serie", b =>
                {
                    b.HasBaseType("MNS_Reviews.Models.Post");

                    b.Property<string>("actors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("relaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scenarist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("season")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Serie", (string)null);
                });

            modelBuilder.Entity("MNS_Reviews.Models.Trailer", b =>
                {
                    b.HasBaseType("MNS_Reviews.Models.Post");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Trailer", (string)null);
                });

            modelBuilder.Entity("MNS_Reviews.Models.Movie", b =>
                {
                    b.HasOne("MNS_Reviews.Models.Post", null)
                        .WithOne()
                        .HasForeignKey("MNS_Reviews.Models.Movie", "PostId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MNS_Reviews.Models.Review", b =>
                {
                    b.HasOne("MNS_Reviews.Models.Post", null)
                        .WithOne()
                        .HasForeignKey("MNS_Reviews.Models.Review", "PostId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MNS_Reviews.Models.Serie", b =>
                {
                    b.HasOne("MNS_Reviews.Models.Post", null)
                        .WithOne()
                        .HasForeignKey("MNS_Reviews.Models.Serie", "PostId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MNS_Reviews.Models.Trailer", b =>
                {
                    b.HasOne("MNS_Reviews.Models.Post", null)
                        .WithOne()
                        .HasForeignKey("MNS_Reviews.Models.Trailer", "PostId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
