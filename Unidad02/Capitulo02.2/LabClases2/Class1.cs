using Clases;
using System;

namespace LabClases2
{
    public class Class1
    {
        static void Main()
        {
            B b = new B();
            A a = b;
            a.F();
            b.F();
            a.G();
            b.G();

            Console.ReadKey();
        }
    }
}
