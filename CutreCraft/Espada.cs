using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class Espada : Arma
    {
        private string _nombreEspada;
        private int _precioEspada;
        private int _ataqueEspada;
        private int _defensaEspada;
        private int _pesoEspada;
        private bool _arrojadizaEspada;
        private Random aleatorio = new Random();

        // Métodos set y get
        public string nombre {
            get { return _nombreEspada; }
            set { _nombreEspada = value;} 
        }

        public int precio {
            get { return _precioEspada; }
            set { _precioEspada = value; } 
        }
        public int ataque {
            get { return _ataqueEspada; }
            set { _ataqueEspada = value; } 
        }
        public int defensa {
            get { return _defensaEspada; }
            set { _defensaEspada = value; } 
        }
        public int peso {
            get { return _pesoEspada; }
            set { _pesoEspada = value; } 
        }
        public bool arrojadiza {
            get { return _arrojadizaEspada; }
            set { _arrojadizaEspada = value; } 
        }

        public Espada(string nombreArma) {
            nombre = nombreArma;
            ataque = aleatorio.Next(6);
            defensa = aleatorio.Next(6);
            peso = aleatorio.Next(6);
        }

        public Espada() { 
        }

        // Métodos
        public string ficha() {
            string resultado = "";
            resultado += "Nombre: " + nombre + "\n";
            resultado += "Ataque: " + ataque + "\n";
            resultado += "Defensa: " + defensa + "\n";
            resultado += "Peso: " + peso + "\n";
            return resultado; 
        }

        public int valorAtaque() { return ataque; }
        public int valorDefensa() { return defensa; }
    }
}
