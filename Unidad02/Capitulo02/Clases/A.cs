using System;

namespace Clases
{
    public class A
    {
        private string nombreInstancia;
        //property
        public string NombreInstancia
        {
            get { return nombreInstancia; }
            set { nombreInstancia = value; }
        }
        //constructor por defecto
        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }
        //constuctor por parametro
        public A(string name)
        {
            NombreInstancia = name;
        }

        public string MostrarNombre()
        {
            return NombreInstancia;
        }

        public void M1()
        {
            Console.WriteLine("Se invoco al metodo M1");
        }

        public void M2()
        {
            Console.WriteLine("Se invoco al metodo M2");
        }

        public void M3()
        {
            Console.WriteLine("Se invoco al metodo M3");
        }

    }
}
