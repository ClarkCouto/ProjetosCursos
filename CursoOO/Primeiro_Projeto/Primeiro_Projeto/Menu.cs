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
                    "\n3 - Média de Idades" +
                    "\n4 - Exercícios de Revisão 1" +
                    "\n0 - Sair");
                try
                {
                    Console.Write("Digite a opção desejada: ");
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
                        case 3:
                            MediaIdades.Calcular();
                            break;
                        case 4:
                            MenuExerciciosRevisao1();
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

        public static void MenuExerciciosRevisao1()
        {
            bool sair = false;
            int opcao;
            do
            {
                Console.WriteLine("\nMenu - Exercícios de Revisão 1" +
                    "\n 1 - Agricultor" +
                    "\n 2 - " +
                    "\n 3 - " +
                    "\n 4 - " +
                    "\n 5 - " +
                    "\n 6 - " +
                    "\n 7 - " +
                    "\n 8 - " +
                    "\n 9 - " +
                    "\n10 - " +
                    "\n0 - Voltar menu principal");
                try
                {
                    Console.Write("Digite a opção desejada: ");
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 0:
                            Main(new string[1]);
                            break;
                        case 1:
                            ExerciciosRevisao1.Exercicio1();
                            break;
                        case 2:
                            ExerciciosRevisao1.Exercicio2();
                            break;
                        case 3:
                            ExerciciosRevisao1.Exercicio3();
                            break;
                        case 4:
                            ExerciciosRevisao1.Exercicio4();
                            break;
                        case 5:
                            ExerciciosRevisao1.Exercicio5();
                            break;
                        case 6:
                            ExerciciosRevisao1.Exercicio6();
                            break;
                        case 7:
                            ExerciciosRevisao1.Exercicio7();
                            break;
                        case 8:
                            ExerciciosRevisao1.Exercicio8();
                            break;
                        case 9:
                            ExerciciosRevisao1.Exercicio9();
                            break;
                        case 10:
                            ExerciciosRevisao1.Exercicio10();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Opção Inválida!");
                }
            }
            while (!sair);
        }
    }
}