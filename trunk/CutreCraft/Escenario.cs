using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class Escenario
    {
        // Clase indexadora que contiene
        // un conjunto de clases
        private static  int _tamano = 5;
        private Celda[,] _celdas = new Celda[_tamano,_tamano];
        private string _nombreEscenario;

        public Escenario(string nombre)
        {
            _nombreEscenario = nombre;
            generarMundo();
        }

        // Devuelve el tamaño del escenario
        public int getSize() {
            return _tamano;
        }

        // Ahora montamos el indexador
        public Celda this[int x, int y] {
        
            get {  // Para sacar un Celda del libro
                Celda temporal;

                if (x >= 0 && x < _tamano && y>=0 && y < _tamano)
                {
                    temporal = _celdas[x,y];
                }
                else
                {
                    temporal = null;
                }

                return temporal;
            }

            set {  // Para meter un Celda
                if (x >= 0 && x < _tamano && y >= 0 && y < _tamano)
                {
                    _celdas[x, y] = value;
                }
            }
        }

        private void generarMundo()
        {
            for (int i = 0; i < _tamano; i++)
                for (int j = 0; j < _tamano; j++)
                    _celdas[i, j] = new Celda();
        }

        public string mostrar()
        {
            string datos = "Escenario " + _nombreEscenario + "\n";

            for (int i = 0; i < _tamano; i++)
            {
                datos += "Fila " + i + "\n";
                for (int j = 0; j < _tamano; j++)
                {
                    datos += "Celda " + j + ":" + _celdas[i, j].mostrar() + "\n";
                }
            }

            return datos;
        }
    }
}
