using System;

namespace recursionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uso de recursividad");
            ascendente(1, 100);
        }

        public static void ascendente(int n, int top)
        {
            if (n <= top)
            {
                Console.WriteLine(n);
                ascendente(n + 1, top);
            }
            else
            {
                Console.WriteLine("Fin de la función.");
            }
        }
    }
}
