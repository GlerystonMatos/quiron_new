﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quiron.Auditoria.Context;

#nullable disable

namespace Quiron.Auditoria.Migrations
{
    [DbContext(typeof(AuditoriaContext))]
    partial class AuditoriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Quiron.Auditoria.Entities.EntityAudit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuditMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuditUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SaveChangesAuditId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SaveChangesAuditId");

                    b.ToTable("EntityAudit");
                });

            modelBuilder.Entity("Quiron.Auditoria.Entities.SaveChangesAudit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuditId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ErrorMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Succeeded")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SaveChangesAudit");
                });

            modelBuilder.Entity("Quiron.Auditoria.Entities.EntityAudit", b =>
                {
                    b.HasOne("Quiron.Auditoria.Entities.SaveChangesAudit", "SaveChangesAudit")
                        .WithMany("Entities")
                        .HasForeignKey("SaveChangesAuditId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SaveChangesAudit");
                });

            modelBuilder.Entity("Quiron.Auditoria.Entities.SaveChangesAudit", b =>
                {
                    b.Navigation("Entities");
                });
#pragma warning restore 612, 618
        }
    }
}
