using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOLA A TODOS SEAN BIENVENIDOS");

            Console.WriteLine("*************");
            Console.ReadKey();

            Estudiantes estudiante = new Estudiantes
            {
                Nombre = "Kevin Cabrera ",
                Edad = 26,
                Peso = 1.39,
                Ciudad = "Quito",
            };

            Console.WriteLine(estudiante.Presentarse());

            Console.WriteLine(estudiante.CursoAlQueIntegra());

            Console.WriteLine(estudiante.MateriaAsignada());

            Console.WriteLine("**********");
            Console.ReadKey();

            Licenciado licenciado = new Licenciado
            {
                Nombre = "Carlos Pozo",
                AñosProfesión = 3,
                Edad = 45,
            };

            Console.WriteLine(licenciado.Hablar());

            Console.WriteLine(licenciado.CarreraQueda());

            Console.WriteLine(licenciado.AsignadoCurso());

            Console.WriteLine(licenciado.SegundoAsignado(estudiante.Nombre));

            Console.WriteLine("***************");
            Console.ReadKey();

            Carrera Carrera = new Carrera
            {
                Nombre = "Desarrollo de sofware",
                Materia = "Base de datos ",
                Horario = "5-9 de la noche"
            };

            Console.WriteLine(Carrera.MostrarCarrera());

            Curso curso = new Curso
            {
                Nombre = "Curso 100",
                PresidenteCurso = "Israel Yanez"
            };

            Console.WriteLine(curso.MostrarCurso());




        }

    }


}