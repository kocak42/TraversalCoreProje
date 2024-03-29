﻿// <auto-generated />
using System;
using DataAccess.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240204172849_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entity.Concrate.BannerAbout", b =>
                {
                    b.Property<int>("BannerAboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BannerAboutId"), 1L, 1);

                    b.Property<string>("BannerAboutDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerAboutTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BannerAboutId");

                    b.ToTable("BannerAbouts");
                });

            modelBuilder.Entity("Entity.Concrate.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<string>("CommenContet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CommenState")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CommentUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Entity.Concrate.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("MapLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entity.Concrate.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinationId"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DastinationDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DastinationStatus")
                        .HasColumnType("bit");

                    b.Property<string>("DayNight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("Entity.Concrate.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<string>("EmployeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmployeeStatus")
                        .HasColumnType("bit");

                    b.Property<string>("InstagramUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwitterUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Entity.Concrate.FirstAbout", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"), 1L, 1);

                    b.Property<string>("FirstAboutDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstAboutImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FirstAboutStatus")
                        .HasColumnType("bit");

                    b.Property<string>("FirstAboutTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstOtherTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("FirstAbouts");
                });

            modelBuilder.Entity("Entity.Concrate.FirstFeature", b =>
                {
                    b.Property<int>("FirstFeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FirstFeatureId"), 1L, 1);

                    b.Property<string>("FeatureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstFeatureDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstFeatureImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FirstFeatureStatus")
                        .HasColumnType("bit");

                    b.HasKey("FirstFeatureId");

                    b.ToTable("FirstFeatures");
                });

            modelBuilder.Entity("Entity.Concrate.Newslatter", b =>
                {
                    b.Property<int>("NewslatterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewslatterId"), 1L, 1);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewslatterId");

                    b.ToTable("Newslatters");
                });

            modelBuilder.Entity("Entity.Concrate.SecondAbout", b =>
                {
                    b.Property<int>("SecondAboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SecondAboutId"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondAboutTitle1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondAboutTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondAboutdescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SecondAboutId");

                    b.ToTable("SecondAbouts");
                });

            modelBuilder.Entity("Entity.Concrate.SecondFeature", b =>
                {
                    b.Property<int>("SecondFeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SecondFeatureId"), 1L, 1);

                    b.Property<string>("SecondFeatureDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondFeatureImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SecondFeatureStatus")
                        .HasColumnType("bit");

                    b.Property<string>("SecondFeatureTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SecondFeatureId");

                    b.ToTable("secondFeatures");
                });

            modelBuilder.Entity("Entity.Concrate.Testimonial", b =>
                {
                    b.Property<int>("TestimonialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestimonialId"), 1L, 1);

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TestimonialStatus")
                        .HasColumnType("bit");

                    b.HasKey("TestimonialId");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("Entity.Concrate.Comment", b =>
                {
                    b.HasOne("Entity.Concrate.Destination", "Destination")
                        .WithMany("Comments")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("Entity.Concrate.Destination", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
