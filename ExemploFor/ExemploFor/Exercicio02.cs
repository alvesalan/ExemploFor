using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio02
    {
        public Exercicio02()
        {


            for (int Numero = 1; Numero <= 10; Numero++)
            {

                for (int i = 1; i <= 10; i++)
                {

                    // 1 x 0 = 0
                    // 10 x 10 = 10 

                    int Resultado = Numero * i;
                    Console.WriteLine(Numero + " x " + i + " = " + Resultado);

                }
                Console.WriteLine();
            }
        }
    }
}
