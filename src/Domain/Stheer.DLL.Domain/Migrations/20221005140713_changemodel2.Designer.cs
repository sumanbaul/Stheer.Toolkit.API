// <auto-generated />
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
    [Migration("20221005140713_changemodel2")]
    partial class changemodel2
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
                    b.Property<int?>("HabitsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("HabitsId"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar2(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HabitName")
                        .IsRequired()
                        .HasColumnType("varchar2(150)");

                    b.Property<string>("HabitType")
                        .IsRequired()
                        .HasColumnType("varchar2(150)");

                    b.Property<int>("IsCompleted")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("HabitsId");

                    b.ToTable("habitDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
