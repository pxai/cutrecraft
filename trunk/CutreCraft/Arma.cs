using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CutreCraft
{
    interface Arma
    {
        // Atributos
        string nombre { get; set; }
        int precio { get; set; }
        int ataque { get; set; }
        int defensa { get; set; }
        int peso { get; set;}
        bool arrojadiza { get; set; }

        // Métodos
        string ficha();
        int valorAtaque();
        int valorDefensa();
    }
}
