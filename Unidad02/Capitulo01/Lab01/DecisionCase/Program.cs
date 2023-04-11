using System;

namespace DecisionCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;
            Console.WriteLine("Ingrese un texto");
            inputTexto = Console.ReadLine();
            if (inputTexto.Length == 0)
            {
                Console.WriteLine("No se ha ingresado ningun texto");
            }
            else
            {
                Console.WriteLine("1) Mayusculas - 2) Minusculas - 3)Cantidad de caracteres");
                Console.WriteLine("Ingrese un numero correspondiente a las siguientes operaciones");
                ConsoleKeyInfo opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.Length);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opcion incorrecta (case)");
                        break;
                }
            }
        }
    }
}
