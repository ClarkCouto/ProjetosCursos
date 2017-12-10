using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Primeiro_Projeto
{
    public class MediaIdades
    {
        public static void Calcular()
        {
            int idade = 0, soma = 0, quant = 0;
            double media = 0.0;

            try
            {
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Valor inválido!");
            }
            while (idade > 0){
                try
                {
                    soma += idade;
                    quant++;
                    Console.Write("Digite a idade: ");
                    idade = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }

            if(quant == 0)
            {
                Console.WriteLine("IMPOSSÍVEL CALCULAR");
            }
            else
            {
                media = (double) soma / quant;

                Console.WriteLine("Somatório = " + soma);
                Console.WriteLine("Quantidade = " + quant);
                Console.WriteLine("A média das idades digitadas foi: " + media.ToString("F4", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
