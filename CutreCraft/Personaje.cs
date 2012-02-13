using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{

    abstract class Personaje
    {
        private Random dios = new Random();
        private string _nombre;
        private int _nivel;
        private string _raza;
        private int _fuerza;
        private int _inteligencia;
        private int _defensa;
        private Dado _dado = new Dado(6);
        private int _pv;
        private Arma _arma;
        private LibroHechizos _libro;

        
        public Personaje()
        {
        }

        public Personaje(string nombre, int nivel, string raza, int fuerza, int inteligencia, int defensa, Arma arma)
        {
            _nombre = nombre;
            _nivel = nivel;
            _raza = raza;
            _fuerza = fuerza;
            _inteligencia = inteligencia;
            _defensa = defensa;
            _pv = calcularPv();
            _arma = arma;
        }

        public Personaje(string nombre, string raza, Arma arma)
        {
            _nombre = nombre;
            _raza = raza;
            _nivel = dios.Next(1, 100);
            _fuerza = dios.Next(1, 20);
            _inteligencia = dios.Next(1, 20);
            _defensa = dios.Next(1, 20);
            _pv = calcularPv();
            _arma = arma;
        }

        public void pillarLibro(LibroHechizos tocho)
        {
            _libro = tocho;
        }

        private int calcularPv() {
            return _defensa + _fuerza;
        }

        /**
         * ficha 
         * Vuelca toda la info del personaje
         */
        public string ficha()
        {
            string contenido = "";

            contenido += "Nombre: " + _nombre + "\n";
            contenido += "Raza: " + _raza + "\n";
            contenido += "Nivel: " + _nivel + "\n";
            contenido += "\tFUE: " + _fuerza + "\n";
            contenido += "\tINT: " + _inteligencia + "\n";
            contenido += "\tDEF: " + _defensa + "\n";

            if (_libro != null) {
                contenido += "Contenidos del libro ";
                contenido += _libro.mostrar();
            }
            return contenido;
        }

        /**
         * subirNivel
         * incrementa el nivel
         */
        public void subirNivel()
        {
            if (_nivel < 100) {_nivel++;}
        }


        public int atacar() {
            int intensidadGolpe = 0;
            intensidadGolpe = _dado.tirar() + _fuerza;
            return intensidadGolpe;
        }

        public int defender()
        {
            int valorDefensa = 0;
            valorDefensa = _dado.tirar() + _defensa;
            return valorDefensa;
        }
    }

}
