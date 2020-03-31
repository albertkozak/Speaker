﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpeakerAPI.Data;

namespace SpeakerAPI.Data.Migrations
{
    [DbContext(typeof(SpeakerDbContext))]
    [Migration("20200331211936_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpeakerLibrary.Speaker", b =>
                {
                    b.Property<string>("SpeakerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpeakerId");

                    b.ToTable("Speakers");

                    b.HasData(
                        new
                        {
                            SpeakerId = "bd7f16df-ee6a-402f-aeb4-96e0b64de30d",
                            City = "Vancouver",
                            Email = "jdoe@gmail.com",
                            Employer = "UBC",
                            FirstName = "John",
                            LastName = "Doe",
                            MobileNumber = "604-123-4567",
                            Province = "BC",
                            Specialization = "JavaScript"
                        },
                        new
                        {
                            SpeakerId = "8b3017b4-2882-432f-be4f-5cc60821d532",
                            City = "Maple Ridge",
                            Email = "pweier@gmail.com",
                            Employer = "BCIT",
                            FirstName = "Phil",
                            LastName = "Weier",
                            MobileNumber = "604-987-6543",
                            Province = "BC",
                            Specialization = ".NET"
                        },
                        new
                        {
                            SpeakerId = "1696df16-1aa4-4058-841f-ce95d48b7ee2",
                            City = "Vancouver",
                            Email = "jharrison@gmail.com",
                            Employer = "SFU",
                            FirstName = "Jason",
                            LastName = "Harrison",
                            MobileNumber = "604-111-1111",
                            Province = "BC",
                            Specialization = "Laravel"
                        },
                        new
                        {
                            SpeakerId = "172aa0ac-bc8b-4f4c-ad71-b1fb2ec6c9a1",
                            City = "Chilliwack",
                            Email = "acooper@gmail.com",
                            Employer = "BCIT",
                            FirstName = "Alex",
                            LastName = "Cooper",
                            MobileNumber = "604-2121-2121",
                            Province = "BC",
                            Specialization = "HTML/CSS"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
