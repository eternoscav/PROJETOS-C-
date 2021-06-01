using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adiciona_familia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adiciona_irmaos();
        }
        private void adiciona_irmaos()
        {
        cb_familia.Items.Add("Alessandra");
        cb_familia.Items.Add("Anderson");
        cb_familia.Items.Add("Andrea");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            cb_familia.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_familia.Items[2].ToString());
        }
    }
}
