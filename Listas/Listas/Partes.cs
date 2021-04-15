using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Partes : IEquatable<Partes>
    {
        public string ParteNombre { get; set; }

        public int ParteID { get; set; } //PartID se utiliza para identificar el tipo, pero el nombre 

        public override string ToString()
        {
            return "ID: " + ParteID + "   Nombre: " + ParteNombre;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Partes objAsPart = obj as Partes;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return ParteID;
        }
        public bool Equals(Partes other)
        {
            if (other == null) return false;
            return (this.ParteID.Equals(other.ParteID));
        }
    }
}
