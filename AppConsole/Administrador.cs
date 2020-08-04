using AppConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsole
{
    public class Administrador
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int AñosProfesión { get; set; }


        TipoProducto tipoDeproducto1 = new TipoProducto
        {
            Nombre = "electrodomésticos"
        };

        Tienda tienda1 = new Tienda
        {
            Nombre = "Santa Maria",

            Ubicacion = "Pintag",
        };

        public string Hablar()
        {
            return $" HoLa mi nombre es {Nombre} tengo {Edad}  años  de edad  y tengo  {AñosProfesión} años de profesion en la administración";
        }

        public string Organizar()
        {
            return $" Organizó en la tienda {tienda1.Nombre} a todo el personal de trabajo ";
        }

        public string Pagar()
        {

            return $" Principalmente me encargo de pagar los sueldos  a las personas que verndan  {tipoDeproducto1.Nombre}";
        }

        public string Multar()
        {
            return $" Aquellas personas  que no cumplen con las reglas tienden aser multadas con un valor de 20  dólares.";
        }
    }
}