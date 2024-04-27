using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador.Clases
{
    public class ColeccionAnimales
    {
        private Animal[] animales;

        public ColeccionAnimales(int cantidad)
        {
            animales = new Animal[cantidad];
        }

        public Animal this[int indice]
        {
            get
            {
                if (indice < 0 || indice >= animales.Length)
                {
                    throw new IndexOutOfRangeException("Índice fuera de rango.");
                } 

                return animales[indice];
            }
            set
            {
                if (indice < 0 || indice >= animales.Length)
                {
                    throw new IndexOutOfRangeException("Índice fuera de rango.");
                }

                animales[indice] = value;
            }
        }
    }
}
