using AppConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsole
{
    public class Vendedor
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciuadad { get; set; }


        Tienda tienda2 = new Tienda
        {
            Nombre = "Artefacta",

            Ubicacion = "Sangolqui",
        };

        public string Saludar()
        {
            return $"Hola mi nombre es {Nombre}, tengo {Edad} y soy  un vendedor de artefactos.";
        }

        public string Informar()
        {
            return $"Yo informo  a las personas  los productos que se encuentran en la tienda {tienda2.Nombre}";
        }

        public string Cobrar()
        {
            return $" Si a una de las personas le llego a gustar el producto yo me encargo de cobrar";
        }

        public string DarVueltos()
        {
            return $" y de dar los vuletos correspondientes";
        }
    }
}