using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ClasesPOO
{
    public class Carrera
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public string Horario { get; set; }

        public string MostrarCarrera()


        {

            return $" La  Carrera en la que esta es  {Nombre} , y cogio las siguiente materia { Materia} y asitira { Horario} ";
        }

    }
}