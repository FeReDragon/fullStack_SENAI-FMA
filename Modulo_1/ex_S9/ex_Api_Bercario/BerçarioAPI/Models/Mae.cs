using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerçarioAPI.Models
{
    public class Mae
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Nasc { get; set; }
    }
}