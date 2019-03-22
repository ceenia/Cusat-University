using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cusat_University.Models;

namespace Cusat_University.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}