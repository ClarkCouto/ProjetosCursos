using System;
using System.Globalization;

namespace Primeiro_Projeto
{
    internal class Menu
    {
        private static void Main(string[] args)
        {
            bool sair = false;
            int opcao;
            do
            {
                Console.WriteLine("\nMenu..." +
                    "\n1 - Entrada de Dados" +
                    "\n2 - Fórmula de Báskara" +
                    "\n0 - Sair");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 0:
                            sair = true;
                            break;
                        case 1:
                            LeituraDeDados.LerDados();
                            break;
                        case 2:
                            FormulaBaskara.Calcular();
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Opção Inválida!");
                }
            }
            while (!sair);

            
        }
    }
}