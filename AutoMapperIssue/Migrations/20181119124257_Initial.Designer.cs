﻿// <auto-generated />
using System;
using AutoMapperIssue.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoMapperIssue.Migrations
{
    [DbContext(typeof(EfContext))]
    [Migration("20181119124257_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoMapperIssue.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(100);

                    b.Property<int?>("CountryId");

                    b.Property<string>("State")
                        .HasMaxLength(100);

                    b.Property<string>("Street")
                        .HasMaxLength(100);

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AutoMapperIssue.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("RegionId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("AutoMapperIssue.Models.LkupNationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("date");

                    b.Property<string>("Language")
                        .HasMaxLength(15);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("RegionId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("LkupNationalities");
                });

            modelBuilder.Entity("AutoMapperIssue.Models.LkupRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("date");

                    b.Property<string>("EmailRecipients");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("LkupRegions");
                });

            modelBuilder.Entity("AutoMapperIssue.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("MailAddressId");

                    b.Property<int>("NationalityId");

                    b.Property<int?>("RegAddressId");

                    b.HasKey("Id");

                    b.HasIndex("MailAddressId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("RegAddressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AutoMapperIssue.Models.Address", b =>
                {
                    b.HasOne("AutoMapperIssue.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("AutoMapperIssue.Models.Country", b =>
                {
                    b.HasOne("AutoMapperIssue.Models.LkupRegion", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("AutoMapperIssue.Models.LkupNationality", b =>
                {
                    b.HasOne("AutoMapperIssue.Models.LkupRegion", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("AutoMapperIssue.Models.User", b =>
                {
                    b.HasOne("AutoMapperIssue.Models.Address", "MailAddress")
                        .WithMany()
                        .HasForeignKey("MailAddressId");

                    b.HasOne("AutoMapperIssue.Models.LkupNationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoMapperIssue.Models.Address", "RegAddress")
                        .WithMany()
                        .HasForeignKey("RegAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
