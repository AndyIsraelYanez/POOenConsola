using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace AppConsole
{
    public class TipoProducto
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public string Precio{ get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string IndicarTipoProducto()

        {
            return $" Este es una seccion de categoria de  {Nombre}  ";
        }
        public string InformarProducto()

        {
            return $" Se obtiene generalmente la marca {Marca} como una de las mejores  ";
        }
    }
}