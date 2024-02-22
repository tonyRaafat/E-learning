﻿// <auto-generated />
using E_learing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_learing.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240220204644_addCategoryTable")]
    partial class addCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_learing.Models.CourseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CourseCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Back-end"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Front-end"
                        },
                        new
                        {
                            Id = 3,
                            Name = "FullStack"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
