using System;
using System.Collections.Generic;

namespace listadoDeLibros
{
    class Program
    {
        static void Main(string[] args)
        {
            Libros[] listadoDeLibros = new Libros[1];
            Libros libro = new Libros();
            Console.WriteLine("Ingrese el titulo: ");
            libro.Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor: ");
            libro.Autor = Console.ReadLine();
            Console.WriteLine("Ingrese la editorial: ");
            libro.Editorial = Console.ReadLine();
            Console.WriteLine("Ingrese el anio de edicion: ");
            libro.AnioEdicion = Console.ReadLine();
            Console.WriteLine("Ingrese la categoria: ");
            libro.Categoria = Console.ReadLine();

            listadoDeLibros[0] = libro;
            Console.Clear();

            foreach (var item in listadoDeLibros)
            {
                Console.WriteLine("El titulo del libro es: " + item.Titulo);
                Console.WriteLine("El autor del libro es: " + item.Autor);
                Console.WriteLine("La editorial del libro es: " + item.Editorial);
                Console.WriteLine("El anio de edicion del libro es: " + item.AnioEdicion);
                Console.WriteLine("La categoria del libro es: " + item.Categoria);
            }

        }
    }

    public class Libros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string AnioEdicion { get; set; }
        public string Categoria { get; set; }
    }
}
