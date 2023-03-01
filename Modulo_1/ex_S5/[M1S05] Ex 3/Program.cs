using System;
using _M1S05__Ex_3;
using _M1S05__Ex_3.Classes;

class Program
{
    static void Main(string[] args)
    {
        Evento evento = new Evento();

        evento.QtdIngressosVendidos = 15;
        evento.QtdLugares = 20;

        try
        {
            if (evento.QtdLugares - evento.QtdIngressosVendidos > 0)
            {
                Console.WriteLine("Ingresso validado!");
                evento.ingressoVendido();
            }
            else
            {
                throw new IngressoException("Não existem mais lugares" +
                    " disponíveis para o evento");
            }
        }
        catch (IngressoException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

