using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerçarioAPI.Models
{
    public class Parto
    {
        public int ID { get; set; }
        public int ID_Medico { get; set; }
        public DateTime Data_Parto { get; set; }
        public DateTime Horario_Parto { get; set; }

        public Medico Medico { get; set; }
    }
}
