using LAPExercise.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace LAPExercise.Services
{
    public class DatabaseService
    {
        #region Private Fields

        private static readonly string _connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database={0};Trusted_Connection=True;";
        private static readonly string _createDB = @"CREATE DATABASE [dbmovie] CONTAINMENT = NONE ON  PRIMARY ( NAME = N'dbmovie', FILENAME = N'C:\Users\phili\dbmovie.mdf' , SIZE = 8192KB , FILEGROWTH = 65536KB )";
        private static readonly string _createTable = "CREATE TABLE [dbmovie].[dbo].[Premiere]([Id] [int] IDENTITY(1,1) NOT NULL, [Filmtitel] [varchar](50) NULL, [Genre] [varchar](50) NULL, [Jahr] [int] NULL,	[Regie] [varchar](50) NULL)";
        private static readonly string _dropDB = "IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = 'dbmovie')) BEGIN USE master ALTER DATABASE [dbmovie] SET OFFLINE WITH ROLLBACK IMMEDIATE ALTER DATABASE [dbmovie] SET ONLINE DROP DATABASE [dbmovie] END";
        private static readonly string _insertRow = "INSERT INTO [dbmovie].[dbo].[Premiere] ([Filmtitel],[Genre],[Jahr],[Regie]) VALUES ('{0}','{1}',{2},'{3}')";

        private readonly List<(string, string, Func<string, bool>)> _workflow = new List<(string, string, Func<string, bool>)>()
        {
            ( "Drop Database", _dropDB, new Func<string, bool>(ExecuteCommand)),
            ( "Create Database", _createDB, new Func<string, bool>(ExecuteCommand)),
            ( "Create Table", _createTable, new Func<string, bool>(ExecuteCommand)),
            ( "Insert Data", "", null)
        };

        #endregion Private Fields

        #region Public Constructors

        public DatabaseService()
        {
        }

        #endregion Public Constructors

        #region Public Methods

        public Dictionary<string, bool> ExecuteWorkflow(ICollection<Movie> data)
        {
            var result = new Dictionary<string, bool>();

            foreach (var step in _workflow)
            {
                if (step.Item3 == null)
                    result.Add(step.Item1, InsertData(data));
                else
                    result.Add(step.Item1, step.Item3.Invoke(step.Item2));
            }

            return result;
        }

        public static bool CreateDatabase()
        {
            //using (SqlConnection con = new SqlConnection(string.Format(_connectionString, "master")))
            //{
            //    con.Open();

            //    foreach (var step in _workflow)
            //    {
            //        using (SqlCommand command = new SqlCommand(step.Value, con))
            //            command.ExecuteReader();
            //    }
            //}

            return true;
        }

        public static bool ExecuteCommand(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(string.Format(_connectionString, "master")))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand(query, con))
                        command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool InsertData(ICollection<Movie> data)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(string.Format(_connectionString, "dbmovie")))
                {
                    con.Open();

                    foreach (var item in data)
                    {
                        var sb = new StringBuilder();
                        foreach (var director in item.MovieDirectors)
                            sb.Append($"{director.Person.FirstName} {director.Person.LastName}, ");

                        using (SqlCommand command = new SqlCommand(string.Format(_insertRow, item.Title1, item.Genre.Name, item.Premiere.Year, sb.ToString()), con))
                            command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion Public Methods
    }
}