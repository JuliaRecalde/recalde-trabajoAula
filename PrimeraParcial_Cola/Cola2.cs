using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraParcial_Cola
{
    class Cola2
    {
        private Cola Primero = new Cola(); // creamos el primer apuntador
        private Cola Ultimo = new Cola(); // creamos el ultimo apuntados

        public Cola2()
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertarCola()
        {
            Cola Nuevo = new Cola(); // creamos un nuevo nodo que se va agregar a la Cola

            Console.Write("Inserte el dato para la Cola "); // pedimos al usuario para que ingrese el dato para la cola
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if ( Primero == null ) // condiccion para saber el primero de la cola
            {
                Primero = Nuevo; // asignamos el primer elemento de la cola
                Primero.Siguiente = null; // apuntador al sigueinte 
                Ultimo = Nuevo;
            }
            else // ingresan si no es el primer elemento
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }

            Console.WriteLine("\nDato ingresado correctamente\n");
            }

            public void ImprimeCola()
            {
                Cola Actual = new Cola();

                Actual = Primero;

                if (Primero != null ) // condicion para saber si hay elementos que imprimir 
                {
                    while ( Actual!= null) // Permite recorrer la cola hasta el ultimo elemento
                    {
                        Console.WriteLine( " " + Actual.Dato ); // imprime el elemento
                        Actual = Actual.Siguiente; // Apunta al siguiente elemento
                    }
                }
                else
                {
                    Console.Write("\nLa Cola esta vacia.");
                }
            }
        }
}
