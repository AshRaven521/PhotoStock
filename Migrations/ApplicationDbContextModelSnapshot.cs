﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhotoStock.Data;

namespace PhotoStock.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("PhotoStock.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<short>("Age")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Nickname")
                        .HasColumnType("longtext");

                    b.Property<int?>("TextId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TextId1");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("PhotoStock.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorForeignKey")
                        .HasColumnType("int");

                    b.Property<string>("ContentUrl")
                        .HasColumnType("longtext");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("PurchaseAmount")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorForeignKey")
                        .IsUnique();

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("PhotoStock.Models.Text", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorForeignKey")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Demension")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("PurchaseAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorForeignKey")
                        .IsUnique();

                    b.ToTable("Texts");
                });

            modelBuilder.Entity("PhotoStock.Models.Author", b =>
                {
                    b.HasOne("PhotoStock.Models.Text", "Text")
                        .WithMany()
                        .HasForeignKey("TextId1");

                    b.Navigation("Text");
                });

            modelBuilder.Entity("PhotoStock.Models.Photo", b =>
                {
                    b.HasOne("PhotoStock.Models.Author", "Author")
                        .WithOne("Photo")
                        .HasForeignKey("PhotoStock.Models.Photo", "AuthorForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("PhotoStock.Models.Text", b =>
                {
                    b.HasOne("PhotoStock.Models.Author", "Author")
                        .WithOne()
                        .HasForeignKey("PhotoStock.Models.Text", "AuthorForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("PhotoStock.Models.Author", b =>
                {
                    b.Navigation("Photo");
                });
#pragma warning restore 612, 618
        }
    }
}
