using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    internal class Barco
    {
        //test
        public Dictionary<Coordenada, String> CoordenadasBarco { get;}
        public string Nombre { get; }
        public int NumDanyos { get; }

        public Barco(string nombre, int longitud, char orientacion, Coordenada coordenadaInicio)
        {
            Nombre = nombre;

        }
    }
}
