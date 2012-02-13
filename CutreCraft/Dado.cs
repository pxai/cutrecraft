using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class Dado
    {
        private int _caras;
        private static Random _aleatorio = new Random();

        public Dado(int caras) {
            _caras = caras;
        }

        public int tirar() {
            return _aleatorio.Next(1,(_caras+1));
        }

    }
}
