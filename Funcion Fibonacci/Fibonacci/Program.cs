using System;
using System.Reflection.Metadata.Ecma335;

namespace Fibonacci
{
    class MainClass
    {
        const int Dato = 10000000;
        static bool[] Condicion = new bool[Dato];

        static void Main(string[] args)
        {
            var X = FuncionFibonacci();
            while(true)
            {
                int Modificador = X();
                if (Modificador == -1) break;

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(Modificador);
            }
        }

        static Func<int> FuncionFibonacci()
        {
            int a = 1;
            return () =>
            {
                if (a >= Dato) return -1;
                while (a < Dato && Condicion[++a]) ;
                int c = 1;
                while (a * c < Dato)
                {
                    Condicion[a * c] = true;
                    c++;
                }
                return a;
            };
            
        }

    }
}
