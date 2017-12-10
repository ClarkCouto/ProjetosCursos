using System;
using System.Collections.Generic;
using System.Globalization;
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

            //Ler o volume do frasco
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

            //Ler a vazão da bomba
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

            //Ler o tempo de utilização
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
            Console.WriteLine("\nExercício 2 - Revisão 1");
            Console.WriteLine("\tDeseja - se fazer um programa para calcular a nota final de um estudante, considerando as " +
                              "\ttrês notas que ele tirou nos três trimestres de seu curso.Caso a nota final do estudante seja " +
                              "\tmenor que 60.00, deve - se mostrar uma mensagem 'DEPENDENCIA' também.\n");

            double nota1 = 0, nota2 = 0, nota3 = 0, media = 0;

            //Ler a nota 1
            bool valido = false;
            do
            {
                try
                {
                    Console.Write("Digite a nota 1: ");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            while (!valido);

            //Ler a nota 2
            valido = false;
            do
            {
                try
                {
                    Console.Write("Digite a nota 2: ");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            while (!valido);

            //Ler a nota 3
            valido = false;
            do
            {
                try
                {
                    Console.Write("Digite a nota 3: ");
                    nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            while (!valido);

            media = (double)(nota1 + nota2 + nota3) / 3;

            Console.WriteLine("Somatório Final = " + (nota1 + nota2 + nota3));

            if(media > 60.00)
                Console.WriteLine("Média Final = " + media.ToString("F2"));
            else
                Console.WriteLine("Média Final = " + media.ToString("F2") + " DEPENDÊNCIA");
        }
        public static void Exercicio3()
        {
            Console.WriteLine("\nExercício 3 - Revisão 1");
            Console.WriteLine("\tDadas as dimensões de uma foto e de um porta retrato, você deve verificar se uma foto cabe\n" +
                              "\tem um porta retrato.Você pode girar a foto 90° para adequá - la à dimensão do porta retrato.\n");

            double nota1 = 0, nota2 = 0;

            //Ler a nota 1
            bool valido = false;
            do
            {
                try
                {
                    Console.Write("Digite a nota 1: ");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            while (!valido);

            //Ler a nota 2
            valido = false;
            do
            {
                try
                {
                    Console.Write("Digite a nota 2: ");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            while (!valido);
        }
        public static void Exercicio4()
        {
            Console.WriteLine("\nExercício 4 - Revisão 1");
            Console.WriteLine("\tFazer um programa para ler a quantidade de glicose no sangue de uma pessoa e depois mostrar\n" +
                              "\tna tela a classificação desta glicose de acordo com a tabela de referência ao lado.\n");
            Console.WriteLine("\tClassificação      Glicose\n" +
                              "\tNormal             Até 100 mg/dl\n" +
                              "\tElevado            Maior que 100 até 140 mg/dl\n" +
                              "\tDiabetes           Maior de 140 mg/dl\n");

        }
        public static void Exercicio5()
        {
            Console.WriteLine("\nExercício 5 - Revisão 1");
            Console.WriteLine("\tNo arremesso de dardo, o atleta tem três chances para lançar o dardo à maior distância que conseguir.\n" +
                              "\tVocê deve criar um programa para, dadas as medidas das três tentativas de lançamento, informar qual foi a maior.\n");

        }
        public static void Exercicio6()
        {
            Console.WriteLine("\nExercício 6 - Revisão 1");
            Console.WriteLine("\tFazer um programa para ler dois números inteiros e mostrar a soma de todos os números ímpares entre eles,\n" +
                              "\tinclusive eles próprios.\n");


        }
        public static void Exercicio7()
        {
            Console.WriteLine("\nExercício 7 - Revisão 1");
            Console.WriteLine("\tLeia números inteiros até que um 0 (zero) seja lido. Para cada valor lido, o programa deve mostrar o \n" +
                              "\tquadrado do valor.\n" +
                              "\tLembrete: você não precisa ler todos dados para só depois começar a mostrar a saída.Você pode ir lendo \n" +
                              "\tum número e mostrando a saída referente a ele, um de cada vez.");

        }
        public static void Exercicio8()
        {
            Console.WriteLine("Exercício 8 - Revisão 1");
            Console.WriteLine("\tLeia três valores inteiros N, A e B. Em seguida, mostrar todos os múltiplos de N contidos no intervalo\n" +
                              "\tA e B (inclusive os próprios valores A e B).\n" +
                              "\tEntrada:\n" +
                              "\tA entrada é composta de três números inteiros N, A e B, respectivamente, sendo A<B (não precisa se preocupar\n" +
                              "\tem verificar se A é menor que B).\n" +
                              "\tSaída:\n" +
                              "\tA saída contém os múltiplos de N entre A e B, sendo um valor por linha.Se não houver nenhum, não se deve\n" +
                              "\timprimir nada.\n");

        }
        public static void Exercicio9()
        {
            Console.WriteLine("Exercício 9 - Revisão 1");
            Console.WriteLine("\tAlexandre está se mordendo de vontade de jogar muito vídeo game depois das provas finais do\n" +
                              "\tprimeiro trimestre. Entretanto, ele quer se prevenir de ficar sem bateria para o controle do vídeo\n" +
                              "\tgame. Para isso, ele deseja se planejar, recarregando completamente a bateria do controle do vídeo\n" +
                              "\tgame, e fazendo um acompanhamento de tempo a cada vez que for jogar.Assim, ele deseja informar quantas\n" +
                              "\tvezes pretende jogar, e quanto tempo vai jogar em cada vez.Você deve construir um programa que informa\n" +
                              "\to tempo restante de cada vez que ele for jogar.\n" +
                              "\tEntrada:" +
                              "\tA entrada consiste do tempo total de duração da bateria completamente recarregada(em horas - ponto\n" +
                              "\tflutuante com uma casa decimal), seguido de um número inteiro N indicando quantas vezes Alexandre\n" +
                              "\tpretende jogar, seguido dos tempos que ele vai jogar em cada vez(em horas - ponto flutuante com uma\n" +
                              "\tcasa decimal).\n" +
                              "\tSaída:\n" +
                              "\tA saída é composta do tempo restante de duração da bateria a cada vez que Alexandre for jogar(em horas -\n" +
                              "\tponto flutuante com uma casa decimal).Se o tempo restante da bateria não for suficiente para uma determinada\n" +
                              "\tvez que Alexandre for jogar, mostrar a palavra 'recarregar'.");
        }
        public static void Exercicio10()
        {
            Console.WriteLine("Exercício 10 - Revisão 1");
            Console.WriteLine("\tO curso de Computação Gráfica do IFTM é trimestral, sendo que as notas do ano são divididas em três\n" +
                              "\tpartes: 30, 35 e 35, totalizando 100 pontos no ano.O professor de programação está querendo automatizar\n" +
                              "\to processo de fechamento de notas, fazendo um programa para somar as notas dos três trimestres de todos\n" +
                              "\talunos da turma.\n" +
                              "\tEntrada:\n" +
                              "\tA entrada é composta por um número inteiro N representando a quantidade de alunos da turma, seguida pelas\n" +
                              "\ttrês notas de cada aluno da turma. As notas de um aluno são representadas por três números de ponto flutuante\n" +
                              "\tcom duas casas decimais.\n" +
                              "\tSaída:\n" +
                              "\tA saída mostra a nota final de cada aluno(duas casas decimais).\n");

        }

    }
}
