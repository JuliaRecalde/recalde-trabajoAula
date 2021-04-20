using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraParcial_Cola
{
    class Cola
    {
        private int dato; // dato de tipo entero para que ingrese el usuario
        private Cola siguiente; // apuntador al siguiente

        //Construtor
        public int Dato
        {
            get { return dato; } 
            set { dato = value; }
        }

        // Todos los nodos de la cola tienen un Apuntador al siguiente
        public Cola Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        

        
    }
}
