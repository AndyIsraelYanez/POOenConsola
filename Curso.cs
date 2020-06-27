using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClasesPOO
{

    public class Estudiantes
    {
        //Propoiedades 
        private int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public string Ciudad { get; set; }

        Carrera carrera = new Carrera
        {

            Nombre = "Desarrollo de Software",
            Materia = "Base de Datos",
            Horario = "7 - 8 de la tarde"
        };

        Curso curso = new Curso
        {

            Nombre = "Curso Numero 15"
        };




        public string Practica()
        {

            return carrera.Nombre;

        }
        public string Presentarse()
        {
            return $"Como  estas tu nombre es: {Nombre}  y tienes {Edad} años de edad  su peso es de  {Peso}  ";
        }

        public string CursoAlQueIntegra()
        {

            return $"tiene  el grato honor de permanecer en el Aula :  {curso.Nombre}";
        }

        public string MateriaAsignada()
        {

            return $"La  Carrera  Asignada es:  {carrera.Nombre}, y su materia  asignada es: {carrera.Materia} al Horario que pertenece es:  {carrera.Horario} ";
        }

    }

}