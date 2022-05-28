using System;
using System.IO;

namespace ArrayClassLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula[] peliculasOSeries = new Pelicula[10];
            Pelicula pel = new Pelicula();
            string txtFileName = "pelisculas.txt";
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el titulo de la pelicula");
                pel.Titulo = Console.ReadLine();
                Console.WriteLine("Ingrese el director de la pelicula");
                pel.Director = Console.ReadLine();
                Console.WriteLine("Ingrese el escritor de la pelicula");
                pel.Escritor = Console.ReadLine();
                Console.WriteLine("Ingrese el genero de la pelicula");
                pel.Genero = Console.ReadLine();
                Console.WriteLine("Ingrese la duracion de la pelicula");
                pel.Duracion = Console.ReadLine();
                Console.WriteLine("Ingrese la clasificacion de la pelicula");
                pel.Clasificacion = Console.ReadLine();
                Console.WriteLine("Ingrese la productora de la pelicula");
                pel.Productora = Console.ReadLine();

                peliculasOSeries[i] = new Pelicula { 
                    Titulo = pel.Titulo,
                    Director = pel.Director,
                    Escritor = pel.Escritor,
                    Genero = pel.Genero,
                    Duracion = pel.Duracion,
                    Clasificacion = pel.Clasificacion,
                    Productora = pel.Productora
                };
                Console.Clear();
            }

            void manageFile()
            {
                using (var tw = new StreamWriter(txtFileName, true))
                {
                    foreach (var item in peliculasOSeries)
                    {
                        
                        tw.WriteLine(item.Titulo);
                        tw.WriteLine(item.Director);
                        tw.WriteLine(item.Escritor);
                        tw.WriteLine(item.Genero);
                        tw.WriteLine(item.Duracion);
                        tw.WriteLine(item.Clasificacion);
                        tw.WriteLine(item.Productora);
                        tw.WriteLine("");
                    }
                    tw.Close();
                }
            }

            if (File.Exists(txtFileName))
            {
                manageFile();
            } else
            {
                File.Create(txtFileName);
                TextWriter tw = new StreamWriter(txtFileName);
                tw.WriteLine("The very first line!");
                tw.Close();
                manageFile();
            }
            }

            
    }

    class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Escritor { get; set; }
        public string Genero { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }
        public string Productora { get; set; }
    }
}
