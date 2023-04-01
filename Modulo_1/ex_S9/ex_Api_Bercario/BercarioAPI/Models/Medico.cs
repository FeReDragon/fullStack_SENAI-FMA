using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BercarioAPI.Models
{
    public class Medico
    {
        public int ID { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Especialidade { get; set; }

        public ICollection<Parto> Partos { get; set; }

    }
}