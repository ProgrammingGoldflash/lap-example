﻿// <auto-generated />
using System;
using LAPExercise.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LAPExercise.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("LAPExercise.Data.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Komödie"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 4,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Zeichentrick"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Krimi"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Musical"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Dokumentation"
                        });
                });

            modelBuilder.Entity("LAPExercise.Data.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Premiere")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 5,
                            Premiere = new DateTime(2016, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title1 = "Zoomania"
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 4,
                            Premiere = new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title1 = "Batman V Superman: Daw of Justice"
                        },
                        new
                        {
                            Id = 3,
                            GenreId = 8,
                            Premiere = new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title1 = "A Good American",
                            Title2 = "NSA"
                        },
                        new
                        {
                            Id = 4,
                            GenreId = 2,
                            Premiere = new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title1 = "Maria Stuart",
                            Title2 = "Königin von Schottland"
                        },
                        new
                        {
                            Id = 5,
                            GenreId = 2,
                            Premiere = new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title1 = "Der Herr der Ringe",
                            Title2 = "Die Gefährten"
                        },
                        new
                        {
                            Id = 6,
                            GenreId = 2,
                            Premiere = new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title1 = "Der Herr der Ringe",
                            Title2 = "Die zwei Türme"
                        },
                        new
                        {
                            Id = 7,
                            GenreId = 2,
                            Premiere = new DateTime(2003, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title1 = "Der Herr der Ringe",
                            Title2 = "Die Rückkehr des Königs"
                        });
                });

            modelBuilder.Entity("LAPExercise.Data.Models.MovieActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("PersonId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 2,
                            PersonId = 1
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 2,
                            PersonId = 2
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 3,
                            PersonId = 3
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 4,
                            PersonId = 6
                        });
                });

            modelBuilder.Entity("LAPExercise.Data.Models.MovieDirector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("PersonId");

                    b.ToTable("MovieDirectors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            PersonId = 7
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 1,
                            PersonId = 8
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 2,
                            PersonId = 9
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 3,
                            PersonId = 10
                        },
                        new
                        {
                            Id = 5,
                            MovieId = 4,
                            PersonId = 11
                        });
                });

            modelBuilder.Entity("LAPExercise.Data.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Ben",
                            LastName = "Affleck"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Henry",
                            LastName = "Cavill"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "William",
                            LastName = "Binney"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Helena",
                            LastName = "Carter",
                            SecondFirstName = "Bonham"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Saorise",
                            LastName = "Ronan"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Margot",
                            LastName = "Robbie"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Byron",
                            LastName = "Howard"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Rich",
                            LastName = "Moor"
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Zack",
                            LastName = "Snyder"
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Friedrich",
                            LastName = "Moser"
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Josie",
                            LastName = "Rourke"
                        });
                });

            modelBuilder.Entity("LAPExercise.Data.Models.Movie", b =>
                {
                    b.HasOne("LAPExercise.Data.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("LAPExercise.Data.Models.MovieActor", b =>
                {
                    b.HasOne("LAPExercise.Data.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LAPExercise.Data.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("LAPExercise.Data.Models.MovieDirector", b =>
                {
                    b.HasOne("LAPExercise.Data.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LAPExercise.Data.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
