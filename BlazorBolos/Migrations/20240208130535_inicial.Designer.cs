﻿// <auto-generated />
using BlazorBolos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorBolos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240208130535_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorBolos.Data.Bolo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Bolos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Bolo1 ",
                            ImagemUrl = "bolo1.jpg",
                            Nome = "Bolo1",
                            Preco = 25.45m
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Bolo2 Descricao",
                            ImagemUrl = "bolo2.jpg",
                            Nome = "Bolo2",
                            Preco = 21.0m
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Bolo3 descricao",
                            ImagemUrl = "bolo3.jpg",
                            Nome = "Bolo3",
                            Preco = 19.0m
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Bolo4 descricao",
                            ImagemUrl = "bolo4.jpg",
                            Nome = "Bolo4",
                            Preco = 34.75m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
