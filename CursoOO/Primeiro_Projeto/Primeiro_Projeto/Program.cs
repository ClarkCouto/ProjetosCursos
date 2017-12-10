using System;
using System.Globalization;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Olá Mundo!");
            Double numero = 10.35784;
            Console.WriteLine(numero.ToString("F2")); /*Imprime conforme a localização do computador (Brasil imprime ,)*/
            Console.WriteLine(numero.ToString("F4"), CultureInfo.InvariantCulture); /* Imprime sempre usando . ao invés de , */
            Console.ReadLine();

        }
    }
}
