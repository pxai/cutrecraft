using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerrero miPersonaje = new Guerrero();
            Dado miDado = new Dado(20);
            Dado miOtroDado = new Dado(6);
            Espada espada = new Espada("Hielo");


            Hechizo hechizo = new Hechizo("Dolor Infinito", 10, 10, 1);
            Hechizo hechizo2 = new Hechizo("Mega Muerte", 10, 20, 1);
            Hechizo hechizo3 = new Hechizo("Gangrena Total",9, 20, 1);
            Hechizo hechizo4 = new Hechizo("Cura Cura Sana", 9, 10, 2);
            Hechizo hechizo5 = new Hechizo("Tormenta de Mierda", 12, 20, 1);

            LibroHechizos grimorio = new LibroHechizos("Necronomicon");
            grimorio[0] = hechizo;
            grimorio[1] = hechizo2;
            grimorio[2] = hechizo3;
            grimorio[3] = hechizo4;
            grimorio[4] = hechizo5;

            Log.log("Volcar hechizos: " + grimorio.mostrar());

            Log.log("Introduce tu nombre");
            
            string nombre = Leer.cadena();
            Guerrero otroPersonaje = new Guerrero(nombre, "Dunedain", espada);

            otroPersonaje.pillarLibro(grimorio);

            AccesoDatos.pruebaModificacion();
            AccesoDatos.pruebaAcceso();
            Escenario escenario = new Escenario("Mazmorras del Mal");
            Log.log("Volcado de escenario " + escenario.mostrar());


            Log.log(otroPersonaje.ficha());
            Log.log(miPersonaje.ficha());

        }
    }
}
