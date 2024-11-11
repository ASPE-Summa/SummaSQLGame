﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SummaSQLGame.Databases;

#nullable disable

namespace SummaSQLGame.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241111153752_Seed Students")]
    partial class SeedStudents
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("SummaSQLGame.Models.Adventurer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("Charisma")
                        .HasColumnType("INTEGER")
                        .HasColumnName("charisma");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("klasse");

                    b.Property<int>("Constitution")
                        .HasColumnType("INTEGER")
                        .HasColumnName("constitutie");

                    b.Property<int>("Dexterity")
                        .HasColumnType("INTEGER")
                        .HasColumnName("behendigheid");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER")
                        .HasColumnName("intelligentie");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER")
                        .HasColumnName("niveau");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("naam");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER")
                        .HasColumnName("kracht");

                    b.Property<int>("Wisdom")
                        .HasColumnType("INTEGER")
                        .HasColumnName("wijsheid");

                    b.HasKey("Id");

                    b.ToTable("avonturier");
                });

            modelBuilder.Entity("SummaSQLGame.Models.Anime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("engelsenaam");

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("genres");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("naam");

                    b.Property<decimal?>("Score")
                        .HasColumnType("decimal(2,1)")
                        .HasColumnName("score");

                    b.Property<string>("Studios")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("studios");

                    b.Property<string>("Synopsis")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("omschrijving");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("anime");
                });

            modelBuilder.Entity("SummaSQLGame.Models.BattleShip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Coordinates")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT")
                        .HasColumnName("coordinaat");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("omschrijving");

                    b.HasKey("Id");

                    b.ToTable("zeeslag");
                });

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

            modelBuilder.Entity("SummaSQLGame.Models.Button", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Emoji")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("emoji");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("naam");

                    b.HasKey("Id");

                    b.ToTable("knop");
                });

            modelBuilder.Entity("SummaSQLGame.Models.ButtonSafety", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("ButtonId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("knop_id");

                    b.Property<bool>("IsSafe")
                        .HasColumnType("INTEGER")
                        .HasColumnName("is_veilig");

                    b.HasKey("Id");

                    b.HasIndex("ButtonId")
                        .IsUnique();

                    b.ToTable("knopveiligheid");
                });

            modelBuilder.Entity("SummaSQLGame.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int?>("CountryId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("land");

                    b.Property<bool>("IsCapital")
                        .HasColumnType("INTEGER")
                        .HasColumnName("is_hoofdstad");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("naam");

                    b.Property<int?>("Population")
                        .HasColumnType("INTEGER")
                        .HasColumnName("inwoners");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("stad");
                });

            modelBuilder.Entity("SummaSQLGame.Models.Country", b =>
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

                    b.HasKey("Id");

                    b.ToTable("land");
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

            modelBuilder.Entity("SummaSQLGame.Models.MazePuzzle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("inhoud");

                    b.Property<int>("Pattern")
                        .HasColumnType("INTEGER")
                        .HasColumnName("patroon");

                    b.Property<int>("Sequence")
                        .HasColumnType("INTEGER")
                        .HasColumnName("regelnummer");

                    b.HasKey("Id");

                    b.ToTable("doolhof");
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

                    b.Property<long?>("Streams")
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

            modelBuilder.Entity("SummaSQLGame.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("ArtScore")
                        .HasColumnType("INTEGER")
                        .HasColumnName("kunst");

                    b.Property<int>("ChemistryScore")
                        .HasColumnType("INTEGER")
                        .HasColumnName("scheikunde");

                    b.Property<int>("EnglishScore")
                        .HasColumnType("INTEGER")
                        .HasColumnName("engels");

                    b.Property<int>("GeographyScore")
                        .HasColumnType("INTEGER")
                        .HasColumnName("aardrijkskunde");

                    b.Property<int>("Group")
                        .HasColumnType("INTEGER")
                        .HasColumnName("klas");

                    b.Property<int>("HistoryScore")
                        .HasColumnType("INTEGER")
                        .HasColumnName("geschiedenis");

                    b.Property<int>("MathScore")
                        .HasColumnType("INTEGER")
                        .HasColumnName("rekenen");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("naam");

                    b.HasKey("Id");

                    b.ToTable("student");
                });

            modelBuilder.Entity("SummaSQLGame.Models.ButtonSafety", b =>
                {
                    b.HasOne("SummaSQLGame.Models.Button", "Button")
                        .WithOne("ButtonSafety")
                        .HasForeignKey("SummaSQLGame.Models.ButtonSafety", "ButtonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Button");
                });

            modelBuilder.Entity("SummaSQLGame.Models.City", b =>
                {
                    b.HasOne("SummaSQLGame.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("SummaSQLGame.Models.Button", b =>
                {
                    b.Navigation("ButtonSafety")
                        .IsRequired();
                });

            modelBuilder.Entity("SummaSQLGame.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
