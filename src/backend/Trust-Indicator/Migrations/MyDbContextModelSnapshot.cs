﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trust_Indicator.Data;

#nullable disable

namespace Trust_Indicator.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Trust_Indicator.Model.Favorite", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Create_Date")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<int>("ImageID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_Favorite")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Rate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecordID");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Trust_Indicator.Model.Image", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("UploadDate")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ImageID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Trust_Indicator.Model.Metadata", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Altitude")
                        .HasColumnType("REAL");

                    b.Property<float>("Aperture")
                        .HasColumnType("REAL");

                    b.Property<string>("Color_Space")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Create_Date")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<float>("Explosure")
                        .HasColumnType("REAL");

                    b.Property<int>("File_Size")
                        .HasColumnType("INTEGER");

                    b.Property<string>("File_Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Flash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Focal_Length")
                        .HasColumnType("REAL");

                    b.Property<int>("ISO")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Lens")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("MIME_Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Modify_Date")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<string>("Software")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ImageID");

                    b.ToTable("Metadata");
                });

            modelBuilder.Entity("Trust_Indicator.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Is_Admin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LegalName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePhotoNO")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}