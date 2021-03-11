﻿// <auto-generated />
using Assignment5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment5.Migrations
{
    [DbContext(typeof(BookDbContext))]
    partial class BookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Assignment5.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Class")
                        .HasColumnType("TEXT");

                    b.Property<long>("ISBN")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Pages")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}