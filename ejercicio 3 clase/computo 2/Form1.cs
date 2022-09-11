using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double suma = num1 + num2;
            label1.Text = "La suma es: " + suma.ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double suma = num1 - num2;
            label1.Text = "La resta es: " + suma.ToString();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double suma = num1 * num2;
            label1.Text = "La multiplicacion es: " + suma.ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double suma = num1 / num2;
            label1.Text = "La division es: " + suma.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Num1.Text = "0";
            Num2.Text = "0";
        }
    }

}
