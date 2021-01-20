using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LAPExercise.Data.Models
{
    public class Person : BaseModel
    {
        #region Public Properties

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string SecondFirstName { get; set; }

        #endregion Public Properties
    }
}