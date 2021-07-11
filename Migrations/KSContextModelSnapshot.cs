﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using demo2.Models;

namespace demo2.Migrations
{
    [DbContext(typeof(KSContext))]
    partial class KSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("demo2.Models.Info", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Add")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Changetime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gov")
                        .HasColumnType("int");

                    b.Property<string>("Keyword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Map")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opentime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orgclass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parkinginfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParkinginfoPx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParkinginfoPy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picdescribe1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picdescribe2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picdescribe3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Px")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Py")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Status")
                        .HasColumnType("bigint");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ticketinfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Toldescribe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Travellinginfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Zipcode")
                        .HasColumnType("bigint");

                    b.Property<string>("Zone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ScenicSpots");
                });
#pragma warning restore 612, 618
        }
    }
}
