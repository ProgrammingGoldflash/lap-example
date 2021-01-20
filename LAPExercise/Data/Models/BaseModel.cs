using System.ComponentModel.DataAnnotations;

namespace LAPExercise.Data.Models
{
    public class BaseModel
    {
        #region Public Properties

        [Key]
        public int Id { get; set; }

        #endregion Public Properties
    }
}