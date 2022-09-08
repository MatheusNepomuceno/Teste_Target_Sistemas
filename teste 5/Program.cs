using System;

namespace teste_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavraOriginal;
            string palavraInvertida;

            Console.WriteLine("######### Olá, seja bem vindo(a)!! ##################");
            Console.WriteLine("Vamos brincar de inverter uma palavra?");
            Console.WriteLine("Insira uma palavra: ");
            palavraOriginal = Console.ReadLine();

            palavraInvertida= Inversor.Reverse(palavraOriginal);

            Console.WriteLine(palavraInvertida);
        }
    }
}
