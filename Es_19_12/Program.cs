using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_19_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //si mette il valore massimo per un int
            int a = int.MaxValue;

            //si stampa.
            Console.WriteLine(a);

            //si dovrebbe stampare il massimo +1 e va al numero minimo
            if (a + 1 > a)
            {
                Console.WriteLine(a + 1);
            }
            else
            {
                Console.WriteLine("il numero è troppo grande per essere aumentato");
            }
            int b = -128;
            int c=-b;
            //b in base 2
            Console.WriteLine(Convert.ToString(b,2));

            //-b in base 2
            Console.WriteLine(Convert.ToString(c, 2));

            
            int value=32;
            int somma = value;

            //complemento a 2

            //complemento a 1 + 1
            value = ~value+1;

            //volore+(-valore)=0
            somma = somma+value;

            Console.WriteLine($"{value} e {somma}");

            //
            long number = 55555;

            //in base 2
            Console.WriteLine(Convert.ToString(number, 2));

            short number1 = (short)number;
            Console.WriteLine(number1);
            Console.ReadLine();

        }
    }
}
