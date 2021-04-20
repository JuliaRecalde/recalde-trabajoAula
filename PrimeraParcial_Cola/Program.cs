using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraParcial_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola2 c = new Cola2();

            // llamamos 5 veces al metodo para poder ingresar 5 elementos
            c.InsertarCola();
            c.InsertarCola();
            c.InsertarCola();
            c.InsertarCola();
            c.InsertarCola();

            //Console.WriteLine("\nProbandoooo\n");
            
            Console.WriteLine("\nLa Cola es: \n");
            c.ImprimeCola(); // llamamos a la funcion para impirmir los elementos
            Console.ReadLine();
        }
    }
}
