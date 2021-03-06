using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursionForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int ascendente(int n)
        {
            if (n < 10)
            {
                return n + ascendente(n + 1);
            }
            else
            {
                return 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reps = Convert.ToInt32(repeticiones.Text);

            while (reps != 0)
            {
                listBox1.Items.Add(ascendente(1));
                reps--;
            }
        }
    }
}
