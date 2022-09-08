using System;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.IO;
using Newtonsoft.Json;


namespace teste_3
{
    class Dados
    {

         public static void TrablahandoDados()
          {

            //Declaração de variáveis
            List<DadosMensal> dados = null;
            float aux = 0;
            float menor = 0;
            float maior = 0;
            float media = 0;
            float soma = 0;
            string diasFaturamento=" ";


            using (StreamReader sr = new StreamReader(@"C:\Users\tec.tinf.ti6\source\repos\teste 3\dados.json"))
            {
                //Deserializando o objeto
                string jsonString = sr.ReadToEnd();
                dados = JsonConvert.DeserializeObject<List<DadosMensal>>(jsonString);


                //Listando os dados em tela

                foreach (DadosMensal dadoscoletados in dados)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(string.Format("dia: {0} \nvalor: {1} ", dadoscoletados.dia, dadoscoletados.valor));
                    

                }

                // Calculando maior e menor faturamento, média e conferindo os dias acima da média
                foreach (DadosMensal dadoscoletados in dados)
                { 
                    
                    if(dadoscoletados.valor != 0)
                    {
                        aux = dadoscoletados.valor;
                        
                        if (aux > maior)
                        {
                            maior = aux;

                            if (menor == 0)
                            {
                                menor = aux;
                            }
                            
                        }
                        if (menor == 0)
                        {
                            menor = aux;
                        }

                        if (aux < menor)
                        {
                            menor = aux;
                        }

                        soma += dadoscoletados.valor;

                        ;


                        media = soma / 30;

                    }
                   

                   if(dadoscoletados.valor != 0)
                    {
                        if (dadoscoletados.valor < media)
                        {
                            diasFaturamento += (string.Format(dadoscoletados.dia) + " ");
                        }
                    }

                }

                //Mostrando os resultados em tela
                Console.WriteLine($"\nO maior faturamento do mês foi de R$ {maior}");
                Console.WriteLine($"\nO menor faturamento do mês foi de R$ {menor}");
                Console.WriteLine($"\nOs dias que os valores foram acima da média, foram: "+diasFaturamento);


            }
          }
   

    }
}
