using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class B : A
    {
        public B() : base("Instanccia de b")
        {
        }
        public void M4()
        {
            Console.WriteLine("metodo del hijo invocado");
        }

    }
}
