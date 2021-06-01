using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operacoes_basicas2
{
    public partial class Form1 : Form
    {
        double n1, n2, calculo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            converter();
            calculo = n1 + n2;
            tb_resultado.Text = calculo.ToString();
        }
        private void converter()
        {
            try
            {
                n1 = double.Parse(tb_num1.Text);
                n2 = double.Parse(tb_num2.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel converter");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            converter();
            calculo = n1 - n2;
            tb_resultado.Text = calculo.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            converter();
            calculo = n1 / n2;
            tb_resultado.Text = calculo.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            converter();
            calculo = n1 * n2;
            tb_resultado.Text = calculo.ToString();
        }
    }
}
