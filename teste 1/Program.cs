using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            do
            {
                k = k + 1;
                soma = soma + k;
            }
            while (k < indice);

            Console.WriteLine("o resultado foi:" + soma);
        }
    }
}
