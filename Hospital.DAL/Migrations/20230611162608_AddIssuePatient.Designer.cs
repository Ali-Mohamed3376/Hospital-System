﻿// <auto-generated />
using System;
using Hospital.DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.DAL.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20230611162608_AddIssuePatient")]
    partial class AddIssuePatient
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital.DAL.Data.Models.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerofrmancRate")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("97225962-a3e6-4164-afee-4890316219a9"),
                            Name = "Jessie",
                            PerofrmancRate = 65,
                            Salary = 27064m,
                            Specialization = "Hematology"
                        },
                        new
                        {
                            Id = new Guid("cda184ab-a264-4e17-be85-936a9e48cee0"),
                            Name = "Judy",
                            PerofrmancRate = 32,
                            Salary = 18711m,
                            Specialization = "Neurology"
                        },
                        new
                        {
                            Id = new Guid("51a6ee9b-7b12-4e08-9001-797e15ac9cea"),
                            Name = "Naomi",
                            PerofrmancRate = 27,
                            Salary = 32145m,
                            Specialization = "Pediatrics"
                        },
                        new
                        {
                            Id = new Guid("7f52bb02-18b1-4408-aafe-46b78e6b1d36"),
                            Name = "Joann",
                            PerofrmancRate = 72,
                            Salary = 9232m,
                            Specialization = "Hematology"
                        },
                        new
                        {
                            Id = new Guid("03efcb95-5e1a-4f9c-aec6-1c2d4f264a0d"),
                            Name = "Judy",
                            PerofrmancRate = 19,
                            Salary = 48498m,
                            Specialization = "Dermatology"
                        },
                        new
                        {
                            Id = new Guid("a706347d-d9a1-47f7-ab24-eefb7eea4764"),
                            Name = "Alyssa",
                            PerofrmancRate = 79,
                            Salary = 16586m,
                            Specialization = "Gastroenterology"
                        },
                        new
                        {
                            Id = new Guid("b44db332-b90f-40a4-b9b9-963af56374ac"),
                            Name = "Mable",
                            PerofrmancRate = 5,
                            Salary = 33706m,
                            Specialization = "Infectious Disease"
                        },
                        new
                        {
                            Id = new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"),
                            Name = "Paula",
                            PerofrmancRate = 0,
                            Salary = 19094m,
                            Specialization = "Urology"
                        },
                        new
                        {
                            Id = new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"),
                            Name = "Rafael",
                            PerofrmancRate = 97,
                            Salary = 12266m,
                            Specialization = "Pediatrics"
                        },
                        new
                        {
                            Id = new Guid("c48f6ce2-3d99-4292-b559-baf240066b49"),
                            Name = "Sara",
                            PerofrmancRate = 82,
                            Salary = 45041m,
                            Specialization = "Pediatrics"
                        });
                });

            modelBuilder.Entity("Hospital.DAL.Data.Models.Issue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Issues");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a24c44ad-95e0-4932-8bf3-ef9034b96f94"),
                            Name = "Diabetes"
                        },
                        new
                        {
                            Id = new Guid("51f4b325-e243-4ff8-be07-8e9bf691a318"),
                            Name = "Hypertension"
                        },
                        new
                        {
                            Id = new Guid("ca98f47e-0990-4c2d-978e-09368d4b1087"),
                            Name = "Asthma"
                        },
                        new
                        {
                            Id = new Guid("d062eabd-5fc2-4492-b526-615c1a068f17"),
                            Name = "Depression"
                        },
                        new
                        {
                            Id = new Guid("0fb93ac5-da32-4e92-9e31-37f87169212a"),
                            Name = "Arthritis"
                        },
                        new
                        {
                            Id = new Guid("36c53a71-4207-43cb-a75e-0468b2ff07d4"),
                            Name = "Allergy"
                        },
                        new
                        {
                            Id = new Guid("0b0b0a0b-da53-4479-a1f2-d7941d86e3f1"),
                            Name = "Flu"
                        });
                });

            modelBuilder.Entity("Hospital.DAL.Data.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dee2daab-0f63-41a5-89f8-27c2c9471358"),
                            DoctorId = new Guid("a706347d-d9a1-47f7-ab24-eefb7eea4764"),
                            Name = "Dana"
                        },
                        new
                        {
                            Id = new Guid("f6c44400-ba1a-4e90-9546-2c77c9d56330"),
                            DoctorId = new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"),
                            Name = "Isaac"
                        },
                        new
                        {
                            Id = new Guid("26237d35-c325-4598-bf3d-fcf18b2e54a4"),
                            DoctorId = new Guid("c48f6ce2-3d99-4292-b559-baf240066b49"),
                            Name = "Damon"
                        },
                        new
                        {
                            Id = new Guid("1a4be103-2933-4535-a3e5-2b4a4e65bfe4"),
                            DoctorId = new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"),
                            Name = "Miriam"
                        },
                        new
                        {
                            Id = new Guid("f1f0699f-2323-44e9-9824-3dbfbb81a141"),
                            DoctorId = new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"),
                            Name = "Terence"
                        },
                        new
                        {
                            Id = new Guid("e7a97a6c-b75e-4fda-b857-53fd26a20079"),
                            DoctorId = new Guid("cda184ab-a264-4e17-be85-936a9e48cee0"),
                            Name = "Roosevelt"
                        },
                        new
                        {
                            Id = new Guid("f662257c-ea40-44e1-a9a4-3aac0ca16e8a"),
                            DoctorId = new Guid("c48f6ce2-3d99-4292-b559-baf240066b49"),
                            Name = "Eduardo"
                        },
                        new
                        {
                            Id = new Guid("d33c8283-652e-43a3-bcba-15a3127e9045"),
                            DoctorId = new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"),
                            Name = "Wilbert"
                        },
                        new
                        {
                            Id = new Guid("1816d481-1111-46e8-9a58-03c8a4bbae8b"),
                            DoctorId = new Guid("a706347d-d9a1-47f7-ab24-eefb7eea4764"),
                            Name = "Tasha"
                        },
                        new
                        {
                            Id = new Guid("e7be5cbb-1a94-48a7-a869-a352fe40f3eb"),
                            DoctorId = new Guid("cda184ab-a264-4e17-be85-936a9e48cee0"),
                            Name = "Max"
                        },
                        new
                        {
                            Id = new Guid("e614b831-9c2d-40e7-84c1-b28318e5555c"),
                            DoctorId = new Guid("51a6ee9b-7b12-4e08-9001-797e15ac9cea"),
                            Name = "Bridget"
                        },
                        new
                        {
                            Id = new Guid("e3941d18-dbea-4987-80e5-207a95245111"),
                            DoctorId = new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"),
                            Name = "Juan"
                        },
                        new
                        {
                            Id = new Guid("5eabf55d-3f3b-4a43-b67c-a2c2666b6c9c"),
                            DoctorId = new Guid("97225962-a3e6-4164-afee-4890316219a9"),
                            Name = "Krystal"
                        },
                        new
                        {
                            Id = new Guid("56acd34f-2436-49b8-bfe8-5d826c8ae458"),
                            DoctorId = new Guid("97225962-a3e6-4164-afee-4890316219a9"),
                            Name = "Erma"
                        },
                        new
                        {
                            Id = new Guid("056a1606-1987-4c4b-b575-1b6654f57d8c"),
                            DoctorId = new Guid("b44db332-b90f-40a4-b9b9-963af56374ac"),
                            Name = "Orlando"
                        },
                        new
                        {
                            Id = new Guid("6c4cb1a2-9bb6-42c1-9b37-585fc318523e"),
                            DoctorId = new Guid("a706347d-d9a1-47f7-ab24-eefb7eea4764"),
                            Name = "Marvin"
                        },
                        new
                        {
                            Id = new Guid("cef3e1b5-d6d9-4300-b8b4-38cfe2282c6a"),
                            DoctorId = new Guid("03efcb95-5e1a-4f9c-aec6-1c2d4f264a0d"),
                            Name = "Lamar"
                        },
                        new
                        {
                            Id = new Guid("3b5766e3-f644-445b-98bf-10c61d094d93"),
                            DoctorId = new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"),
                            Name = "Joe"
                        },
                        new
                        {
                            Id = new Guid("74bea655-3096-4d4c-a42e-18dcdf27dcd1"),
                            DoctorId = new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"),
                            Name = "Wendell"
                        },
                        new
                        {
                            Id = new Guid("c3156684-7bf9-4a07-b636-e0826f61bb21"),
                            DoctorId = new Guid("03efcb95-5e1a-4f9c-aec6-1c2d4f264a0d"),
                            Name = "Sandra"
                        },
                        new
                        {
                            Id = new Guid("550f318f-0aa2-44f8-b85b-aecc53d42cd9"),
                            DoctorId = new Guid("b44db332-b90f-40a4-b9b9-963af56374ac"),
                            Name = "Stephanie"
                        },
                        new
                        {
                            Id = new Guid("dfdfc5b0-cac9-44bf-8289-4699b4144a1a"),
                            DoctorId = new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"),
                            Name = "Ervin"
                        },
                        new
                        {
                            Id = new Guid("20c6a260-18b2-4d05-a79a-92b9bd1b1531"),
                            DoctorId = new Guid("03efcb95-5e1a-4f9c-aec6-1c2d4f264a0d"),
                            Name = "Beth"
                        },
                        new
                        {
                            Id = new Guid("6450b07a-b86d-4db7-aefd-922457274719"),
                            DoctorId = new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"),
                            Name = "Gretchen"
                        },
                        new
                        {
                            Id = new Guid("fd749cfa-82f2-45b3-9bca-3fe429548879"),
                            DoctorId = new Guid("51a6ee9b-7b12-4e08-9001-797e15ac9cea"),
                            Name = "Gwendolyn"
                        },
                        new
                        {
                            Id = new Guid("b174ef30-6134-477a-a8a5-56cd6f63eaf7"),
                            DoctorId = new Guid("703cc86f-7dea-40c9-a263-b3c70b2959bf"),
                            Name = "Jerry"
                        },
                        new
                        {
                            Id = new Guid("b1eb033a-46d4-4945-831a-44f8afcf0702"),
                            DoctorId = new Guid("b44db332-b90f-40a4-b9b9-963af56374ac"),
                            Name = "Mitchell"
                        },
                        new
                        {
                            Id = new Guid("5ced8a42-b135-4d66-a860-43be12b4f778"),
                            DoctorId = new Guid("3c6666cd-f381-4061-9434-39ef03b8af9a"),
                            Name = "Maggie"
                        },
                        new
                        {
                            Id = new Guid("423afa12-31ee-4516-a1ba-f6c39d715c09"),
                            DoctorId = new Guid("7f52bb02-18b1-4408-aafe-46b78e6b1d36"),
                            Name = "Sandy"
                        },
                        new
                        {
                            Id = new Guid("801a65f4-f68f-44a2-8259-e067c6b23308"),
                            DoctorId = new Guid("51a6ee9b-7b12-4e08-9001-797e15ac9cea"),
                            Name = "Lloyd"
                        });
                });

            modelBuilder.Entity("IssuePatient", b =>
                {
                    b.Property<Guid>("IssuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IssuesId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("IssuePatient");
                });

            modelBuilder.Entity("Hospital.DAL.Data.Models.Patient", b =>
                {
                    b.HasOne("Hospital.DAL.Data.Models.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("IssuePatient", b =>
                {
                    b.HasOne("Hospital.DAL.Data.Models.Issue", null)
                        .WithMany()
                        .HasForeignKey("IssuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.DAL.Data.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital.DAL.Data.Models.Doctor", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
