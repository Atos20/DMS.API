﻿// <auto-generated />
using System;
using DMS.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DMS.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230607205955_fixSchoolNameType")]
    partial class fixSchoolNameType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActivityClassRoom", b =>
                {
                    b.Property<string>("ActivitiesActivityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClassRoomId")
                        .HasColumnType("int");

                    b.HasKey("ActivitiesActivityId", "ClassRoomId");

                    b.HasIndex("ClassRoomId");

                    b.ToTable("ActivityClassRoom");
                });

            modelBuilder.Entity("ChildGuardian", b =>
                {
                    b.Property<int>("ChildrenChildId")
                        .HasColumnType("int");

                    b.Property<int>("GuardiansGuardianId")
                        .HasColumnType("int");

                    b.HasKey("ChildrenChildId", "GuardiansGuardianId");

                    b.HasIndex("GuardiansGuardianId");

                    b.ToTable("ChildGuardian");
                });

            modelBuilder.Entity("DMS.Api.Models.Activity", b =>
                {
                    b.Property<string>("ActivityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AgeGroup")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeadBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialsNeeded")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("DMS.Api.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuardianId")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.HasIndex("GuardianId")
                        .IsUnique();

                    b.HasIndex("SchoolId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("DMS.Api.Models.Child", b =>
                {
                    b.Property<int>("ChildId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChildId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ClassRoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("ChildId");

                    b.HasIndex("ClassRoomId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Child");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Child");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DMS.Api.Models.ClassRoom", b =>
                {
                    b.Property<int>("ClassRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassRoomId"));

                    b.Property<string>("ChildCareWorker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChildrenLimit")
                        .HasColumnType("int");

                    b.Property<string>("ClassRoomName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndAge")
                        .HasColumnType("int");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("StartAge")
                        .HasColumnType("int");

                    b.HasKey("ClassRoomId");

                    b.HasIndex("SchoolId");

                    b.ToTable("ClassRoom");
                });

            modelBuilder.Entity("DMS.Api.Models.Guardian", b =>
                {
                    b.Property<int>("GuardianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuardianId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuardianId");

                    b.ToTable("Guardian");
                });

            modelBuilder.Entity("DMS.Api.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Location");
                });

            modelBuilder.Entity("DMS.Api.Models.Pantry", b =>
                {
                    b.Property<int>("PantryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PantryId"));

                    b.Property<int>("ClassRoomId")
                        .HasColumnType("int");

                    b.Property<int>("ClothChangesCount")
                        .HasColumnType("int");

                    b.Property<int>("DiaperCount")
                        .HasColumnType("int");

                    b.Property<int>("MilkBottleCount")
                        .HasColumnType("int");

                    b.Property<int>("MinimunRequiredBottles")
                        .HasColumnType("int");

                    b.Property<int>("MinimunRequiredChanges")
                        .HasColumnType("int");

                    b.Property<int>("MinimunRequiredDiapers")
                        .HasColumnType("int");

                    b.Property<bool>("NeedsClothes")
                        .HasColumnType("bit");

                    b.Property<bool>("NeedsMoreBottles")
                        .HasColumnType("bit");

                    b.Property<bool>("NeedsMoreSunscreen")
                        .HasColumnType("bit");

                    b.Property<double>("Sunscreen")
                        .HasColumnType("float");

                    b.Property<int>("UsedDiapers")
                        .HasColumnType("int");

                    b.HasKey("PantryId");

                    b.HasIndex("ClassRoomId")
                        .IsUnique();

                    b.ToTable("Pantry");
                });

            modelBuilder.Entity("DMS.Api.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolId"));

                    b.Property<string>("DirectorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolId");

                    b.ToTable("School");
                });

            modelBuilder.Entity("DMS.Api.Models.Student", b =>
                {
                    b.HasBaseType("DMS.Api.Models.Child");

                    b.Property<int?>("SchoolId1")
                        .HasColumnType("int");

                    b.HasIndex("SchoolId1");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("ActivityClassRoom", b =>
                {
                    b.HasOne("DMS.Api.Models.Activity", null)
                        .WithMany()
                        .HasForeignKey("ActivitiesActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMS.Api.Models.ClassRoom", null)
                        .WithMany()
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChildGuardian", b =>
                {
                    b.HasOne("DMS.Api.Models.Child", null)
                        .WithMany()
                        .HasForeignKey("ChildrenChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMS.Api.Models.Guardian", null)
                        .WithMany()
                        .HasForeignKey("GuardiansGuardianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DMS.Api.Models.Address", b =>
                {
                    b.HasOne("DMS.Api.Models.Guardian", "Guardian")
                        .WithOne("Address")
                        .HasForeignKey("DMS.Api.Models.Address", "GuardianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMS.Api.Models.School", "School")
                        .WithOne("Address")
                        .HasForeignKey("DMS.Api.Models.Address", "SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guardian");

                    b.Navigation("School");
                });

            modelBuilder.Entity("DMS.Api.Models.Child", b =>
                {
                    b.HasOne("DMS.Api.Models.ClassRoom", "ClasssRoom")
                        .WithMany("Children")
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMS.Api.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ClasssRoom");

                    b.Navigation("School");
                });

            modelBuilder.Entity("DMS.Api.Models.ClassRoom", b =>
                {
                    b.HasOne("DMS.Api.Models.School", "School")
                        .WithMany("ClassRooms")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("DMS.Api.Models.Location", b =>
                {
                    b.HasOne("DMS.Api.Models.Address", "Address")
                        .WithOne("Location")
                        .HasForeignKey("DMS.Api.Models.Location", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DMS.Api.Models.Pantry", b =>
                {
                    b.HasOne("DMS.Api.Models.ClassRoom", "ClassRoom")
                        .WithOne("Pantry")
                        .HasForeignKey("DMS.Api.Models.Pantry", "ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");
                });

            modelBuilder.Entity("DMS.Api.Models.Student", b =>
                {
                    b.HasOne("DMS.Api.Models.School", null)
                        .WithMany("Students")
                        .HasForeignKey("SchoolId1");
                });

            modelBuilder.Entity("DMS.Api.Models.Address", b =>
                {
                    b.Navigation("Location")
                        .IsRequired();
                });

            modelBuilder.Entity("DMS.Api.Models.ClassRoom", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Pantry");
                });

            modelBuilder.Entity("DMS.Api.Models.Guardian", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("DMS.Api.Models.School", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("ClassRooms");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
