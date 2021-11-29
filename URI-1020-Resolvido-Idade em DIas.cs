/******************************************************************************
URI-1020-RESOLVIDO-IDADE EM DIAS

Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.
Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

Entrada
O arquivo de entrada contém um valor inteiro.

Saída
Imprima a saída conforme exemplo fornecido.


*******************************************************************************/
using System;
using System.Globalization;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarando as variáveis.

            int IdadedesejadaN, Anos, Meses, Dias, Resto;
           
           // entrada dos valores de idade

            IdadedesejadaN = int.Parse(Console.ReadLine());

           // cálculos necessários.

            Anos = IdadedesejadaN/ 365;
            Resto = IdadedesejadaN % 365;
            Meses = Resto / 30;
            Dias = Resto % 30;
            
           // saidas desejas.

            Console.WriteLine(Anos + " ano(s)");
            Console.WriteLine(Meses + " mes(es)");
            Console.WriteLine(Dias + " dia(s)");           
        }
    }
}
