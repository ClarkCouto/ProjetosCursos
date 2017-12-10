using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro_Projeto
{
    public class AreaTriangulo
    {
        public static void Calcular()
        {
            Console.WriteLine("\tFazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas). Em\n" +
                              "\tseguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.\n" +
                              "\tA fórmula para calcular  a área de um triângulo a partir das medidas de seus lados A, B e C é a fórmula\n" +
                              "\tde Heron => sqrt(p (p - a)(p - b)(p - c))  where p = (a + b + c)/2\n");


            //Ler o valor de A
            bool valido = false;
            int quantidadeTriangulos = 0, maiorArea = 0;
            double p = 0;
            double[] areas;
            double[] numeros = new double[3];
            char[] letras = new char[] { 'a', 'b', 'c', };

            do
            {
                try
                {
                    Console.Write("Digite a quantidade de triângulos: ");
                    quantidadeTriangulos = int.Parse(Console.ReadLine());
                    valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Quantidade inválida!");
                }
            }
            while (!valido);

            areas = new double[quantidadeTriangulos];

            for (int i = 0; i < quantidadeTriangulos; i++)
            {
                Console.Write("\nDigite as medidas do " + (i + 1) + " triângulo:\n");
                for (int j = 0; j < 3; j++)
                {
                    valido = false;
                    do
                    {
                        try
                        {
                            Console.Write("\tDigite o valor de " + letras[j] + ":");
                            numeros[j] = double.Parse(Console.ReadLine());
                            valido = true;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                    }
                    while (!valido);
                }

                p = (double)(numeros[0] + numeros[1] + numeros[2]) / 2;
                areas[i] = Math.Sqrt(p * (p - numeros[0]) * (p - numeros[1]) * (p - numeros[2]));
                Console.WriteLine("Área do triângulo " + (i + 1) + " = " + areas[i]);
            }
            for (int i = 0; i < quantidadeTriangulos; i++)
            {
                if (areas[i] > areas[maiorArea])
                    maiorArea = i;
                Console.WriteLine("Área do triângulo " + (i + 1) + " = " + areas[i].ToString("F4"));
            }
            Console.WriteLine("\nO triângulo com maior área é o " + (maiorArea + 1) + " e mede = " + areas[maiorArea].ToString("F4"));
        }

        internal class Triangulo
        {
            private double a, b, c;
            public Triangulo() { }

            public Triangulo(Double a, Double b, Double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double getA()
            {
                return this.a;
            }

            public double getB()
            {
                return this.b;
            }

            public double getC()
            {
                return this.c;
            }

            public double getP()
            {
                return (getA() + getB() + getC()) / 2;
            }

            public double getArea()
            {
                return Math.Sqrt(getP() * (getP() - getA()) * (getP() - getB()) * (getP() - getC()));
            }
        }

        public static void CalcularComObjetos()
        {
            Console.WriteLine("\tFazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas). Em\n" +
                              "\tseguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.\n" +
                              "\tA fórmula para calcular  a área de um triângulo a partir das medidas de seus lados A, B e C é a fórmula\n" +
                              "\tde Heron => sqrt(p (p - a)(p - b)(p - c))  where p = (a + b + c)/2\n");


            //Ler o valor de A
            bool valido = false, finalizar = false;
            int quantidadeTriangulos = 0, indiceMaiorArea = 0, opcao = 0;
            double valorMaiorArea = 0;
            double[] numeros = new double[3];
            char[] letras = new char[] { 'a', 'b', 'c', };
            List<Triangulo> triangulos = new List<Triangulo>();

            do
            {
                try
                {
                    Console.Write("\nDigite 1 para adicionar um novo triângulo ou qualquer número para finalizar: ");
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    opcao = 0;
                    Console.WriteLine("Valor inválido!");
                }
                if (opcao == 1)
                {
                    Console.Write("Digite as medidas do " + (quantidadeTriangulos + 1) + " triângulo:\n");
                    for (int j = 0; j < 3; j++)
                    {
                        valido = false;
                        do
                        {
                            try
                            {
                                Console.Write("\tDigite o valor de " + letras[j] + ":");
                                numeros[j] = double.Parse(Console.ReadLine());
                                valido = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Valor inválido!");
                            }
                        }
                        while (!valido);
                    }
                    Triangulo t = new Triangulo(numeros[0], numeros[1], numeros[2]);
                    Console.WriteLine("Área do triângulo " + (quantidadeTriangulos + 1) + " = " + t.getArea());
                    triangulos.Add(t);
                    quantidadeTriangulos++;
                }
            }
            while (opcao == 1);
            for (int i = 0; i < triangulos.Count; i++)
            {
                if(triangulos[i].getArea() > valorMaiorArea)
                {
                    valorMaiorArea = triangulos[i].getArea();
                    indiceMaiorArea = i;
                }
                    
                Console.WriteLine("Área do triângulo " + (i + 1) + " = " + triangulos[i].getArea());
            }
            Console.WriteLine("Triângulo com a maior área = " + (indiceMaiorArea + 1) + ", Área do triângulo = " + triangulos[indiceMaiorArea].getArea());
        }
    }
}
