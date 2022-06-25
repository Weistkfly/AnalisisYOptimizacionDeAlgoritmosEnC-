using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListForms
{
    public partial class Form1 : Form
    {
        double AFP = 0.0287;
        double SFS = 0.0304;
        Empleado empl = new Empleado();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listEmployee = new List<Empleado>();
            empl.Nombre = nombre.Text;
            empl.Cargo = cargo.Text;
            empl.Id = Convert.ToInt32(id.Text);
            empl.Sueldo = Convert.ToDouble(sueldo.Text);
            empl.insertIntoList(listEmployee, empl.Id, empl.Nombre, empl.Cargo, empl.Sueldo, AFP, SFS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listEmployee = new List<Empleado>();
            empl.Id = Convert.ToInt32(id.Text);
            var empleado = empl.getUser(listEmployee, empl.Id);
            nombre.Text = empleado.Nombre;
            cargo.Text = empleado.Cargo;
            sueldo.Text = empleado.Sueldo.ToString();
            lableAFP.Text += empleado.AFP.ToString();
            labelSFS.Text += empleado.SFS.ToString();
            desceuntoTotal.Text += empleado.TotalDescuentos.ToString();
            sueldoNEto.Text += empl.SueldoNeto.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var listEmployee = new List<Empleado>();
            empl.Nombre = nombre.Text;
            empl.Cargo = cargo.Text;
            empl.Id = Convert.ToInt32(id.Text);
            empl.Sueldo = Convert.ToDouble(sueldo.Text);
            empl.updateUser(listEmployee, empl.Id, empl.Nombre, empl.Cargo, empl.Sueldo, AFP, SFS);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var listEmployee = new List<Empleado>();
            empl.Id = Convert.ToInt32(id.Text);
            empl.deleteFromList(listEmployee, empl.Id);
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
            listaEmpleados.Add(new Empleado
            {
                Id = id,
                Nombre = nombre,
                Cargo = cargo,
                Sueldo = sueldo,
                AFP = sueldo * afp,
                SFS = sueldo * sfs,
                TotalDescuentos = (sueldo * afp) + (sueldo * sfs),
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

        public Empleado getUser(List<Empleado> listaEmpleados, int id)
        {
            var empleado = listaEmpleados.Find(x => x.Id == id);
            if (empleado != null)
            {
                return empleado;
            }
            else
            {
                return null;
            }

        }

        public void deleteFromList(List<Empleado> listaEmpleados, int id)
        {
            var emplado = listaEmpleados.Find(x => x.Id == id);
            listaEmpleados.Remove(emplado);
        }
    }
}
