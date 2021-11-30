using  System ;

namespace  TesteDeSelecao1
{

    {
        static  void  Main ( string [] args )
        {

            // declarando as variáveis.

            int A, B, C, D;
            
            // entrada dos valores.

            string [] valores  = Console.ReadLine (). Split ('');


            A  =  int . Parse ( valores [ 0 ]); // usuário escolhe o valor no array.
            B  =  int . Parse ( valores [ 1 ]);
            C  =  int . Parse ( valores [ 2 ]);
            D  =  int . Parse ( valores [ 3 ]);

            if ( B  >  C  &&  D  >  A  &&  C  +  D  >  A  +  B  &&  C  >  0  &&  D  >  0  &&  A  %  2  ==  0 ) // condição desejada pelo usuário.
            {

                Console . WriteLine ( " Valores aceitos " ); // saída dos ACEITOS
            }
            else {
                Console . WriteLine ( " Valores nao aceitos " );// saída dos NÃO ACEITOS
            }
            
        }
    }
}
