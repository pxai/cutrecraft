using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class Celda
    {
        // Atributos
        string _nombre = "Celda ignota";
        Arma _arma = null;
        LibroHechizos _libro = null;
        int _monedas = 0;

        public Celda() {
            iniciarMonedas();
        }

        public Celda(string nombre) {
            iniciarMonedas();
            _nombre = nombre;
        }

        private void iniciarMonedas () {
            Dado dado = new Dado(10);
            _monedas = dado.tirar();
        }

        public string mostrar() {
            return _nombre + ", oro: " + _monedas;
        }

    }
}
