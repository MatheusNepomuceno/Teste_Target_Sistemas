using System;

namespace Teste_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 0;
            int  soma, numeroInformado;

            Console.WriteLine("############## Olá vamos testar se um determinado número é fibonacci? ##################");
            Console.WriteLine("Informe um número:");
            numeroInformado = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<= numeroInformado; i++)
            {
                soma = n1 + n2;
                n2 = n1;
                n1 = soma;
            }

            if (n1 == numeroInformado)
            {
                Console.WriteLine($"O número {numeroInformado} é um fibonacci");
            }
            else
            {
                Console.WriteLine($"O número {numeroInformado} não é um fibonacci");
            }

            Console.ReadKey();
        }
    }
}
