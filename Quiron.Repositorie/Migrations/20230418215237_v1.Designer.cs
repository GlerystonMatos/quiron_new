﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quiron.Data.EF.Context;

#nullable disable

namespace Quiron.Data.EF.Migrations
{
    [DbContext(typeof(QuironContext))]
    [Migration("20230418215237_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Quiron.Domain.Entities.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animal");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1dfc4a8d-7ed1-443c-9cc7-ac71ea9d003b"),
                            Nome = "Cachorro"
                        },
                        new
                        {
                            Id = new Guid("8b5c8482-f2ec-4cf6-aaa8-20ec25112cd7"),
                            Nome = "Hamster"
                        });
                });

            modelBuilder.Entity("Quiron.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d78a657f-66fa-43f2-a535-212e6bfb6630"),
                            Login = "Teste01",
                            Nome = "Teste 01",
                            Senha = "1234"
                        },
                        new
                        {
                            Id = new Guid("10b42acc-45bd-460a-9edd-d568ff236e37"),
                            Login = "Teste02",
                            Nome = "Teste 02",
                            Senha = "4567"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
