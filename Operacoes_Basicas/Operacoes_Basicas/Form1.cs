using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operacoes_Basicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, soma;
            n1 = double.Parse(tb_num1.Text);
            n2 = double.Parse(tb_num2.Text);
            soma = n1 + n2;
            tb_resultado.Text = soma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, soma;
            n1 = double.Parse(tb_num1.Text);
            n2 = double.Parse(tb_num2.Text);
            soma = n1 - n2;
            tb_resultado.Text = soma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2, soma;
            n1 = double.Parse(tb_num1.Text);
            n2 = double.Parse(tb_num2.Text);
            soma = n1 / n2;
            tb_resultado.Text = soma.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1, n2, soma;
            n1 = double.Parse(tb_num1.Text);
            n2 = double.Parse(tb_num2.Text);
            soma = n1  *n2;
            tb_resultado.Text = soma.ToString();
        }
    }
}
