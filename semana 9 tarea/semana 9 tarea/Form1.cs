using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {

        Empleados Empleado = new Empleados();
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click_1(object sender, EventArgs e)
        {
            int ID;

            if (!int.TryParse(textID.Text, out ID))

            {
                errorProvider1.SetError(textID, "No ingresó un ID válido");
                textNombre.Focus();
                return;
            }
            errorProvider1.SetError(textID, "");



            if (textNombre.Text == "")
            {
                errorProvider1.SetError(textNombre, "No ingreso el nombre");
                textNombre.Focus();
                return;
            }

           
            if (textDUI.Text == "")
            {
                errorProvider1.SetError(textDUI, "No ingreso el Dui");
                textDUI.Focus();
                return;
            }

            errorProvider1.SetError(textNombre, "");


            double Salario;

            if (!double.TryParse(this.textSalario.Text, out Salario))

            {
                errorProvider1.SetError(this.textSalario, "No ingresó el salario de forma correcta");
                this.textSalario.Focus();
                return;
            }
            errorProvider1.SetError(textID, "");

      


            Empleado.Id = Convert.ToInt32(textID.Text);
            Empleado.Nombre = textNombre.Text;
            Empleado.Dui = textDUI.Text;
            Empleado.Salario = Convert.ToDouble(textSalario.Text);
            labelRegistr.Text = "¡Registro guardado!";
        }
        private void labelRegistr_Click(object sender, EventArgs e)
        {

        }

        private void btAFP_Click(object sender, EventArgs e)
        {
            textAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
        }

        private void textAFP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btISSS_Click(object sender, EventArgs e)
        {
            textISSS.Text = Empleado.ISSS(Empleado.Salario).ToString();
        }

        private void btNeto_Click(object sender, EventArgs e)
        {
            textSalarioNeto.Text = Empleado.SalarioNeto(Empleado.Salario).ToString();
        }
    }   
}