﻿// <auto-generated />
using HMW_SQL_VS_Entity.FootballTeam;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HMW_SQL_VS_Entity.Migrations
{
    [DbContext(typeof(League))]
    [Migration("20220601174734_createFootballDB")]
    partial class createFootballDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HMW_SQL_VS_Entity.FootballTeam.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClubId"), 1L, 1);

                    b.Property<string>("ClubName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClubId");

                    b.ToTable("FootballClubs");
                });

            modelBuilder.Entity("HMW_SQL_VS_Entity.FootballTeam.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"), 1L, 1);

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
