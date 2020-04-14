using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            float Peso;

            Peso = Convert.ToInt64(textBox1.Text);

            double Altura;

            Altura = Convert.ToDouble(textBox2.Text);


            float Resultado;

            Resultado = 

            MessageBox.Show(Resultado);

        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }
}
