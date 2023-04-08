using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola_Bd_Api.Models
{
    public class StudentDiscipline
    {
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int DisciplineId { get; set; }
        public Discipline? Discipline { get; set; }
    }
}