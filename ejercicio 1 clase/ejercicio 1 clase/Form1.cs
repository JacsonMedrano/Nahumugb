using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1_clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
            label1.Text = ("Hola Mundo");

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
