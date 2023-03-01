using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _M1S05__Ex_3.Classes
{
    public class Evento
    {
        int qtdLugares;
        int qtdIngressosVendidos;

        public Evento()
        {
            
        }

        public int QtdLugares {get; set ;}
        public int QtdIngressosVendidos {get; set ;}

        public void ingressoVendido()
        {
            Console.WriteLine("ingressos vendido com sucesso");
        }


    }
}