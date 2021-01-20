using LAPExercise.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LAPExercise.Data
{
    public class DatabaseContext : DbContext
    {
        #region Public Constructors

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> Persons { get; set; }

        #endregion Public Properties

        #region Protected Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre() { Id = 1, Name = "Komödie" },
                new Genre() { Id = 2, Name = "Drama" },
                new Genre() { Id = 3, Name = "Thriller" },
                new Genre() { Id = 4, Name = "SciFi" },
                new Genre() { Id = 5, Name = "Zeichentrick" },
                new Genre() { Id = 6, Name = "Krimi" },
                new Genre() { Id = 7, Name = "Musical" },
                new Genre() { Id = 8, Name = "Dokumentation" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title1 = "Zoomania", Title2 = null, Premiere = new DateTime(2016, 03, 03), GenreId = 5 },
                new Movie() { Id = 2, Title1 = "Batman V Superman: Daw of Justice", Title2 = null, Premiere = new DateTime(2016, 03, 19), GenreId = 4 },
                new Movie() { Id = 3, Title1 = "A Good American", Title2 = "NSA", Premiere = new DateTime(2015, 11, 10), GenreId = 8 },
                new Movie() { Id = 4, Title1 = "Maria Stuart", Title2 = "Königin von Schottland", Premiere = new DateTime(2018, 12, 07), GenreId = 2 },
                new Movie() { Id = 5, Title1 = "Der Herr der Ringe", Title2 = "Die Gefährten", Premiere = new DateTime(2001, 12, 19), GenreId = 2 },
                new Movie() { Id = 6, Title1 = "Der Herr der Ringe", Title2 = "Die zwei Türme", Premiere = new DateTime(2002, 12, 18), GenreId = 2 },
                new Movie() { Id = 7, Title1 = "Der Herr der Ringe", Title2 = "Die Rückkehr des Königs", Premiere = new DateTime(2003, 12, 17), GenreId = 2 }
            );

            modelBuilder.Entity<Person>().HasData(
                new Person() { Id = 1, FirstName = "Ben", SecondFirstName = null, LastName = "Affleck" },
                new Person() { Id = 2, FirstName = "Henry", SecondFirstName = null, LastName = "Cavill" },
                new Person() { Id = 3, FirstName = "William", SecondFirstName = null, LastName = "Binney" },
                new Person() { Id = 4, FirstName = "Helena", SecondFirstName = "Bonham", LastName = "Carter" },
                new Person() { Id = 5, FirstName = "Saorise", SecondFirstName = null, LastName = "Ronan" },
                new Person() { Id = 6, FirstName = "Margot", SecondFirstName = null, LastName = "Robbie" },
                new Person() { Id = 7, FirstName = "Byron", SecondFirstName = null, LastName = "Howard" },
                new Person() { Id = 8, FirstName = "Rich", SecondFirstName = null, LastName = "Moor" },
                new Person() { Id = 9, FirstName = "Zack", SecondFirstName = null, LastName = "Snyder" },
                new Person() { Id = 10, FirstName = "Friedrich", SecondFirstName = null, LastName = "Moser" },
                new Person() { Id = 11, FirstName = "Josie", SecondFirstName = null, LastName = "Rourke" }
            );

            modelBuilder.Entity<MovieActor>().HasData(
                new MovieActor() { Id = 1, PersonId = 1, MovieId = 2 },
                new MovieActor() { Id = 2, PersonId = 2, MovieId = 2 },
                new MovieActor() { Id = 3, PersonId = 3, MovieId = 3 },
                new MovieActor() { Id = 4, PersonId = 6, MovieId = 4 }
            );

            modelBuilder.Entity<MovieDirector>().HasData(
                new MovieActor() { Id = 1, PersonId = 7, MovieId = 1 },
                new MovieActor() { Id = 2, PersonId = 8, MovieId = 1 },
                new MovieActor() { Id = 3, PersonId = 9, MovieId = 2 },
                new MovieActor() { Id = 4, PersonId = 10, MovieId = 3 },
                new MovieActor() { Id = 5, PersonId = 11, MovieId = 4 }
            );

        }

        #endregion Protected Methods
    }
}