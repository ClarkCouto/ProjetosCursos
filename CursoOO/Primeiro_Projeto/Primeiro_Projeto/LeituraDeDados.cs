using System;
using System.Globalization;

namespace Primeiro_Projeto
{
    public class LeituraDeDados
    {
        public static void LerDados()
        {
            Console.WriteLine("Escrever Double formatando as casas decimais...");
            Double numero = 10.35784;
            Console.WriteLine(numero.ToString("F2")); /*Imprime conforme a localização do computador (Brasil imprime ,)*/
            Console.WriteLine(numero.ToString("F4"), CultureInfo.InvariantCulture); /* Imprime sempre usando . ao invés de , */

            Console.WriteLine("Ler um Double...");
            Double x;
            Console.WriteLine("Ler um Double esperando uma , como separador de decimais");
            x = Double.Parse(Console.ReadLine()); /*Ler um double esperando que seja digitado conforme a localização (Brasil separador é ,)*/
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine("Ler um Double esperando um . como separador de decimais");
            x = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); /* Ler um double sempre esperando o separador . */
            Console.WriteLine(x.ToString("F2"));
            Console.ReadLine();

            Console.WriteLine("Leitura de Dados...");
            Console.WriteLine("Lendo uma String..");
            Console.WriteLine("Digite uma String..");
            String str = Console.ReadLine();
            Console.WriteLine("A String digitada foi: " + str);


            Console.WriteLine("Lendo um Integer..");
            Console.WriteLine("Digite um número inteiro..");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("O número inteiro digitado foi: " + i);
            

            Console.WriteLine("Lendo um caractere..");
            Console.WriteLine("Digite um caractere..");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine("O caractere digitado foi: " + c);


            Console.WriteLine("Criar um vetor com os dados de uma linha seperados por espaço");
            string[] vetor = Console.ReadLine().Split(' '); /* Criar um vetor com os dados digitados separados por espaço */

            Console.WriteLine("Quantidade de elementos: " + vetor.Length);
            foreach (String s in vetor)
            {
                Console.WriteLine(s);
            }

        }
    }
}
