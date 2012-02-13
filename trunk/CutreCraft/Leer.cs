using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class Leer
    {
        public static string cadena() {
            string cadena = System.Console.ReadLine();
            return cadena;
        }

        public static int numero() {
            return Convert.ToInt32(cadena());
        }

        
    }
}
