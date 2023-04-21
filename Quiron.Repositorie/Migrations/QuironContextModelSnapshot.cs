﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quiron.Data.EF.Context;

#nullable disable

namespace Quiron.Data.EF.Migrations
{
    [DbContext(typeof(QuironContext))]
    partial class QuironContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Quiron.Domain.Entities.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEstado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstado");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("373fad00-4ace-4c53-abbd-4fa11212cd88"),
                            IdEstado = new Guid("362c52b3-b9db-4aca-a48f-6e47aa77f819"),
                            Nome = "Fortaleza"
                        },
                        new
                        {
                            Id = new Guid("a5dc78eb-d526-42e1-bf5d-ba8a571a8b69"),
                            IdEstado = new Guid("362c52b3-b9db-4aca-a48f-6e47aa77f819"),
                            Nome = "Caucaia"
                        },
                        new
                        {
                            Id = new Guid("e374123a-423f-45b3-994f-68065e291f9d"),
                            IdEstado = new Guid("362c52b3-b9db-4aca-a48f-6e47aa77f819"),
                            Nome = "Maracanaú"
                        },
                        new
                        {
                            Id = new Guid("70604862-7558-4b46-b6e1-787f6a20eb7c"),
                            IdEstado = new Guid("c4a41075-59a0-4e87-8a1c-0d542bc90155"),
                            Nome = "Natal"
                        },
                        new
                        {
                            Id = new Guid("1d6209ec-a2d3-4536-8568-ee58cd8c46aa"),
                            IdEstado = new Guid("c4a41075-59a0-4e87-8a1c-0d542bc90155"),
                            Nome = "Pipa"
                        });
                });

            modelBuilder.Entity("Quiron.Domain.Entities.Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estado");

                    b.HasData(
                        new
                        {
                            Id = new Guid("362c52b3-b9db-4aca-a48f-6e47aa77f819"),
                            Nome = "Ceará",
                            Uf = "CE"
                        },
                        new
                        {
                            Id = new Guid("c4a41075-59a0-4e87-8a1c-0d542bc90155"),
                            Nome = "Rio Grande do Norte",
                            Uf = "RN"
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

            modelBuilder.Entity("Quiron.Domain.Entities.Cidade", b =>
                {
                    b.HasOne("Quiron.Domain.Entities.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Quiron.Domain.Entities.Estado", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}
