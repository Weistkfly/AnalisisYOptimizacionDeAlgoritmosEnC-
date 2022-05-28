using System;
using System.Collections;

namespace pilaYColaEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- pila \n 2- cola");
            string option = Console.ReadLine();

            if (option == "1")
            {
                pilaMehotd();
            } else
            {
                colaMehotd();
            }

            void pilaMehotd()
            {
                //1
                //Crear un programa que lea los titulos de libros y muestre la lista utilizando una pila.
                //Las funciones son las siguientes:
                //Agregar elementos
                //Mostrar el elemeneto a ser eliminado
                //Eliminar el elemento
                //Mostrar la lista nuevamente una vez que se haya hecho estas operaciones
                string option = "";
                Stack libros = new Stack();

                while (option != "4")
                {
                    Console.WriteLine("Ingrese lo que desea hacer");
                    Console.WriteLine("1- Agregar a la pila");
                    Console.WriteLine("2- Mostrar el elemento a borrar");
                    Console.WriteLine("3- Borrar elemento");
                    Console.WriteLine("4- Terminar programa");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Ingrese el titulo del libro");
                            libros.Push(Console.ReadLine());
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine($"{libros.Peek()} es el elemento a borrar");
                            break;
                        case "3":
                            libros.Pop();
                            break;
                    }

                    foreach (var item in libros)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            void colaMehotd()
            {
                string option = "";
                Queue libros = new Queue();

                while (option != "4")
                {
                    Console.WriteLine("Ingrese lo que desea hacer");
                    Console.WriteLine("1- Agregar a la cola");
                    Console.WriteLine("2- Mostrar el elemento a borrar");
                    Console.WriteLine("3- Borrar elemento");
                    Console.WriteLine("4- Terminar programa");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Ingrese el titulo del libro");
                            libros.Enqueue(Console.ReadLine());
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine($"{libros.Peek()} es el elemento a borrar");
                            break;
                        case "3":
                            libros.Dequeue();
                            break;
                    }

                    foreach (var item in libros)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
