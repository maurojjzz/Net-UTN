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
            Console.WriteLine();
            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                    uno();
                    break;
                case ConsoleKey.D2:
                    dos();
                    break;
                case ConsoleKey.D3:
                    tres();
                    break;
                case ConsoleKey.D4:
                    cuatro();
                    break;
                case ConsoleKey.D5:
                    cinco();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("Proximamente");
                    break;
                case ConsoleKey.D7:
                    Console.WriteLine("Proximamente");
                    break;
                case ConsoleKey.D8:
                    ocho();
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

        static void tres()
        {
            Console.WriteLine("Fibonacci");
            int a = 0, b = 1, c=0;
            do
            {
                c = a;
                a = b;
                b = b + c;
                Console.Write(c+", ");
            } while (c<300);
            Console.Write("...\n");
        }
        static void cuatro()
        {
            Console.WriteLine("\n\n");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }  
            }
            Console.WriteLine();
        }

        static void cinco()
        {
            string[] array = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Console.WriteLine("\nIngrese el nombre del mes: ");
            string month = Console.ReadLine();
            int cont = 0;
            bool band = false;
            foreach (var item in array)
            {
                if(item.Equals(month,StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    Console.WriteLine(item +" numero del mes: "+ (cont+1));
                     band = true;
                }
                else
                {
                    cont++;
                }
                if (!band && cont==11)
                {
                    Console.WriteLine("\nERROR! Verifique como escribio el mes");
                }
            }

        }

        static void ocho()
        {
            string clave = "NetUTN";
            int tries = 0;
            string claveAttempt = "";
            while (tries < 5)
            {
                tries++;
                Console.WriteLine("\nIntroduzca la clave:");
                claveAttempt = Console.ReadLine();
                if (claveAttempt.Equals(clave))
                {
                    Console.WriteLine("Clave Correcta");
                    tries = 10;
                }
                else
                {
                    Console.WriteLine("Clave incorrecta");
                }

            }

        }




    }
}
