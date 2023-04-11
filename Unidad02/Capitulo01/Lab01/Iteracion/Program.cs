using System;

namespace Iteracion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[5];
            int cantIteraciones = 5;
            for (int i = 0; i < cantIteraciones; i++)
            {
                int v = i + 1;
                array[i] = Convert.ToString(v);
            }
            for (int i = cantIteraciones-1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
