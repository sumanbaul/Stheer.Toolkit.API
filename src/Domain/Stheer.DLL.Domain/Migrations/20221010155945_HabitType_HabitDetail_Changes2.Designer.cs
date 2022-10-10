﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stheer.DLL.Domain.DBContext;

#nullable disable

namespace Stheer.DLL.Domain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221010155945_HabitType_HabitDetail_Changes2")]
    partial class HabitType_HabitDetail_Changes2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Stheer.Api.Provider.Models.Habit", b =>
                {
                    b.Property<int>("HabitsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HabitsId"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HabitName")
                        .HasColumnType("varchar(150)");

                    b.Property<int?>("HabitTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("IsCompleted")
                        .HasColumnType("int");

                    b.Property<int?>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("HabitsId");

                    b.ToTable("habitDetails");
                });

            modelBuilder.Entity("Stheer.DLL.Domain.Models.HabitType", b =>
                {
                    b.Property<int>("HabitTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HabitTypeId"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HabitTypeName")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int?>("HabitsId")
                        .HasColumnType("int");

                    b.Property<int?>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("HabitTypeId");

                    b.ToTable("habitTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
