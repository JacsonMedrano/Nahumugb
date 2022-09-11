using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_5_clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void operar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(nume1.Text);
            double num2 = Convert.ToDouble(nume2.Text);

            if (suma.Checked == true)
            {
                double suma = num1 + num2;
                

                MessageBox.Show("El Total de la suma es: "+ suma.ToString());
            }
            if (resta.Checked == true)
            {
               double suma = num1 - num2;

                MessageBox.Show("El Total de la resta es: " + suma.ToString());
            }
            if(multi.Checked == true)
            {
                double suma = num1 * num2;
                MessageBox.Show("El Total de la multiplicacion es: " + suma.ToString());
            }
            if (divi.Checked == true)
            {
                double suma = num1 / num2;
                Resul.Text = "El total de la division es: "+ suma.ToString();
            }


             
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
