/******************************************************************************
URI-1019-RESOLVIDO-CONVERSÃO DE TEMPO.

Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica,
e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos,
conforme exemplo fornecido.


*******************************************************************************/
using System;
using System.Globalization;


namespace ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarando as variáveis.
            int TempodesejadoN, Horas, Resto, minutos, segundos;

            // entrada dos valores.

            TempodesejadoN = int.Parse(Console.ReadLine());

             // fórmulas necessárias.

            Horas = TempodesejadoN / 3600;
            Resto = TempodesejadoN % 3600; 
            minutos = Resto / 60;
            segundos = Resto % 60;

            // saída desejada.

            Console.WriteLine(Horas + ":" + minutos + ":" + segundos);

          
        }
    }
}
