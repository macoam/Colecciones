using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas = new Grupo("Matemáticas", "MAT6622");
            Grupo historia = new Grupo("Historia", "HTS1313");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno elmer = new Alumno("Elmer", "789267");
            Alumno pablito = new Alumno("Pablito", "789201");
            Alumno bebitamoxita = new Alumno("BebitaMoxita", "789256");
            Alumno ezra = new Alumno("Ezra", "789234");
            Alumno kakaroto = new Alumno("Goku-san", "789234");

            historia.Alumnos.Add(elmer);
            historia.Alumnos.Add(bebitamoxita);
            historia.Alumnos.Add(ezra);

            matematicas.Alumnos.Add(pablito);
            matematicas.Alumnos.Add(kakaroto);
            matematicas.Alumnos.Add(ezra);
            matematicas.Alumnos.Add(elmer);

            foreach(Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " + grupo.Codigo);
                Console.WriteLine("Materia: " + grupo.Codigo);
                Console.WriteLine("Lista de alumnos: ");

                foreach(Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("-" + alumno.Nombre);
                }
            }

            Console.Read();
        }
    }
}
