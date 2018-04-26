using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.WriteLine("Diga um numero: ");
            int Numero = Convert.ToInt32(Console.ReadLine());

            for (int i = -100000; i < 100001; i++)
            {
                
                int Resultado = Numero * i;
                Console.WriteLine(Numero + " x " + i +  " = " + Resultado);

            }
        }
    }
}
