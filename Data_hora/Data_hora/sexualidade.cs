using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Data_hora
{
    public partial class sexualidade : Form
    {
        public sexualidade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_emails.Checked == true)
                MessageBox.Show("Sim True", "Confirmado");
            else MessageBox.Show("Não False", "Não Confimado");
        }
    }
}
