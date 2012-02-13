using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class Guerrero : Personaje
    {

        public Guerrero() : base()
        {
            //base.ficha();
        }

        public Guerrero(string nombre, string raza, Arma arma) 
            : base(nombre, raza, arma)
        {

        }
    }
}
