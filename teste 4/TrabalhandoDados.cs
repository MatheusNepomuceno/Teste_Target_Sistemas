using System;
using System.Collections.Generic;
using System.Text;

namespace teste_4
{
    class TrabalhandoDados
    {

        public static void ConferindoRepresentacao()
        {
            //Declarando variáveis
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double outros = 19849.53;
            double total = 0;

            //Calculando o faturamento total
            total = SP + MG + RJ + ES + outros;

            //Calculando a porcentagem por estado.
            SP = (SP * 100) / total;
            RJ = (RJ * 100) / total;
            MG = (MG * 100) / total;
            ES = (ES * 100) / total;
            outros = (outros * 100) / total;


            //Mostrando resultados em tela

            Console.WriteLine($"O faturamento total mensal da distribuidora: R$ {total}");


            Console.WriteLine($"\nA porcentagem de faturamento por estado é de:");
            Console.WriteLine("\nSP: "+ SP.ToString("F")+" %");
            Console.WriteLine("\nRJ: " + RJ.ToString("F") + " %");
            Console.WriteLine("\nMG: " + MG.ToString("F") + " %");
            Console.WriteLine("\nES: " + ES.ToString("F") + " %");
            Console.WriteLine("\nOutros: " + outros.ToString("F") + " %");


            Console.ReadKey();
        }
    
    }
}
