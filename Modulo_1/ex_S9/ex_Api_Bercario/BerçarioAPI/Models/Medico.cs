using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerçarioAPI.Models
{
    public class Medico
    {
        public int ID { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Especialidade { get; set; }
    }
}