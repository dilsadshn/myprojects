﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PerakendeApp.DAL.Context;

#nullable disable

namespace PerakendeApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PerakendeApp.DAL.Model.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CartItemId"));

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<int>("SatisId")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.HasIndex("SatisId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("PerakendeApp.DAL.Model.Satis", b =>
                {
                    b.Property<int>("SatisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SatisId"));

                    b.Property<DateTime>("ProcDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProcType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SatisId");

                    b.HasIndex("UserId");

                    b.ToTable("Satislar");
                });

            modelBuilder.Entity("PerakendeApp.DAL.Model.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("StockId"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("StockName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StockId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("PerakendeApp.DAL.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PerakendeApp.DAL.Model.CartItem", b =>
                {
                    b.HasOne("PerakendeApp.DAL.Model.Satis", "Satis")
                        .WithMany("CartItems")
                        .HasForeignKey("SatisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Satis");
                });

            modelBuilder.Entity("PerakendeApp.DAL.Model.Satis", b =>
                {
                    b.HasOne("PerakendeApp.DAL.Model.User", "User")
                        .WithMany("Satislar")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PerakendeApp.DAL.Model.Satis", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("PerakendeApp.DAL.Model.User", b =>
                {
                    b.Navigation("Satislar");
                });
#pragma warning restore 612, 618
        }
    }
}
