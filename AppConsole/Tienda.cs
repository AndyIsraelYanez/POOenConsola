using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsole
{
    public class Tienda
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Dueño { get; set; }


        public string IndicarTienda()
        {
            return $" Bienvenido a la tienda {Nombre} que esta ubicada en Quito";
        }
        public string AbrirTienda()
        {
            return $" por el momento se  encuentra  cerrada";
        }
        public string  CerrarTienda()
        {
            return $" pero abre  el dia de mañana";
        }

    }
}