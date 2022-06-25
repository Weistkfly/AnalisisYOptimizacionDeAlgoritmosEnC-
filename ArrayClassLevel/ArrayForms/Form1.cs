using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayForms
{
    public partial class Form1 : Form
    {
        Pelicula[] peliculasOSeries = new Pelicula[10];
        Pelicula pel = new Pelicula();
        string txtFileName = "pelisculas.txt";
        int i;
        public Form1()
        {
            InitializeComponent();
            i = 0;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pel.Titulo = titulo.Text;
            pel.Director = director.Text;
            pel.Escritor = Escritor.Text;
            pel.Genero = Genero.Text;
            pel.Duracion = duracion.Text;
            pel.Clasificacion = clasificacion.Text;
            pel.Productora = productora.Text;

            peliculasOSeries[i] = new Pelicula
            {
                Titulo = pel.Titulo,
                Director = pel.Director,
                Escritor = pel.Escritor,
                Genero = pel.Genero,
                Duracion = pel.Duracion,
                Clasificacion = pel.Clasificacion,
                Productora = pel.Productora
            };
            
            if (i ==  9)
            {
                MessageBox.Show("No se puede ingresar mas datos");
            } else
            {
                i++;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (File.Exists(txtFileName))
            {
                manageFile();
            }
            else
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
