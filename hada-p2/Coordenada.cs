using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    internal class Coordenada
    {
        private int _fila;
        private int _columna;


        public int Fila { get => _fila; set { if (value >= 0 && value <= 9) _fila = value; } }
        public int Columna { get => _columna; set { if (value >= 0 && value <= 9) _columna = value; } }

        public Coordenada()
        {
            Fila = 0;
            Columna = 0;
        }
        public Coordenada(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
        }

        public Coordenada(string fila, string columna)
        {
            if (!int.TryParse(fila, out int f) || f < 0 || f > 9) throw new ArgumentException();
            if (!int.TryParse(columna, out int c) || c < 0 || c > 9) throw new ArgumentException();

            Fila = f;
            Columna = c;

        }
        public Coordenada(Coordenada c)
        {
            if (c == null) throw new ArgumentNullException();
            Fila = c.Fila;
            Columna = c.Columna;
        }

        public override string ToString()
        {
            return $"({Fila},{Columna})";
        }

        public override int GetHashCode()
        {
            return Fila.GetHashCode() ^ Columna.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Coordenada coordenada)
                return Equals(coordenada);
            return false;
        }

        public bool Equals(Coordenada other)
        {
            if (other == null) return false;
            return this.Fila == other.Fila && this.Columna == other.Columna;
        }
    }
}
