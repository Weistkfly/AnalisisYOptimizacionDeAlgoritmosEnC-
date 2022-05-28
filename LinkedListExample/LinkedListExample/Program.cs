using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<string> materias = new LinkedList<string>();

            //materias.AddLast("Contbilidad 1");
            //materias.AddLast("Contabiliad 2");
            //materias.AddLast("Informatica 1");
            //materias.AddLast("Infromatica 2");
            //materias.AddFirst("Programacion 1");

            //foreach (var item in materias)
            //{
            //    Console.WriteLine(item);
            //}

            //Hacer menu con opciones
            //Agregar nombre de alumnos
            //Agregar un nombre de alumno como primero
            //Agregar un nombre de alumno como ultimo
            //Mover uno de los alumnos de ultimo
            //Eliminar uno de los alumnos de la lista
            //Determinar si un alumno existe
            //Mostrar todos los alumnos
            //Preguntar si desea continuar o salir del menu

            string option;
            LinkedList<string> alumnos = new LinkedList<string>();
            option = "";

            while (option != "6")
            {
                Console.WriteLine("Ingrese una opcion");
                Console.WriteLine("1- Agregar un alumno");
                Console.WriteLine("2- Mover un alumno a uno de los ultimos");
                Console.WriteLine("3- Eliminar un alumno");
                Console.WriteLine("4- Verificar existencia de un alumno");
                Console.WriteLine("5- Mostrar todos los alumnos");
                Console.WriteLine("6- si desea salir");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        string opt = "0";
                        Console.WriteLine("Ingrese un 1 si desea ingresarlo como primero");
                        Console.WriteLine("Ingrese un 2 si desea ingresarlo como ultimo");
                        opt = Console.ReadLine();
                        if (opt == "1")
                        {
                            Console.WriteLine("Ingrese el nombre del alumno");
                            alumnos.AddFirst(Console.ReadLine());
                        } 
                        else if (opt == "2")
                        {
                            Console.WriteLine("Ingrese el nombre del alumno");
                            alumnos.AddLast(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Numero ingresado no es valido");
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del alumno que desea mover a ultimo");
                        string nombreAlumnoAMover = Console.ReadLine();
                        var alumnoAMover = alumnos.Find(nombreAlumnoAMover);
                        if (alumnoAMover == null)
                        {
                            Console.WriteLine("Nombre incorreto");
                        } else
                        {
                            alumnos.Remove(alumnoAMover);
                            alumnos.AddLast(nombreAlumnoAMover);
                            Console.WriteLine("Estudiante agregado");
                        }
                        
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del alumno que desea borrar");
                        string nombreAlumnoABorrar = Console.ReadLine();
                        var alumnoABorrar = alumnos.Find(nombreAlumnoABorrar);
                        alumnos.Remove(alumnoABorrar);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del alumno que desea buscar");
                        string nombreAlumnoABuscar = Console.ReadLine();
                        var alumnoABuscar = alumnos.Find(nombreAlumnoABuscar);
                        if (alumnoABuscar == null)
                            Console.WriteLine("No se encontro al alumno");
                        else
                            Console.WriteLine("El alumno esta en la lista");
                        Console.WriteLine("");
                        break;
                    case "5":
                        Console.Clear();
                        foreach (var item in alumnos)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("");
                        break;
                }
            }
            

        }
    }
}
