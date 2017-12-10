using System;
using System.Globalization;

namespace Primeiro_Projeto
{
    public class FormulaBaskara
    {
        public static void Calcular()
        {
            Console.WriteLine("\nFórmula de Báskara...");
            double a, b, c, delta, x1, x2;
            a = b = c = delta = x1 = x2 = 0.0;

            //Ler o valor de A
            bool valido = false;
            do{
                try{
                    Console.Write("Digite o valor de a: ");
                    a = double.Parse(Console.ReadLine());
                    valido = true;
                }
                catch(Exception e){
                    Console.WriteLine("Valor inválido!");
                }
            }
            while(!valido);

            //Ler o valor de B
            valido = false;
            do{
                try{
                    Console.Write("Digite o valor de b: ");
                    b = double.Parse(Console.ReadLine());
                    valido = true;
                }
                catch(Exception e){
                    Console.WriteLine("Valor inválido!");
                }
            }
            while(!valido);  

            //Ler o valor de C
            valido = false;
            do{
                try{
                    Console.Write("Digite o valor de c: ");
                    c = double.Parse(Console.ReadLine());
                    valido = true;
                }
                catch(Exception e){
                    Console.WriteLine("Valor inválido!");
                }
            }
            while(!valido); 

            delta = b * b - 4 * a * c;

            if(a == 0.0 || delta < 0.0)
                Console.WriteLine("IMPOSSÍVEL CALCULAR!");
            else{
                x1 = (-b + Math.Sqrt(delta)) / 2.0 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2.0 * a;

                Console.WriteLine("X1 = " + x1.ToString("F4"), CultureInfo.InvariantCulture);
                Console.WriteLine("X2 = " + x2.ToString("F4"), CultureInfo.InvariantCulture);
                
            }
        }
    }
}