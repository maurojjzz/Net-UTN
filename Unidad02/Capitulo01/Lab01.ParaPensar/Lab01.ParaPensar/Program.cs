using System;

namespace Lab01.ParaPensar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de ejercicio.\n1)Suma\n2)Anio Bisiesto\n3)Fibonacci\n4)Numero par\n5)Mes nombre" +
                "\n6)Romano\n7)Numeros gemelos\n8)Algoritmo\n9)Estrella ateriscos");
            ConsoleKeyInfo opcion= Console.ReadKey();
            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                    uno();
                    break;
                case ConsoleKey.D2:
                    dos();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Proximamente");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("Proximamente");
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("Proximamente");
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("Proximamente");
                    break;
                case ConsoleKey.D7:
                    Console.WriteLine("Proximamente");
                    break;
                case ConsoleKey.D8:
                    Console.WriteLine("Proximamente");
                    break;
                default:
                    Console.WriteLine("Opcion Inexistente");
                    break;
            }

            
        }

        static void uno()
        {
            Console.WriteLine("\nIngrese el primer numero");
            int nro1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el segundo numero");
            int nro2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEl resultado de la suma de "+nro1+" y "+nro2+" es "+"= "+ (nro1+nro2) +"\n");
        }

        static void dos()
        {
            Console.WriteLine("\nIngrese el numero del año: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year%4) == 0) 
            {
                if ((year % 100)==0)
                    {
                        if (year % 400==0)
                        {
                            Console.WriteLine("\nEs año bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("\n No es año bisiesto");
                        }
                        }
                else
                {
                    Console.WriteLine("\nEs año bisiesto");
                }
               
            }
            else
            {
                Console.WriteLine("\n No es año bisiesto");
            }
        }
    }
}
