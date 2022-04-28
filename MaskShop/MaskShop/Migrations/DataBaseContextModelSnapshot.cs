﻿// <auto-generated />
using System;
using MaskShop.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaskShop.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MaskShop.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("MaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaskId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MaskShop.Models.Mask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Masks");
                });

            modelBuilder.Entity("MaskShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("MaskId")
                        .HasColumnType("int");

                    b.Property<string>("ShopCartUserLogin")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MaskId");

                    b.HasIndex("ShopCartUserLogin");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MaskShop.Models.ShopCart", b =>
                {
                    b.Property<string>("UserLogin")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserLogin");

                    b.ToTable("ShopCarts");
                });

            modelBuilder.Entity("MaskShop.Models.User", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Login");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MaskShop.Models.Image", b =>
                {
                    b.HasOne("MaskShop.Models.Mask", null)
                        .WithMany("Images")
                        .HasForeignKey("MaskId");
                });

            modelBuilder.Entity("MaskShop.Models.Order", b =>
                {
                    b.HasOne("MaskShop.Models.Mask", "Mask")
                        .WithMany()
                        .HasForeignKey("MaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaskShop.Models.ShopCart", null)
                        .WithMany("Orders")
                        .HasForeignKey("ShopCartUserLogin");

                    b.Navigation("Mask");
                });

            modelBuilder.Entity("MaskShop.Models.ShopCart", b =>
                {
                    b.HasOne("MaskShop.Models.User", "User")
                        .WithOne("ShopCart")
                        .HasForeignKey("MaskShop.Models.ShopCart", "UserLogin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MaskShop.Models.Mask", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("MaskShop.Models.ShopCart", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MaskShop.Models.User", b =>
                {
                    b.Navigation("ShopCart");
                });
#pragma warning restore 612, 618
        }
    }
}
