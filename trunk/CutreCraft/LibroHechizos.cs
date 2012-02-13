using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class LibroHechizos
    {
        // Clase indexadora que contiene
        // un conjunto de clases
        private Hechizo[] _libro = new Hechizo[5];
        private string _nombreLibro;

        public LibroHechizos(string nombre)
        {
            _nombreLibro = nombre;
        }

        // Devuelve el tamaño del libro
        public int getSize() {
            return _libro.Length;
        }

        // Ahora montamos el indexador
        public Hechizo this[int indice]
        {
            get {  // Para sacar un hechizo del libro
                Hechizo temporal;

                if (indice >= 0 && indice <= 4)
                {
                    temporal = _libro[indice];
                }
                else
                {
                    temporal = null;
                }

                return temporal;
            }

            set {  // Para meter un hechizo
                if (indice >= 0 && indice <= 4)
                {
                    _libro[indice] = value;
                }
            }
        }


        public string mostrar()
        {
            string datos = "Libro " + _nombreLibro + "\n";

            for (int i = 0; i < getSize(); i++)
            {
                datos += "Hechizo nº " + i + "\n";
                datos += this[i].mostrar();
            }

            return datos;
        }

    }
}
