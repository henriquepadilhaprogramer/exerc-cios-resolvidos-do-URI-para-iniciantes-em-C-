/******************************************************************************
URI-1014- Consumo

Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km)
e o total de combustível gasto (em litros).

Entrada
O arquivo de entrada contém dois valores: um valor inteiro X representando
a distância total percorrida (em Km), e um valor real Y representando o total de combustível gasto, 
com um dígito após o ponto decimal.

Saída
Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula,
seguido da mensagem "km/l".
*******************************************************************************/
using System;
using System.Globalization;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            // declatando as variáveis.

            int x; // variável inteira

            double y, combustivel;

            // entrada dos valores.

            x = int.Parse(Console.ReadLine());

            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // cálculo de consumo do combustivel.

            combustivel = (double)x / y;
            
            // saída
            
            Console.WriteLine(combustivel.ToString("F3", CultureInfo.InvariantCulture) + " km/l");



        }
    }
}
