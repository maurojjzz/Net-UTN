using System;

namespace Decision
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
                if (opcion.Key != ConsoleKey.D1 && opcion.Key != ConsoleKey.D2 && opcion.Key != ConsoleKey.D3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Opcion incorrecta");
                }
                else
                {
                    if (opcion.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.ToUpper());
                    }
                    else if (opcion.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.ToLower());
                    }
                    else if (opcion.Key == ConsoleKey.D3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Cantidad de letras en el input: " + inputTexto.Length);
                    }
                }
            }
        }
    }
}
