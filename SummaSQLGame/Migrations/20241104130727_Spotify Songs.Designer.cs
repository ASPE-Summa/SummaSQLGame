﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SummaSQLGame.Databases;

#nullable disable

namespace SummaSQLGame.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241104130727_Spotify Songs")]
    partial class SpotifySongs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("SummaSQLGame.Models.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<double>("AlcoholPercentage")
                        .HasColumnType("REAL")
                        .HasColumnName("alcoholpercentage");

                    b.Property<string>("Brewery")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("brouwerij");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("land");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("naam");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("soort");

                    b.HasKey("Id");

                    b.ToTable("bieren");
                });

            modelBuilder.Entity("SummaSQLGame.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("naam");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("ras");

                    b.HasKey("Id");

                    b.ToTable("honden");
                });

            modelBuilder.Entity("SummaSQLGame.Models.Songs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Artists")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("artiesten");

                    b.Property<int>("Bpm")
                        .HasColumnType("INTEGER")
                        .HasColumnName("bpm");

                    b.Property<int>("ReleasedYear")
                        .HasColumnType("INTEGER")
                        .HasColumnName("verschijningsjaar");

                    b.Property<int>("Streams")
                        .HasColumnType("INTEGER")
                        .HasColumnName("streams");

                    b.Property<string>("Track")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("titel");

                    b.HasKey("Id");

                    b.ToTable("spotify");
                });
#pragma warning restore 612, 618
        }
    }
}
