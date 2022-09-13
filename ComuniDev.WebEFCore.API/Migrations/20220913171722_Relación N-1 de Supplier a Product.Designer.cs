﻿// <auto-generated />
using System;
using ComuniDev.WebEFCore.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComuniDev.WebEFCore.API.Migrations
{
    [DbContext(typeof(SalesDB2022DbContext))]
    [Migration("20220913171722_Relación N-1 de Supplier a Product")]
    partial class RelaciónN1deSupplieraProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ComuniDev.WebEFCore.API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ComuniDev.WebEFCore.API.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("ComuniDev.WebEFCore.API.Models.Product", b =>
                {
                    b.HasOne("ComuniDev.WebEFCore.API.Models.Supplier", null)
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("ComuniDev.WebEFCore.API.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
