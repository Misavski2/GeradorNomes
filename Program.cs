using System;
using System.Collections.Generic;

namespace GeradorNomes
{
    class Gerador
    {
        static void Main(string[] args)
        {
            List<string> start = new List<string> { "Dark", "Light", "Shadow", "Myth", "God", "Pro" };
            List<string> end = new List<string> { "Zin", "vski", "God", "Ninja", "Knight", "Pro", "Master" };

            Random random = new Random();

            while (true)
            {
                Console.WriteLine("Pressione 'ENTER' para gerar um novo nick ou digite 'sair' para finalizar.");
                string opcao = Console.ReadLine();

                if (opcao.ToLower() == "sair")
                {
                    break;
                }

                //Gerar partes aleatorias
                string stt = start[random.Next(start.Count)];
                string ed = end[random.Next(end.Count)];

                //Juntar 
                string resultado = stt + ed;

                Console.WriteLine("Seu novo nick é: " + resultado);
            }
        }
    }
}