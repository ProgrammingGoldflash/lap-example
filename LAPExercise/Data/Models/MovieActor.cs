using System.ComponentModel.DataAnnotations;

namespace LAPExercise.Data.Models
{
    public class MovieActor : BaseModel
    {
        #region Public Properties

        public virtual Movie Movie { get; set; }

        [Required]
        public int MovieId { get; set; }

        public virtual Person Person { get; set; }

        [Required]
        public int PersonId { get; set; }

        #endregion Public Properties
    }
}