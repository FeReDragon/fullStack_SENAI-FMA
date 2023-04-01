using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BercarioAPI.Models
{
    public class Bebe
    {
        public int ID { get; set; }
        public DateTime Data_Nasc { get; set; }
        public decimal Peso_nasc { get; set; }
        public int Altura { get; set; }
        public int ID_mae { get; set; }
        public int ID_Parto { get; set; }

        public Mae Mae { get; set; }
        public Parto Parto { get; set; }
    }
}