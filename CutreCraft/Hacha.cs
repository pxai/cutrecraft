using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class Hacha : Arma
    {
        private string _nombreHacha;
        private int _precioHacha;
        private int _ataqueHacha;
        private int _defensaHacha;
        private int _pesoHacha;
        private bool _arrojadizaHacha;
        private Random aleatorio = new Random();

        // Métodos set y get
        public string nombre
        {
            get { return _nombreHacha; }
            set { _nombreHacha = value; }
        }

        public int precio
        {
            get { return _precioHacha; }
            set { _precioHacha = value; }
        }
        public int ataque
        {
            get { return _ataqueHacha; }
            set { _ataqueHacha = value; }
        }
        public int defensa
        {
            get { return _defensaHacha; }
            set { _defensaHacha = value; }
        }
        public int peso
        {
            get { return _pesoHacha; }
            set { _pesoHacha = value; }
        }
        public bool arrojadiza
        {
            get { return _arrojadizaHacha; }
            set { _arrojadizaHacha = value; }
        }

        public Hacha(string nombreArma)
        {
            nombre = nombreArma;
            ataque = aleatorio.Next(6);
            defensa = aleatorio.Next(6);
            peso = aleatorio.Next(6);
        }

        public Hacha()
        {
        }

        // Métodos
        public string ficha()
        {
            string resultado = "";
            resultado += "Nombre: " + nombre + "\n";
            resultado += "Ataque: " + ataque + "\n";
            resultado += "Defensa: " + defensa + "\n";
            resultado += "Peso: " + peso + "\n";
            return resultado;
        }

        public int valorAtaque() { return (ataque+peso); }
        public int valorDefensa() { return (defensa+peso); }
    }
}

