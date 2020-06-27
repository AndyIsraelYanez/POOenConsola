using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesPOO
{
    public class Licenciado
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int AñosProfesión { get; set; }

        Carrera carrera = new Carrera
        {
            Nombre = "Desarrollo de Sotware"
        };

        Curso curso = new Curso
        {
            Nombre = "Curso 46",

            PresidenteCurso = "Andy de la cru Cruz",
        };

        public string Hablar()
        {
            return $"Hola  su nombre es  {Nombre} tiene    {Edad}  años   y su  experiencia laboral es  de {AñosProfesión} ";
        }

        public string CarreraQueda()
        {
            return $"Es  asignado  para  dar la carrera de :{carrera.Nombre}";
        }

        public string AsignadoCurso()
        {

            return $" Su curso  asignado es {curso.Nombre} y  el Presidente de aquel curso es:  {curso.PresidenteCurso}";
        }

        public string SegundoAsignado(string nombre)
        {
            return $"{nombre} Es  el Vicepresidente";
        }
    }
}