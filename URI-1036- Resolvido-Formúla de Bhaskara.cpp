/******************************************************************************
URI-1036- FORMÚLA DE BHASKARA

Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara.
Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”,
caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes,
apresente a mensagem "Impossivel calcular". Caso contrário,
imprima o resultado das raízes com 5 dígitos após o ponto
com uma mensagem correspondente conforme exemplo abaixo. 
Imprima sempre o final de linha após cada mensagem.

*******************************************************************************/
using System;
using System.Globalization;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarando as variáveis.
            
            double A, B, C, Delta, Raiz1, Raiz2;

            string[] vet = Console.ReadLine().Split(' ');
            
            // entrada dos valores.


            A = double.Parse(vet[0], CultureInfo.InvariantCulture);

        
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);

           
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            // cálculo da bhaskara.

            Delta = Math.Pow(B, 2.0) - 4 * A * C; // Δ = b² - 4.A.C
            
            // condição

            if ( A == 0 || Delta < 0.0)
            {
                // sáida 1 
                
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Raiz1 = (-B + Math.Sqrt(Delta)) / (2.0 * A); // -b + √Δ / 2a
                
            // saída 2
            
                Console.WriteLine("R1 = " + Raiz1.ToString("F5", CultureInfo.InvariantCulture));
                Raiz2 = (-B - Math.Sqrt(Delta)) / (2.0 * A); // -b - √Δ / 2a
                
            // saída 3 
            
                Console.WriteLine("R2 = " + Raiz2.ToString("F5", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}

