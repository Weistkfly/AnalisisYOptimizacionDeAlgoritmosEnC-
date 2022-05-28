using System;
using System.Collections.Generic;

namespace ListUse
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantRegistros;
            double AFP = 0.0287;
            double SFS = 0.0304;
            string opcion;
            int userId;
            Empleado empl = new Empleado();
            var listEmployee = new List<Empleado>();

            Console.WriteLine("Ingrese la cantidad de registros a entrar al sistema: ");
            cantRegistros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantRegistros; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                empl.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el cargo del empleado");
                empl.Cargo = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo del empleado");
                empl.Sueldo = Convert.ToDouble(Console.ReadLine());
                empl.insertIntoList(listEmployee, i, empl.Nombre, empl.Cargo, empl.Sueldo, AFP, SFS);
            }

            opcion = "";

            while (opcion == "")
            {
                Console.WriteLine("Que quiere hacer?");
                Console.WriteLine("1-Ver empleado");
                Console.WriteLine("2-Actualizar empleado");
                Console.WriteLine("3-Borrar empleado");
                Console.WriteLine("Presione enter para salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Ingrese el Id del usuario");
                        userId = Convert.ToInt32(Console.ReadLine());
                        empl.getUser(listEmployee, userId);
                        opcion = "";
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Ingrese el Id del usuario");
                        userId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el nuevo nombre");
                        empl.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el cargo del empleado");
                        empl.Cargo = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo sueldo");
                        empl.Sueldo = Convert.ToDouble(Console.ReadLine());
                        empl.updateUser(listEmployee, userId, empl.Nombre, empl.Cargo, empl.Sueldo, AFP, SFS);
                        opcion = "";
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Ingrese el Id del usuario");
                        userId = Convert.ToInt32(Console.ReadLine());
                        empl.deleteFromList(listEmployee, userId);
                        opcion = "";
                        break;
                }
            }

        }
    }

    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Sueldo { get; set; }
        public double AFP { get; set; }
        public double SFS { get; set; }
        public double TotalDescuentos { get; set; }
        public double SueldoNeto { get; set; }

        public void insertIntoList(List<Empleado> listaEmpleados, int id, string nombre, string cargo, double sueldo, double afp, double sfs)
        {
            listaEmpleados.Add( new Empleado {
                Id = id,
                Nombre = nombre,
                Cargo = cargo,
                Sueldo = sueldo,
                AFP = sueldo * afp,
                SFS = sueldo * sfs,
                TotalDescuentos = (sueldo * afp)  + (sueldo * sfs),
                SueldoNeto = sueldo - ((sueldo * afp) + (sueldo * sfs))
            });
        }

        public void updateUser(List<Empleado> listaEmpleados, int id, string nombre, string cargo, double sueldo, double afp, double sfs)
        {
            var empleado = listaEmpleados.Find(x => x.Id == id);
            empleado.Nombre = nombre;
            empleado.Cargo = cargo;
            empleado.Sueldo = sueldo;
            empleado.AFP = sueldo * afp;
            empleado.SFS = sueldo * sfs;
            empleado.TotalDescuentos = (sueldo * afp) + (sueldo * sfs);
            empleado.SueldoNeto = sueldo - ((sueldo * afp) + (sueldo * sfs));
        }

        public void getUser(List<Empleado> listaEmpleados, int id)
        {
            var empleado = listaEmpleados.Find(x => x.Id == id);
            if (empleado != null)
            {
                Console.WriteLine(empleado.Nombre);
                Console.WriteLine(empleado.Cargo);
                Console.WriteLine(empleado.Sueldo);
                Console.WriteLine(empleado.AFP);
                Console.WriteLine(empleado.SFS);
                Console.WriteLine(empleado.TotalDescuentos);
                Console.WriteLine(empleado.SueldoNeto);
            } else
            {
                Console.WriteLine("Empleado no existe");
            }
            
        }

        public void deleteFromList(List<Empleado> listaEmpleados, int id)
        {
            var emplado = listaEmpleados.Find(x => x.Id == id);
            listaEmpleados.Remove(emplado);
        }
    }
}
