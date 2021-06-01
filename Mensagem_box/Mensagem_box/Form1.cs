using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mensagem_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Items", "Excluir", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                MessageBox.Show("O item foi excluido com sucesso", "excluido");
            }else{
                MessageBox.Show("O item foi cancelado com sucesso", "cancelado");
            }
        }
    }
}
