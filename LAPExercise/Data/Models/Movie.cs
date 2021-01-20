using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LAPExercise.Data.Models
{
    public class Movie : BaseModel
    {
        #region Public Properties

        public virtual Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        public DateTime Premiere { get; set; }

        [Required]
        public string Title1 { get; set; }

        public string Title2 { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }

        public virtual ICollection<MovieDirector> MovieDirectors { get; set; }

        #endregion Public Properties
    }
}