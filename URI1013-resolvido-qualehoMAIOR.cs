/******************************************************************************

URI1013-RESOLVIDO-QUAL É O MAIORAB

Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”.

Utilize a fórmula:

MAIOR AB = (a+b+abs(a-b)
           -------------
                 2

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo,
portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída

Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

*******************************************************************************/
using System;
using System.Globalization;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)

        {   
            // declarando as variáveis.

            int A, B, C, MAIORAB, MAIOR;

            //entrada dos valores.

            string[] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            // formúla para encontrar qual é o maior.

            MAIORAB = (A + B + Math.Abs(A - B))/ 2;
            MAIOR = (MAIORAB + C + Math.Abs (MAIORAB - C))/ 2;

            // saída

            Console.WriteLine(MAIOR + " eh o maior");
            Console.ReadLine();
        }
    }
}
