using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class Hechizo
    {
        string _nombre;
        int _mana;
        int _poder;
        int _tipo;

        /**
         * Hechizo
         * constructor
         */
        public Hechizo(string nombre, int mana, int poder, int tipo) {
            _nombre = nombre;
            _mana = mana;
            _poder = poder;
            _tipo = tipo;
        }

        /**
         * lanzar
         * 
         */
        public int lanzar()
        {
            int resultado = 0;
            resultado = _poder;
            return resultado;
        }

        public string mostrar() {
            string datos = "";
            datos += "Nombre: " + _nombre + "\n";
            datos += "Mana: " + _mana + "\n";
            datos += "Poder: " + _poder + "\n";
            datos += "Tipo: " + _tipo + "\n";
            return datos;
        }
    }
}
