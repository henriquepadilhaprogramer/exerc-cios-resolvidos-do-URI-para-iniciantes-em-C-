/******************************************************************************
URI-1018-RESOLVIDO-CÉDULAS

Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) 
no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1.
A seguir mostre o valor lido e a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída
Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, 
conforme o exemplo fornecido.
Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem:
“Presentation Error”.

*******************************************************************************/
using System;
using System.Globalization;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // declarnado as variáveis.

            int N, quociente, resto, nota; // quociente ( quantas vezes um numero cabe dentro de outro quando é dividido)
                                          //O resto da divisão (é um número maior ou igual a zero e menor que o divisor.
                                          // Ele é o que sobra na aplicação do algoritmo em uma divisão de números inteiros.)
            // entradas dos valores

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);
    
            resto = N;

            // todas as saídas desejadas, muda somente o valor da nota
            nota = 100;
            quociente = resto / nota; // cálculo do quociente
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00"); // saída nota de 100
            resto = resto % nota;// cálculo do resto
            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");
           
        }
    }
}