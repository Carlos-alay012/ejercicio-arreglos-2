using System;
namespace EjemploArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tIngrese la cantidad de alumnos:");
            int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

            string[] nombres = new string[cantidadAlumnos];
            int[] notas = new int[cantidadAlumnos];

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine("\tIngrese el nombre del alumno " + (i + 1) + ":");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("\tIngrese la nota del alumno " + (i + 1) + ":");
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\tDatos de los alumnos:");
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine("Alumno " + (i + 1) + ": " + nombres[i] + ", Nota: " + notas[i]);
            }

            int mayor = notas[0];
            int menor = notas[0];
            int indexMax = 0;

            for (int i = 1; i < cantidadAlumnos; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                    indexMax = i;
                }

                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }

            Console.WriteLine("\n\tMayor nota: " + mayor);
            Console.WriteLine("\tMenor nota: " + menor);
            Console.WriteLine("\tEstudiante con la puntuación más alta: " + nombres[indexMax]);
        }
    }
}
