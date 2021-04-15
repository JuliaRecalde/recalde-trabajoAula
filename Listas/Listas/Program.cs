using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crea la lista para Part
            List<Partes> parts = new List<Partes>();

            // Agrega partes a la lista
            parts.Add(new Partes() { ParteNombre = "Julia Recalde", ParteID = 1234 });
            parts.Add(new Partes() { ParteNombre = "Maura Recalde", ParteID = 1334 });
            parts.Add(new Partes() { ParteNombre = "Thalia Martinez", ParteID = 1434 });
            parts.Add(new Partes() { ParteNombre = "Sergio Sosa", ParteID = 1444 });
            parts.Add(new Partes() { ParteNombre = "Thalia Benitez", ParteID = 1534 });
            parts.Add(new Partes() { ParteNombre = "Joaquin Dominguez", ParteID = 1634 });

            // Escribe las partes de la lista. Llama al metodo ToString
            // en la clase PArt
            Console.WriteLine();
            foreach (Partes aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            //Consulta a la lista para la pieza n.# 1734. Esto llama al método IEquatable.Equals
            // de la clase Part, que comprueba la igualdad de PartID.
            Console.WriteLine("\nContiene(\"1734\"): {0}",
            parts.Contains(new Partes { ParteID = 1734, ParteNombre = "" }));

            // Inserta un nuevo elemento en la posicion 2.
            Console.WriteLine("\nInserta(2, \"1834\")");
            parts.Insert(2, new Partes() { ParteNombre = "Dahiana Montiel", ParteID = 1834 });

            //Console.WriteLine();
            foreach (Partes aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nParts[3]: {0}", parts[3]);

            Console.WriteLine("\nEliminar(\"1434\")");

            // Esto eliminará la parte 1534 aunque PartNombre sea diferente,
            // porque el método Equals solo comprueba la igualdad de PartID.
            parts.Remove(new Partes() { ParteID = 1534, ParteNombre = "Laura Maidana" });

            Console.WriteLine();
            foreach (Partes aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("\nElimina En(3)");
            //Esto eliminara en la posicion 3
            parts.RemoveAt(3);

            Console.WriteLine();
            foreach (Partes aPart in parts)
            {
                Console.WriteLine(aPart);
            }

        }
    }
}
