/******************************************************************************

Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano,
p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, 
mostrando 4 casas decimais após a vírgula, segundo a fórmula:
             ------------------------------------
Distancia = v =(x2-x1)ao quadrado+(y2-y2)ao quadrado
Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.
*******************************************************************************/
using System;
using System.Globalization;

namespace Exercicio_Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, X2, Y2, distancia1, distancia2, distancia3, distancia4;

            string[] v = Console.ReadLine().Split(' ');
            X = double.Parse(v[0]);
            Y = double.Parse(v[1]);

            v = Console.ReadLine().Split(' ');
            X2 = double.Parse(v[0]);
            Y2 = double.Parse(v[1]);

            distancia1 = X2 - X;
            distancia2 = Y2 - Y;
            distancia3 = Math.Pow(distancia1, 2.0) + Math.Pow(distancia2, 2.0);
            distancia4 = Math.Sqrt(distancia3);

            Console.WriteLine(distancia4.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
