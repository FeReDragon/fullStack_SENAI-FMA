using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola_Bd_Api.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string? DisciplineName { get; set; }
        public Teacher? Teacher { get; set; }
    }
}