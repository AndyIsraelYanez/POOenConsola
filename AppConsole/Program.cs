using AppConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOLA A TODOS SEAN BIENVENIDOS");

            Console.WriteLine("*************");
            Console.WriteLine("** Precione Enter para continuar **");
            Console.ReadKey();

            Vendedor vendedor = new Vendedor
            {
                Nombre = "Kevin Cabrera ",

                Edad = 19,

                Ciuadad = "Quito",
               
            };

            Console.WriteLine(vendedor.Saludar());

            Console.WriteLine(vendedor.Informar());

            Console.WriteLine(vendedor.Cobrar());

            Console.WriteLine(vendedor.DarVueltos());


            Console.WriteLine("**********");
            

            Administrador administrador = new Administrador
            {
                Nombre = "Carlos Pozo",

                Edad = 53,

                AñosProfesión = 10,
            };

            Console.WriteLine(administrador.Hablar());

            Console.WriteLine(administrador.Organizar());

            Console.WriteLine(administrador.Pagar());

            Console.WriteLine(administrador.Multar());

            Console.WriteLine("***************");
           

            TipoProducto tipoProducto = new TipoProducto
            {
                Nombre = "Electrodomésticos",

                Precio = "120",

                Marca = "Indurama",

                Modelo = "Xp"
            };

            Console.WriteLine(tipoProducto.IndicarTipoProducto());

            Tienda tienda = new Tienda
            {
                Nombre = "Super Mega",

                Ubicacion = "Conocoto",

                Dueño = "Marco de la Cruz"
            };

            Console.WriteLine(tienda.IndicarTienda());

            Console.WriteLine(tienda.AbrirTienda());

            Console.WriteLine(tienda.CerrarTienda());

        }

    }


}