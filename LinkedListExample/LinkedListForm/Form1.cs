using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListForm
{
    public partial class Form1 : Form
    {
        LinkedList<string> alumnos = new LinkedList<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            alumnos.AddFirst(txtName.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //move
            var alumnoAMover = alumnos.Find(txtName.Text);
            if (alumnoAMover == null)
            {
                MessageBox.Show("Alumno no encontrado");
            }
            else
            {
                alumnos.Remove(alumnoAMover);
                alumnos.AddLast(txtName.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var alumnoABorrar = alumnos.Find(txtName.Text);
            alumnos.Remove(alumnoABorrar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombreAlumnoABuscar = txtName.Text;
            var alumnoABuscar = alumnos.Find(nombreAlumnoABuscar);
            if (alumnoABuscar == null)
                MessageBox.Show("No se encontro al alumno");
            else
                MessageBox.Show("El alumno esta en la lista");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = alumnos.ToList();
        }
    }
}
