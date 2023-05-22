﻿// <auto-generated />
using System;
using FitnessPass.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessPass.DB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230522080114_ConfigureNullableAndDefault")]
    partial class ConfigureNullableAndDefault
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitnessPass.Model.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("FitnessPass.Model.ClientPass", b =>
                {
                    b.Property<int>("ClientPassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientPassId"));

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntryCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstUsedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("PassTypePassId")
                        .HasColumnType("int");

                    b.Property<int>("SalePrice")
                        .HasColumnType("int");

                    b.Property<bool>("Valid")
                        .HasColumnType("bit");

                    b.HasKey("ClientPassId");

                    b.HasIndex("ClientId");

                    b.HasIndex("PassTypePassId");

                    b.ToTable("ClientPass");
                });

            modelBuilder.Entity("FitnessPass.Model.Entries", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntryId"));

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("InsertedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("PassTypePassId")
                        .HasColumnType("int");

                    b.HasKey("EntryId");

                    b.HasIndex("ClientId");

                    b.HasIndex("PassTypePassId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("FitnessPass.Model.Gym", b =>
                {
                    b.Property<int>("GymId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GymId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("GymId");

                    b.ToTable("Gym");
                });

            modelBuilder.Entity("FitnessPass.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FitnessPassApp.Data.PassType", b =>
                {
                    b.Property<int>("PassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassId"));

                    b.Property<int>("DaysValidFor")
                        .HasColumnType("int");

                    b.Property<int?>("EndTime")
                        .HasColumnType("int");

                    b.Property<int?>("EntriesValidFor")
                        .HasColumnType("int");

                    b.Property<int>("GymId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("MaxDailyUse")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int?>("StartTime")
                        .HasColumnType("int");

                    b.HasKey("PassId");

                    b.HasIndex("GymId");

                    b.ToTable("PassType");
                });

            modelBuilder.Entity("FitnessPass.Model.ClientPass", b =>
                {
                    b.HasOne("FitnessPass.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessPassApp.Data.PassType", "PassType")
                        .WithMany()
                        .HasForeignKey("PassTypePassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("PassType");
                });

            modelBuilder.Entity("FitnessPass.Model.Entries", b =>
                {
                    b.HasOne("FitnessPass.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessPassApp.Data.PassType", "PassType")
                        .WithMany()
                        .HasForeignKey("PassTypePassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("PassType");
                });

            modelBuilder.Entity("FitnessPassApp.Data.PassType", b =>
                {
                    b.HasOne("FitnessPass.Model.Gym", "Gym")
                        .WithMany()
                        .HasForeignKey("GymId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gym");
                });
#pragma warning restore 612, 618
        }
    }
}
