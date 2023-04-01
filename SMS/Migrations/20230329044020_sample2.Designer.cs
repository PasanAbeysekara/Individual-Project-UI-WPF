﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMS;

#nullable disable

namespace SMS.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230329044020_sample2")]
    partial class sample2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("SMS.SelecStudent", b =>
                {
                    b.Property<int>("Idx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Idx");

                    b.HasIndex("StudId");

                    b.ToTable("SelectedStudent");
                });

            modelBuilder.Entity("SMS.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("GPA")
                        .HasColumnType("REAL");

                    b.Property<char>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SMS.SelecStudent", b =>
                {
                    b.HasOne("SMS.Student", "Stud")
                        .WithMany()
                        .HasForeignKey("StudId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stud");
                });
#pragma warning restore 612, 618
        }
    }
}
