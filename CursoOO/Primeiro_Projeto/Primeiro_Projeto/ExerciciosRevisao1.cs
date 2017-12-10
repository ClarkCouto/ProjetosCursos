using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro_Projeto
{
    public class ExerciciosRevisao1
    {
        public static void Exercicio1()
        {
            Console.WriteLine("\nExercício 1 - Revisão 1");
            Console.WriteLine("\tUm agricultor precisa aplicar veneno em suas plantações. Para isso ele precisa escolher um frasco e\n" +
                              "\tuma bomba para aplicação.O frasco de veneno possui um volume de veneno líquido medido em ml(mililitro).\n" +
                              "\tJá a bomba de aplicação possui uma vazão * medida em ml / s(mililitro por segundo).O agricultor deseja\n" +
                              "\tsaber: dado o volume inicial de um frasco de veneno(em ml), a vazão da bomba(em ml / s), e um tempo(em s),\n" +
                              "\tqual volume de veneno restará no frasco após o uso da bomba durante este tempo?\n");

            int volumeFrasco = 0 , vazaoBomba = 0, tempoUtilizacao = 0;

            //Ler o valor de A
            bool valido = false;
            do
            {
                try
                {
                    Console.Write("Digite o volume do frasco (em ml): ");
                    volumeFrasco = int.Parse(Console.ReadLine());
                    valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            while (!valido);
            valido = false;
            do
            {
                try
                {
                    Console.Write("Digite a vazão da bomba (em ml/s): ");
                    vazaoBomba = int.Parse(Console.ReadLine());
                    valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            while (!valido);
            valido = false;
            do
            {
                try
                {
                    Console.Write("Digite o tempo de utilização (em s): ");
                    tempoUtilizacao = int.Parse(Console.ReadLine());
                    valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            while (!valido);

            int quantidadeUtilizada = vazaoBomba * tempoUtilizacao;
            int quantidadeRestante = volumeFrasco - quantidadeUtilizada;

            if (quantidadeRestante >= 0)
                Console.WriteLine("Sobrou " + quantidadeRestante + "ml no frasco\n");
            if (quantidadeRestante < 0)
                Console.WriteLine("Erro! Quantidade utilizada maior que a quantidade disponível!\n");
        }
        public static void Exercicio2()
        {
            Console.WriteLine("Exercício 2 - Revisão 1");
        }
        public static void Exercicio3()
        {
            Console.WriteLine("Exercício 3 - Revisão 1");
        }
        public static void Exercicio4()
        {
            Console.WriteLine("Exercício 4 - Revisão 1");
        }
        public static void Exercicio5()
        {
            Console.WriteLine("Exercício 5 - Revisão 1");

        }
        public static void Exercicio6()
        {
            Console.WriteLine("Exercício 6 - Revisão 1");

        }
        public static void Exercicio7()
        {
            Console.WriteLine("Exercício 7 - Revisão 1");

        }
        public static void Exercicio8()
        {
            Console.WriteLine("Exercício 8 - Revisão 1");

        }
        public static void Exercicio9()
        {
            Console.WriteLine("Exercício 9 - Revisão 1");

        }
        public static void Exercicio10()
        {
            Console.WriteLine("Exercício 10 - Revisão 1");

        }

    }
}
