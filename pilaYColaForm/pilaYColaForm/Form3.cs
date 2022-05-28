using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pilaYColaForm
{
    public partial class Form3 : Form
    {
        public Queue libros = new Queue();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnAgregarElemento_Click(object sender, EventArgs e)
        {
            libros.Enqueue(txtBoxElemento.Text);
            updateList();
        }

        void updateList()
        {
            listBox1.DataSource = libros.ToArray();
        }

        private void btnElementoABorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El elemento a borrar es: {libros.Peek()}");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            libros.Dequeue();
            updateList();
        }
    }
}
