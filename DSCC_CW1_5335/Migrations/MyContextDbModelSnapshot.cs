﻿// <auto-generated />
using DSCC_CW1_5335.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DSCC_CW1_5335.Migrations
{
    [DbContext(typeof(MyContextDb))]
    partial class MyContextDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DSCC_CW1_5335.Model.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoomCategoryId");

                    b.Property<byte[]>("RoomPhoto");

                    b.Property<string>("RoomSize")
                        .IsRequired();

                    b.Property<int>("RoomTypeId");

                    b.HasKey("Id");

                    b.HasIndex("RoomCategoryId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DSCC_CW1_5335.Model.RoomCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("RoomCategories");
                });

            modelBuilder.Entity("DSCC_CW1_5335.Model.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TypeName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("DSCC_CW1_5335.Model.Room", b =>
                {
                    b.HasOne("DSCC_CW1_5335.Model.RoomCategory", "RoomCategory")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DSCC_CW1_5335.Model.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
