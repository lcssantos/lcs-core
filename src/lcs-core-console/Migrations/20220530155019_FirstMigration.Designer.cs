﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lcs_core_console.Repositories;

#nullable disable

namespace lcs_core.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220530155019_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("lcs_core_console.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("StudentType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Student", (string)null);

                    b.HasDiscriminator<int>("StudentType").HasValue(0);
                });

            modelBuilder.Entity("lcs_core_console.Entities.StudentGuest", b =>
                {
                    b.HasBaseType("lcs_core_console.Entities.Student");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpfNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PisNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Student", (string)null);

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("lcs_core_console.Entities.StudentOrganization", b =>
                {
                    b.HasBaseType("lcs_core_console.Entities.Student");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("Student", (string)null);

                    b.HasDiscriminator().HasValue(3);
                });

            modelBuilder.Entity("lcs_core_console.Entities.StudentProvider", b =>
                {
                    b.HasBaseType("lcs_core_console.Entities.Student");

                    b.Property<Guid>("EmployeeRegisterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProviderId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("Student", (string)null);

                    b.HasDiscriminator().HasValue(2);
                });
#pragma warning restore 612, 618
        }
    }
}
